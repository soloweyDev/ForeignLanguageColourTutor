using System;

namespace ForeignLanguageColourTutor
{
    class Program
    {
        static void Main()
        {
            Top top = new Top(new string[]
            {
                "Top element",
                "2 string",
                "3 string"
            });
            Bottom bottom = new Bottom(new string[]
            {
                "game",
                "exit"
            });
            string[] text = new string[]
            {
                "1 string",
                "2 string",
                "3 string"
            };
            Body body = new Body(text);
            UserInput userInput = new UserInput();

            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.CursorVisible = false;

            while (!userInput.Exit)
            {
                top.Write();
                bottom.Write();
                body.Write();
                userInput.WaitInput(bottom);
            }
        }
    }
}
