using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageAufbaukursCSharp
{
    public interface ISaveFilesUtils
    {

        Exception Fault { get;  }
        
        string Message { get; }

        bool Save(object beleg);
        bool Save(object beleg, string path);


    }
}
