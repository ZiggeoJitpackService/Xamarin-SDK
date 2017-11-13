using System;
using System.Collections.Generic;
using UIKit;
using Foundation;
using CoreFoundation;

namespace Ziggeo
{
    public partial class CoverSelector : VideoProcessor
    {
        class CoverSelectorDataSource: UITableViewSource
        {
            public delegate void CoverSelectedDelegate(nint cover);
            public CoverSelectedDelegate OnCoverSelected = null;

            public delegate nint CoversCountDelegate();
            public CoversCountDelegate OnCoversCount = null;

            public delegate UIImage GetCoverDelegate(nint cover);
            public GetCoverDelegate OnGetCover = null;

            public override nint NumberOfSections(UITableView tableView)
            {
                return 1;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return OnCoversCount != null ? OnCoversCount() : 0;
            }

            public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                //            CoverSelectorTableCell* cell = [tableView dequeueReusableCellWithIdentifier: @"CoverCell"];
                //            if (!cell)
                //            {
                //                UINib* cellNib = [UINib nibWithNibName: @"CoverSelectorTableCell" bundle:[NSBundle bundleForClass:[CoverSelectorController class]]];
                //    [tableView registerNib:cellNib forCellReuseIdentifier:@"CoverCell"];
                //    cell = [tableView dequeueReusableCellWithIdentifier:@"CoverCell"];
                //}
                //if(m_covers && m_covers.count > indexPath.row)
                //{
                //    cell.coverView.image = [m_covers objectAtIndex:indexPath.row];
                //}
                //return cell;
                CoverCell cell = tableView.DequeueReusableCell("CoverCell") as CoverCell;
                if(cell == null)
                {
                    UINib cellNib = UINib.FromName("CoverCell", NSBundle.MainBundle);
                    tableView.RegisterNibForCellReuse(cellNib, "CoverCell");
                    cell = tableView.DequeueReusableCell("CoverCell") as CoverCell;
                }
                if (OnGetCover != null) cell.SetCoverImage(OnGetCover(indexPath.Row));
                return cell;
            }

            public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                return 200;
            }

            public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                OnCoverSelected(indexPath.Row);
            }
        }

        public CoverSelector(VideoItem item) : base("CoverSelector", null, item)
        {
            Covers = new List<UIImage>();
        }

        private List<UIImage> Covers
        {
            get;
            set;
        }

        private CoverGenerator CoverGenerator
        {
            get;
            set;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            CoverGenerator = new CoverGenerator(VideoItem.FilePath);
            CoverGenerator.GenerateCovers((UIImage cover) =>
            {
                Console.WriteLine("cover generated");
                if (cover != null) Covers.Add(cover);
                DispatchQueue.MainQueue.DispatchAsync(TableView.ReloadData);
            }, 4);
            CoverSelectorDataSource dataSource = new CoverSelectorDataSource();
            dataSource.OnGetCover = (nint cover) => {
                Console.WriteLine("cover requested");
                if (Covers.Count > cover && cover >= 0) return Covers[(int)cover];
                return null;
            };
            dataSource.OnCoverSelected = (nint cover) => {
                Console.WriteLine("cover selected");
                if (Covers.Count > cover && cover >= 0)
                {
                    VideoItem.Cover = Covers[(int)cover];
                    DismissAndSignalItsDone();
                }
            };
            dataSource.OnCoversCount = () =>
            {
                Console.WriteLine("covers count requested: {0}", Covers?.Count);
                return Covers.Count;
            };
            TableView.Source = dataSource;
        }

        partial void DefaultCoverButton_Activated(UIBarButtonItem sender)
        {
            if (Covers != null && Covers.Count > 0)
            {
                int defaultCoverIndex = Covers.Count / 2;
                VideoItem.Cover = Covers[defaultCoverIndex];
            }
            DismissAndSignalItsCanceled();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

