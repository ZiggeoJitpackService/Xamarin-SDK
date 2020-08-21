using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;

namespace Ziggeo
{
    public partial class Player : IZiggeoPlayer
    {
        public Player(IZiggeoApplication application)
        {
            this.Application = application;
            this.Ziggeo = ((ZiggeoApplication) Application).Ziggeo;
        }

        private IZiggeo Ziggeo;
        public Dictionary<string, string> AdditionalParameters { get; set; }

        public IZiggeoApplication Application { get; private set; }

        public Task Play(string videoToken)
        {
            TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
            try
            {
                Ziggeo.StartPlayer(videoToken);
            }
            catch (Exception ex)
            {
                tcs.TrySetException(ex);
            }

            return tcs.Task;
        }
    }
}