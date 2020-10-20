namespace DataPlotter
{
    struct Value
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Value(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"{X};{Y}";
    }
}
