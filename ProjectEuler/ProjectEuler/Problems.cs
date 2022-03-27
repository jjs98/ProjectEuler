using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Text;

namespace ProjectEuler
{
    internal class Problems
    {
        [ImportMany(typeof(IProblem))]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "Needs to be set in CompositionContainer")]
        private List<IProblem>? problems = null;

        public void SolveProblems()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            if (problems == null)
                return;

            foreach (IProblem problem in problems)
            {
                var sb = new StringBuilder();

                sb.AppendLine($"Problem {problem.Number}: {problem.Name}");
                sb.AppendLine();

                sb.AppendLine(problem.Description);
                sb.AppendLine();

                sb.AppendLine($"\tSolution: {problem.Solve()}");
                sb.AppendLine();

                sb.AppendLine("-------------------------------------------------------------------------------------------");

                Console.WriteLine(sb);
            }
        }
    }
}
