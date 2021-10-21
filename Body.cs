using System;

namespace ForeignLanguageColourTutor
{
    public class Body : IWrite
    {
        string _text;

        public Body()
        {
        }

        public void Write()
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine(_text);
        }

        public void SetText(string text)
        {
            _text = text;
        }
    }
}
