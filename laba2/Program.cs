namespace AllStaffNet6.laba2
{
    public class Program
    {
        private static void Main()
        {
            
            Console.WriteLine("Выберите разделитель: 1) ':', 2) '|', 3) ';', 4) ' '");
            char separator = Console.ReadKey().KeyChar;
            Console.WriteLine("Введите кол-во столбцов и кол-во строк через разделитель:");
            string value = Console.ReadLine();
            string[] splitted = value.Split(separator);
            int nrow = Convert.ToInt32(splitted[1]);
            int ncolumn = Convert.ToInt32(splitted[0]);

            Paper[] papersOneD = new Paper[nrow * ncolumn];
            Paper[,] papersTwoD = new Paper[nrow, ncolumn];
            Paper[][] papersStepwise = new Paper[nrow][];

            var stopWatch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < papersOneD.Length; i++)
            {
                papersOneD[i] = new();
                papersOneD[i].Title = "sdasd";
            }
            papersOneD = null;
            GC.Collect();
            stopWatch.Stop();
            //Console.WriteLine($"Тики после одномерного массива: {TimeSpan.FromMilliseconds(Environment.TickCount):hh\\:mm\\:ss\\:ff}\n");
            Console.WriteLine($"Тики после одномерного и до двумерного: {stopWatch.Elapsed:mm\\:ss\\:ff}");

            stopWatch.Reset();

            stopWatch.Start();

            for (int i = 0; i < papersTwoD.GetLength(0); i++)
            {
                for (int k = 0; k < papersTwoD.GetLength(1); k++)
                {
                    papersTwoD[i, k] = new();
                    papersTwoD[i, k].Title = "sdasd";
                }
            }
            stopWatch.Stop();

            papersTwoD = null;
            GC.Collect();
            //Console.WriteLine($"Тики после двумерного массива: {TimeSpan.FromMilliseconds(Environment.TickCount):hh\\:mm\\:ss\\:ff}\n");
            Console.WriteLine($"Тики после двумерного и до ступенчатого: {stopWatch.Elapsed:mm\\:ss\\:ff}\n");

            stopWatch.Reset();

            stopWatch.Start();

            for (int i = 0; i < papersStepwise.Length; i++)
            {
                papersStepwise[i] = new Paper[ncolumn]; // элемент массива с размерностью ncolumn

                for (int j = 0; j < papersStepwise[i].Length; j++)
                {
                    papersStepwise[i][j] = new();
                    papersStepwise[i][j].Title = "sdasd";
                }
            }

            stopWatch.Stop();
            papersStepwise = null;
            GC.Collect();
            //Console.WriteLine($"Тики после ступенчатого массива: {TimeSpan.FromMilliseconds(Environment.TickCount):hh\\:mm\\:ss\\:ff}\n");
            Console.WriteLine($"Тики после ступенчатого: {stopWatch.Elapsed:mm\\:ss\\:ff}\n");

            //Paper[] papers = new Paper[2]
            //{
            //        new Paper("Загробный мир", new Person("Андрей", "Михайлович", new DateTime(2000, 2, 26)), new DateTime(2025, 12, 4)),
            //        new Paper("Есть ли рай?", new Person("Дмитрий", "Михайлов", new DateTime(2000, 4, 26)), new DateTime(2026, 12, 4))
            //};
            //ResearchTeam research = new ResearchTeam("Исследование древнего мира", "Был ли древний мир?", 22141251, TimeFrame.Long, papers);
            //ResearchTeam research1 = new();
            //Console.WriteLine(research.ToFullString());
            ResearchTeam research = new();
            research.ResearchName = "2222";

            //research.Papers[0] = new("Котик", new Person(), DateTime.Now);
           // Console.WriteLine(research.ToShortString());
            Console.WriteLine(research.ToFullString());
            // Console.WriteLine(research.PaperLast.Title);
        }
      
    }
}