using AoC2022;

Console.WriteLine(Day02A());
Console.WriteLine(Day02B());

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





