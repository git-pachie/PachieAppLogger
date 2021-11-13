using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pachie.App.Logger
{
    public class TextWriter
    {
        public TextWriter()
        {

        }

        public void Write(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
