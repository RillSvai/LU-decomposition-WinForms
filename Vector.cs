namespace hw2
{
    internal class Vector : ICloneable
    {
        private double[]? _content;

        public double[]? Content { get => _content; set => _content = value!.Select(elem => elem).ToArray(); }
        public Vector(int n = 0) => _content = new double[n];
        public Vector(double[]? content) => Content = content;

        public Vector(string line) => _content = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        public double this[int i ] { get => _content![i]; set => _content![i] = value; }
        public override string ToString() => $"{string.Join(" ", _content!)}";
        public object Clone() => new Vector(Content);
    }
}
