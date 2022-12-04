using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022
{
    internal class Utils
    {

        public static int ScoreRockPaperScissors(string s)
        {
            switch (s)
            {
                case "A X":
                    return 1 + 3;
                case "A Y":
                    return 2 + 6;
                case "A Z":
                    return 3 + 0;

                case "B X":
                    return 1 + 0;
                case "B Y":
                    return 2 + 3;
                case "B Z":
                    return 3 + 6;

                case "C X":
                    return 1 + 6;
                case "C Y":
                    return 2 + 0;
                case "C Z":
                    return 3 + 3;

                default:
                    throw new ArgumentException(s);
            }
        }

        internal static string SelectStrategy(string s)
        {
            switch (s)
            {
                case "A Z":
                    return "A Y";
                case "A Y":
                    return "A X";
                case "A X":
                    return "A Z";

                case "B Z":
                    return "B Z";
                case "B Y":
                    return "B Y";
                case "B X":
                    return "B X";

                case "C Z":
                    return "C X";
                case "C Y":
                    return "C Z";
                case "C X":
                    return "C Y";

                default:
                    throw new ArgumentException(s);
            }
        }
    }
}
