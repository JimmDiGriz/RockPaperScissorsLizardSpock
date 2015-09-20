using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RockPaperScissorsLizardSpock
{
    class Move
    {
        private enum Variants
        { 
            Rock,
            Scissors,
            Paper,
            Lizard,
            Spock
        }

        private Variants Variant { get; set; }

        public Move()
        {
            Variant = Variants.Rock;
        }

        public static bool operator ==(Move left, Move right)
        {
            return left.Variant == right.Variant;
        }

        public static bool operator !=(Move left, Move right)
        {
            return left.Variant != right.Variant;
        }

        public static bool operator >(Move left, Move right)
        {
            bool result = false;
            switch (left.Variant)
            { 
                case Variants.Rock:
                    if (right.Variant == Variants.Scissors || right.Variant == Variants.Lizard)
                    {
                        result = true;
                    }
                    break;
                case Variants.Scissors:
                    if (right.Variant == Variants.Paper || right.Variant == Variants.Lizard)
                    {
                        result = true;
                    }
                    break;
                case Variants.Paper:
                    if (right.Variant == Variants.Rock || right.Variant == Variants.Spock)
                    {
                        result = true;
                    }
                    break;
                case Variants.Lizard:
                    if (right.Variant == Variants.Paper || right.Variant == Variants.Spock)
                    {
                        result = true;
                    }
                    break;
                default:
                    if (right.Variant == Variants.Scissors || right.Variant == Variants.Rock)
                    {
                        result = true;
                    }
                    break;
            }

            return result;
        }

        public static bool operator >=(Move left, Move right)
        {
            return left == right || left > right;
        }

        public static bool operator <(Move left, Move right)
        {
            return !(left >= right);
        }

        public static bool operator <=(Move left, Move right)
        {
            return left == right || left < right;
        }

        public Move DoMove()
        {
            Variant = (Variants)new Random().Next(0, 5);
            Thread.Sleep(10);
            return this;
        }

        public string ToString()
        {
            string result;

            switch (Variant)
            { 
                case Variants.Rock:
                    result = "Rock";
                    break;
                case Variants.Scissors:
                    result = "Scissors";
                    break;
                case Variants.Paper:
                    result = "Paper";
                    break;
                case Variants.Lizard:
                    result = "Lizard";
                    break;
                default:
                    result = "Spock";
                    break;
            }

            return result;
        }
    }
}