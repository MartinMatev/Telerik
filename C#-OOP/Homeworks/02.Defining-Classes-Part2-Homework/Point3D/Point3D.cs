namespace Point3D
{
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);
        public int XCord { get; set; }  // public set, because the Path class need to have access in order to set them
        public int YCord { get; set; }
        public int ZCord { get; set; }

        public Point3D(int x, int y, int z) : this()
        {
            this.XCord = x;
            this.YCord = y;
            this.ZCord = z;
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
            private set { }
        }

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", this.XCord, this.YCord, this.ZCord);
        }
    }
}
