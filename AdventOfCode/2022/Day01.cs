using System.Diagnostics;

namespace AdventOfCode.Execution._2022
{
    public class Day1 : AdventOfCodeExecutionBase
    {
        public Day1(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void Day1_1()
        {
            using var sr = new StreamReader(@"..\..\..\Inputs\2022\day1input1.txt");
            string line;

            var elves = new List<Elf>();
            Elf elf = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    elf = null;
                    continue;
                }

                if (elf is null)
                {
                    elf = new Elf();
                    elves.Add(elf);
                }

                elf.Food.Add(int.Parse(line));
            }

            output.WriteLine($"Q1 = {elves.Max(x => x.Calories)}");
            output.WriteLine($"Q2 = {elves.OrderByDescending(x => x.Calories).Take(3).Sum(x => x.Calories)}");
        }
    }
}

[DebuggerDisplay("{Calories} from {Food.Count} food items")]
public class Elf
{
    public List<int> Food { get; set; } = new();
    public int Calories => Food.Sum();
}