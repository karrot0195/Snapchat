using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapChat.PlugIns
{
    class ChucNang
    {
        IChucNang.IChucNang _chucnang;
        public IChucNang.IChucNang Chucnang
        {
            get { return _chucnang; }
            set { _chucnang = value; }
        }
    }
}
