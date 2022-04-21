using System;
using System.Collections.Generic;
using System.Text;

namespace TuringMachine
{
    class TuringMachine
    {
        const string _TO_LEFT = "L";
        const string _TO_RIGHT = "R";

        readonly Dictionary<int, string> _commands;
        readonly string _alphabet;
        string _ribbon;

        public TuringMachine(string alphabet, Dictionary<int, string> commands)
        {
            _alphabet = alphabet;
            _commands = commands;
        }

/*        public string Next()
        {

        }*/
    }
}
