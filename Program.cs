﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForeignLanguageColourTutor
{
    public class Program
    {
        private static readonly Dictionary<int, string> english = new Dictionary<int, string>()
        {
            { 0, "red" },
            { 1, "orange" },
            { 2, "yellow" },
            { 3, "green" },
            { 4, "blue" },
            { 5, "purple" },
            { 6, "brown" },
            { 7, "black" },
            { 8, "grey" },
            { 9, "white" },
            { 10, "indigo" },
            { 11, "pink" }
        };
        private static readonly Dictionary<int, string> spanish = new Dictionary<int, string>()
        {
            { 0, "rojo" },
            { 1, "naranja" },
            { 2, "amarillo" },
            { 3, "verde" },
            { 4, "azul" },
            { 5, "púrpura" },
            { 6, "marrón" },
            { 7, "negro" },
            { 8, "gris" },
            { 9, "blanco" },
            { 10, "indigo" },
            { 11, "rosa" }
        };

        public static GameZone gameZone = GameZone.Help;

        static void Main()
        {
            UserInput userInput = new UserInput();

            Top top = new Top(new string[]
            {
                "Foreign Language Colour Tutor"
            });

            Bottom bottom = new Bottom(new string[]
            {
                "spanish",
                "exit"
            });

            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.CursorVisible = false;
            Console.InputEncoding = Encoding.Unicode;

            while (!userInput.Exit)
            {
                Console.Clear();
                switch (gameZone)
                {
                    case GameZone.Help:
                        Help();
                        gameZone = GameZone.Menu;
                        break;
                    case GameZone.Menu:
                        Menu(userInput, bottom);
                        break;
                    case GameZone.Spanish:
                        Translation(top, bottom);
                        break;
                    default:
                        Console.WriteLine("Error gameZone.");
                        gameZone = GameZone.Help;
                        break;
                }
            }
        }

        private static void Help()
        {
            Console.WriteLine(@"
Wellcome to Foreign Language Colour Tutor



You will be shown words in English.
You need to enter the translation in Spanish and press the Enter key twice.

To exit, press the Enter key.
Then move the left or right keys to Exit and press the Enter key.



To continue press any key");
            Console.ReadKey();
        }

        private static void Translation(Top top, Bottom bottom)
        {
            Random random = new Random();

            Body body = new Body();

            int[] array = Enumerable.Range(0, 12).OrderBy(y => random.Next()).Take(8).ToArray();
            for (int i = 0; i < 8; ++i)
            {
                Console.Clear();
                int index = array[i];
                top.Write();
                bottom.Write();
                body.SetText(english[index]);
                body.Write();
                string input = Console.ReadLine();
                if (input == spanish[index])
                {
                    Console.WriteLine("The correct translation");
                }
                else
                {
                    Console.WriteLine("It was wrong. Correct translation:");
                    Console.WriteLine(spanish[index]);
                }
                System.Threading.Thread.Sleep(2000);
            }

            gameZone = GameZone.Menu;
        }

        private static void Menu(UserInput userInput, Bottom bottom)
        {
                bottom.Write();
                userInput.WaitInput(bottom);
        }
    }
}
