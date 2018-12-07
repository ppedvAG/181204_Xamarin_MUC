using System;
using System.Collections.Generic;
using System.Text;

namespace DatenSpeichernUndLaden
{
    public interface ISaveAndLoadText
    {
        void Save(string filename, string content);
        string Load(string filename);
    }
}
