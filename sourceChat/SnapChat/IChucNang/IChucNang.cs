using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IChucNang
{
    public interface IChucNang
    {
        String Ten{get;set;}
        String Value { get; set; }
        String Key { get; set; }
        Form GiaoDien { get; }
        void laygiatri();
    }
}
