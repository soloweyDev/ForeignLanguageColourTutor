using System;

namespace ForeignLanguageColourTutor
{
    public class Body : IWrite
    {
        string[] _text;

        public Body(string[] text)
        {
            _text = text;
        }

        public void Write()
        {
            int numLine = 4;
            foreach (string line in _text)
            {
                Console.SetCursorPosition(0, numLine);
                Console.WriteLine(line);
                ++numLine;
            }
        }

        public void SetTest(string[] text)
        {
            _text = text;
        }
    }
}
