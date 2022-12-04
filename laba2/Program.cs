

namespace AllStaffNet6.laba2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Paper[] papers = new Paper[2]
            {
                new Paper("Загробный мир", new Person("Андрей", "Михайлович", new DateTime(2000, 2, 26)), new DateTime(2025, 12, 4)), 
                new Paper("Есть ли рай?", new Person("Дмитрий", "Михайлов", new DateTime(2000, 4, 26)), new DateTime(2026, 12, 4))
            };
            ResearchTeam research = new ResearchTeam("Исследование древнего мира", "Был ли древний мир?", 22141251, TimeFrame.Long, papers);
            Console.WriteLine(research.ToFullString());
            research.AddPapers(new Paper());
          //  Console.WriteLine(research.PaperLast.Title);
        }
    }
}