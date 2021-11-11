using System;

namespace ForeignLanguageColourTutor
{
    public class UserInput
    {
        public bool Exit { get; private set; } = false;

        public void WaitInput(Bottom bottom)
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    bottom.Previous();
                    break;
                case ConsoleKey.RightArrow:
                    bottom.Next();
                    break;
                case ConsoleKey.Enter:
                    if (bottom.GetText() == "exit")
                    {
                        Exit = true;
                    }

                    switch (bottom.GetText())
                    {
                        case "spanish":
                            Program.gameZone = GameZone.Spanish;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
