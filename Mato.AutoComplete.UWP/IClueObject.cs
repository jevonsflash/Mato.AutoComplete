using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mato
{
    public interface IClueObject
    {
        /// <summary>
        /// 线索字符串表
        /// </summary>
        List<string> ClueStrings { get; }
    }
}
