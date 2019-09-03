using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Button[] onScreen = new Button[]
            {
                new ShowTextButton("Hello"),
                new ShowDateButton(),
                new ShowTimeButton()
            }
        }
    }


    abstract class Button
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public ConsoleColor Color { get; private set; }

        public void Draw()
        {

        }

        public abstract void OnPress();
    }

    class ShowTextButton : Button
    {
        private readonly string _text;

        public ShowTextButton(string text)
        {
            _text = text;
        }

        public ShowTextButton()
        {

        }

        public override void OnPress()
        {
            Console.WriteLine(GetText());
        }

        public virtual string GetText()
        {
            return _text;
        }
    }

    class ShowDateButton : ShowTextButton
    {
        public override string GetText()
        {
            return DateTime.Now.ToString("dd:MM:YYYY");
        }
    }

    class ShowTimeButton : ShowTextButton
    {
        public override string GetText()
        {
            return DateTime.Now.ToString("hh:mm");
        }
    }
}
