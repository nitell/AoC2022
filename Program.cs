using AoC2022;
using System.Text;

Console.WriteLine(Day04A());
Console.WriteLine(Day04B());

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

static int Day04A()
{
    return File.ReadAllLines("Day04.txt").Select(s => s.Split(',').Select(x => x.Split('-').ToArray()).ToArray())
        .Select(a => new { Elf1Start = int.Parse(a[0][0]), Elf1End = int.Parse(a[0][1]), Elf2Start = int.Parse(a[1][0]), Elf2End = int.Parse(a[1][1]) })
        .Where(o => ((o.Elf1Start >= o.Elf2Start) && (o.Elf1End <= o.Elf2End)) || ((o.Elf2Start >= o.Elf1Start) && (o.Elf2End <= o.Elf1End))).Count();
}
static int Day04B()
{
    return File.ReadAllLines("Day04.txt").Select(s => s.Split(',').Select(x => x.Split('-').ToArray()).ToArray())
    .Select(a => new { Elf1Start = int.Parse(a[0][0]), Elf1End = int.Parse(a[0][1]), Elf2Start = int.Parse(a[1][0]), Elf2End = int.Parse(a[1][1]) })
    .Where(o => Enumerable.Range(o.Elf1Start, o.Elf1End - o.Elf1Start + 1).Intersect(Enumerable.Range(o.Elf2Start, o.Elf2End - o.Elf2Start + 1)).Any()).Count();
}





