using System;

namespace SomeLibrary
{
    public class GreetingsBuilder
    {
        private readonly string name;

        public GreetingsBuilder(string name)
        {
            this.name = name;
        }

        public string Build()
        {
            return $"Hello, {name}!";
        }
    }
}
