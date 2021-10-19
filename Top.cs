using System;

namespace ForeignLanguageColourTutor
{
    public class Top : IWrite
    {
        readonly string[] _text;

        public Top(string[] text)
        {
            _text = text;
        }

        public void Write()
        {
            int top = 0;
            foreach (string line in _text)
            {
                Console.SetCursorPosition(0, top);
                Console.Write(line);
                top += 1;
            }
        }
    }
}
