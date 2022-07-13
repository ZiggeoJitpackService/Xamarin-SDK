namespace Ziggeo
{
    public class PlayerStyle
    {
        //Controllers themes for player
        public const int DEFAULT = 0;
        public const int MODERN = 1;
        public const int CUBE = 2;
        public const int SPACE = 3;
        public const int MINIMALIST = 4;
        public const int ELEVATE = 5;
        public const int THEATRE = 6;

        public int ControllerStyle { get; set; } = DEFAULT;
        public int TextColor { get; set; }
        public int UnplayedColor { get; set; }
        public int PlayedColor { get; set; }
        public int BufferedColor { get; set; }
        public int TintColor { get; set; }
        public int MuteOffImageDrawable { get; set; }
        public int MuteOnImageDrawable { get; set; }
    }
}