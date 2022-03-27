namespace ProjectEuler
{
    internal interface IProblem
    {
        public int Number { get; }
        public string Name { get; }
        public string Description { get; }
        public string Solve();
    }
}
