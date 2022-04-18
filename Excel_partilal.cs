using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen2
{

    public partial class Excel
    {
        public string img
        {
            get
            {
                if (Cover != null)
                {
                    return Cover;
                }
                else
                {
                    return "img/img.png";
                }
            }
        }
    }
}

