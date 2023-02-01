namespace ProjectEuler.Problems.Interfaces
{
    internal interface IProblem
    {
        public string Number { get; }
        public string Name { get; }
        public string Description { get; }
        public string Solve();
    }
}
