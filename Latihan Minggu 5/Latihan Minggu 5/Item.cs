﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Minggu_5
{
    using System;
    using System.Collections.Generic;

    public partial class TB_M_Items
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool isdelete { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
