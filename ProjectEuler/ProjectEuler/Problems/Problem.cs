using ProjectEuler.Problems.Interfaces;

namespace ProjectEuler.Problems
{
    internal abstract class Problem : IProblem
    {
        public string Number
        {
            get
            {
                var name = GetType().Name;
                return name.Replace("Problem", string.Empty);
            }
        }

        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract string Solve();
    }
}
