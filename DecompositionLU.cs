namespace hw2
{
    internal class DecompositionLU
    {
        private readonly SquareMatrix? _mainMatrix;
        private SquareMatrix _UMatrix;
        private SquareMatrix _LMatrix;
        private readonly Vector? _freeMembers;
        private Vector _transitJunctions;
        private Vector _junctions;
        private double _determinant;

        public DecompositionLU(SquareMatrix mainMatrix, Vector freeMembers)
        {
            _mainMatrix = mainMatrix.Clone() as SquareMatrix;
            _freeMembers = freeMembers.Clone() as Vector;
            _junctions = new Vector(mainMatrix.Length);
            _transitJunctions = new Vector(mainMatrix.Length);
            _UMatrix = new SquareMatrix(_mainMatrix!.Length);
            _LMatrix = new SquareMatrix(_mainMatrix.Length);

        }
        public override string ToString() => $"Main matrix:\n{_mainMatrix}\nU-matrix:\n{_UMatrix}\nL-matrix:\n{_LMatrix}\nDeterminant => " +
            $"{_determinant}\nFree members => {_freeMembers}\nTransit junctions => {_transitJunctions}\nJunctions => {_junctions}\n";
        public double Determinant { get => _determinant; }
        public SquareMatrix MainMatrix { get => _mainMatrix; }
        public SquareMatrix Umatrix { get => _UMatrix; }
        public SquareMatrix LMatrix { get => _LMatrix; }
        public Vector FreeMembers { get => _freeMembers; }
        public Vector Junctions { get => _junctions; }

        public void FillingLU()
        {
            _LMatrix.FillDiagonalMatrix(1);
            for (int i = 0; i < _mainMatrix!.Length; i++)
            {
                for (int j = 0; j < _LMatrix.Length; j++)
                {
                    if (i <= j) _UMatrix[i, j] = _mainMatrix[i, j] - Enumerable.Range(0, i + 1).
                            Select(k => _LMatrix[i, k] * _UMatrix[k, j]).Sum();
                    else _LMatrix[i, j] = (_mainMatrix[i, j] - Enumerable.Range(0, i + 1).
                            Select(k => _LMatrix[i, k] * _UMatrix[k, j]).Sum()) / _UMatrix[j, j];
                }
            }
            _determinant = Enumerable.Range(0, _UMatrix.Length).Select(i => _UMatrix[i, i]).Aggregate((x, y) => x * y);
        }

        public void FindJunctions()
        {
            double substractor = 0;
            for (int i = _mainMatrix!.Length - 1; i >= 0; i--)
            {
                for (int j = _LMatrix.Length - 1; j >= 0; j--)
                {
                    if (i != j)
                    {
                        substractor -= _UMatrix[i, j] * _junctions[j];
                    }
                }
                _junctions[i] = (_transitJunctions[i] + substractor) / _UMatrix[i, i];
                substractor = 0;
            }
        }

        public void FindTransitJunctions()
        {
            double substractor = 0;
            for (int i = 0; i < _LMatrix.Length; ++i)
            {
                for (int j = 0; j < _LMatrix.Length; ++j)
                {
                    if (i != j)
                    {
                        substractor -= _LMatrix[i, j] * _transitJunctions[j];
                    }
                }
                _transitJunctions[i] = (_freeMembers[i] + substractor) / _LMatrix[i, i];
                substractor = 0;
            }
        }
        public string CheckingResult() => string.Join(" ", Enumerable.Range(0, _mainMatrix.Length).
            Select(i => string.Join("", Enumerable.Range(0, _mainMatrix.Length).
            Select(j => _mainMatrix[i, j] * _junctions[j]).Sum()) + $" == {_freeMembers[i]} ?"));
    }
    

    
}
