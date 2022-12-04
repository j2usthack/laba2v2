

namespace AllStaffNet6.laba2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ResearchTeam research = new ResearchTeam();
            Console.WriteLine(research.ToFullString());
            research.AddPapers(new Paper());
            Console.WriteLine(research.PaperLast.Title);
        }
    }
}