namespace GSMproject
{
    using System;

    public class Display
    {
        // constants
        private const decimal DEFAUL_SIZE = 3m;
        private const int DEFAULT_COLORS_NUM = 1337;

        // fields
        private decimal size;
        private int numberOfColors;

        // constructors
        public Display(decimal size, int colorNum)
        {
            this.Size = size;
            this.NumberOfColors = colorNum;
        }

        public Display()
            : this(DEFAUL_SIZE, DEFAULT_COLORS_NUM)
        {

        }

        // properties
        public decimal Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("I like it medium rare, thanks");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value > 9000)
                {
                    throw new ArgumentOutOfRangeException("IT'S OVER 9000");
                }
                this.numberOfColors = value;
            }
        }
    }
}
