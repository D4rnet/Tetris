namespace Tetris
{
    public class Stats
    {
        public int Score { get; private set; }

        public int Lines { get; private set; }
        private double CompletionsCount;
        private double TetrisCount;
        public int Burned { get; private set; }

        public Stats()
        {
            Score = 0;
            Lines = 0;
            CompletionsCount = 0;
            TetrisCount = 0;
            Burned = 0;
        }

        public void Scoring(int Lines)
        {
            if (Lines != 0)
            {
                switch (Lines)
                {
                    case 1:
                        Score += 100;
                        break;
                    case 2:
                        Score += 300;
                        break;
                    case 3:
                        Score += 700;
                        break;
                    case 4:
                        Score += 1500;
                        break;
                    default:
                        break;
                }

                this.Lines += Lines;
                ++CompletionsCount;
                if (Lines == 4)
                {
                    ++TetrisCount;
                    Burned = 0;
                }
                else
                    Burned+=Lines;
            }
        }

        public double PercentOfTetris()
        {
            return TetrisCount / CompletionsCount * 100;
        }
    }
}
