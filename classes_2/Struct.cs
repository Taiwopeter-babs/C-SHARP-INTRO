namespace AllStructsAndInterfaces
{
    public struct PointStruct : ICoordinate
    {
        public double A { get; }
        public double B { get; }

        public PointStruct(double a, double b)
        {
            A = a;
            B = b;
        }

        public List<double> MyCoordinates()
        {
            List<double> returnList = new List<double> { A, B };
            return returnList;
        }
    }
}