namespace hw2
{
    internal class SquareMatrix : ICloneable
    {
        private double[][] _matrix = null!;
        private readonly int _size;

        public double this[int i, int j] { get => _matrix[i][j]; set => _matrix[i][j] = value; }
        public double[][] Matrix { get => _matrix; set => _matrix = value.Select(arr => arr.ToArray()).ToArray(); }
        public int Length => _size;

        public SquareMatrix(double[][] matrix)
        {
            Matrix = matrix;
            _size = matrix.Length;
        }
        public SquareMatrix(int n)
        {
            _size = n;
            _matrix = Enumerable.Range(0, _size).Select(_ => new double[_size]).ToArray();
        }
        public SquareMatrix (string? path = null)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));
            using StreamReader reader = new StreamReader(path);
            int row = 0;
            _size = int.Parse(reader.ReadLine()!);
            _matrix = Enumerable.Range(0, _size).Select(_ => new double[_size]).ToArray();
            while (!reader.EndOfStream) _matrix[row++] = reader.ReadLine()!.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        }
        public override string ToString() => $"{string.Join("\n",Enumerable.Range(0,_size).Select(RowToString))}";
        public string RowToString(int i) => string.Join(" ",Enumerable.Range(0, _matrix[i].Length).Select(j => this[i,j]));
        public object Clone() => new SquareMatrix (_matrix);
        public void FillDiagonalMatrix(double elem) => _matrix =  Enumerable.Range(0,_size).
            Select(i => Enumerable.Range(0, _size).Select(j => i==j ? elem : 0).ToArray()).ToArray();
    }
}
