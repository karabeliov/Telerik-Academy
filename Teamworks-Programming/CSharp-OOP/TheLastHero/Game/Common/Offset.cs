namespace Game.Common
{
    public class Offset
    {
        public Offset(int xOffset = 0, int yOffset = 0)
        {
            this.XOffset = xOffset;
            this.YOffset = yOffset;
        }

        public int XOffset { get; set; }

        public int YOffset { get; set; }
    }
}