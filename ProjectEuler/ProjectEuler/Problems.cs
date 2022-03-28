using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Text;

namespace ProjectEuler
{
    internal class ProblemSolver
    {
        [ImportMany(typeof(IProblem))]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "Needs to be set in CompositionContainer")]
        private List<IProblem>? problems = null;

        public async void SolveProblems()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            if (problems == null)
                return;

            foreach (IProblem problem in problems)
            {
                await Task.Run(() =>
                {
                    var solution = problem.Solve();

                    var sb = new StringBuilder();

                    sb.AppendLine($"Problem {problem.Number}: {problem.Name}");
                    sb.AppendLine();

                    sb.AppendLine(problem.Description);
                    sb.AppendLine();

                    sb.AppendLine($"\tSolution: {solution}");
                    sb.AppendLine();

                    sb.AppendLine("-------------------------------------------------------------------------------------------");

                    Console.WriteLine(sb);
                });
            }
        }
    }
}
