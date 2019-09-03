using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Composition
{
    class ButtonsByComposition
    {
        public static void Example()
        {
            Button[] buttons = new Button[]
            {
                new Button(new Output(Console.Out, new CurrentDateProvider())),
                new Button(new Output(new StreamWriter(File.OpenWrite("log.txt")), new CurrentDateProvider())),
                new Button(new Output(new StreamWriter(File.OpenWrite("log.txt")), new CurrentTimeProvider())),
            };
        }
    }

    class Button
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public ConsoleColor Color { get; private set; }

        private IEnumerable<IAction> _actions;

        public Button(params IAction[] actions)
        {
            _actions = actions;
        }

        public void Draw()
        {

        }

        public void OnPress()
        {
            foreach (var action in _actions)
                action.Do();
        }
    }

    interface IAction
    {
        void Do();
    }

    interface IDataProvider
    {
        string GetData();
    }

    class CurrentDateProvider : IDataProvider
    {
        public string GetData()
        {
            return DateTime.Now.ToString("dd:MM:YYYY");
        }
    }

    class CurrentTimeProvider : IDataProvider
    {
        public string GetData()
        {
            return DateTime.Now.ToString("hh:mm");
        }
    }


    class Output : IAction
    {
        private TextWriter _output;
        private IDataProvider _provider;

        public Output(TextWriter output, IDataProvider provider)
        {
            _output = output;
            _provider = provider;
        }

        public void Do()
        {
            _output.WriteLine(_provider.GetData());
        }
    }
}
