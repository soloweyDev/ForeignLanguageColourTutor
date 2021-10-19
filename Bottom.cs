using System;

namespace ForeignLanguageColourTutor
{
    public class Bottom : IWrite
    {
        private int _position = 0;
        readonly string[] _text;

        public Bottom(string[] text)
        {
            _text = text;
        }

        public void Next()
        {
            ++_position;
            if (_position == _text.Length)
            {
                _position = 0;
            }
        }

        public void Previous()
        {
            --_position;
            if (_position < 0)
            {
                _position = _text.Length - 1;
            }
        }

        public void Write()
        {
            int linght = 0;
            foreach (string line in _text)
            {
                linght += line.Length;
            }

            int step = (99 - linght) / (_text.Length - 1);
            int position = 0;
            for (int i = 0; i < _text.Length; ++i)
            {
                Console.SetCursorPosition(position, 29);
                if (i == _position)
                {
                    // цвет текста
                    Console.ForegroundColor = ConsoleColor.Black;
                    // цвет под текстом
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.Write(_text[i].ToUpper());
                position += _text[i].Length + step;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public string GetText()
        {
            return _text[_position];
        }
    }
}
