using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IFileReader
    {
        string Read(string path);
    }
    class FileReader : IFileReader
    {
        // First step to re-factor code for a loosely coupled design for better testing. 
        // This removes code that touches an external resource and puts it into a separate isolated file.
        public string Read(string path)
        {
          return File.ReadAllText(path);
        }
    }
}
