using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.Logger
{
    public interface ILogger
    {

       
        void WriteHeader(string header);
        void WriteDetails(List<string> details);
        void WriteToFile();
        
    }
}
