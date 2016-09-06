using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.Logger
{
    public interface IFileLogger : ILogger
    {
        string FilePath { get; set; }
    }
}
