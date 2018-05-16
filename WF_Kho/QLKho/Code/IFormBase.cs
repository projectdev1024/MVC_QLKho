using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Code
{
    public interface IFormBase
    {
        object TResult { get; set; }
        void Save();
        void Cancel();
    }
}
