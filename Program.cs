using AoC2022;
using System.Text;

Console.WriteLine(Day03A());
Console.WriteLine(Day03B());

static int Day01A()
{
    return File.ReadAllText("Day01.txt").Split("\r\n\r\n").Select(s => s.Split("\r\n")).Select(elf => elf.Select(r => int.Parse(r))).Select(elf => elf.Sum()).Max();
}
static int Day01B()
{
    return File.ReadAllText("Day01.txt").Split("\r\n\r\n").Select(s => s.Split("\r\n")).Select(elf => elf.Select(r => int.Parse(r))).Select(elf => elf.Sum()).OrderByDescending(sum => sum).Take(3).Sum();
}

static int Day02A()
{
    return File.ReadAllLines("Day02.txt").Sum(r => Utils.ScoreRockPaperScissors(r));
}

static int Day02B()
{
    return File.ReadAllLines("Day02.txt").Select(r=> Utils.SelectStrategy(r)).Sum(r => Utils.ScoreRockPaperScissors(r));
}

static int Day03A()
{
    return File.ReadAllLines("Day03.txt").Select(s => (s.Substring(0, s.Length / 2), s.Substring(s.Length / 2)))
        .Select(a => Encoding.ASCII.GetBytes(a.Item1).Intersect(Encoding.ASCII.GetBytes(a.Item2))).Select(p => p.First())
        .Select(r => r < 97 ? r - 65 + 27 : r - 96).Sum();                
}

static int Day03B()
{
    return File.ReadAllLines("Day03.txt").Select(r=>Encoding.ASCII.GetBytes(r)).Chunk(3)
        .Select(g =>
        {
            var arr = g.ToArray();
            return arr[0].Intersect(arr[1]).Intersect(arr[2]).First();
        }).Select(r => r < 97 ? r - 65 + 27 : r - 96).Sum();
}





