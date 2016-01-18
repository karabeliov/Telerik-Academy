namespace MobilePhone
{
    public class Display : MobilePhone
    {
        private double size;
        private int numberOfColors;

        public Display()
        {
        }
        public Display(double size, int numberOfColors)
            : this()
        {
            this.Size = size;
            this.numberOfColors = numberOfColors;
        }
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

    }
}
