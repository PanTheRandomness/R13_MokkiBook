﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R13_MokkiBook
{
    internal class Alue
    {
        public List<Alue> alueet = new List<Alue>();
        public int alue_id { get; set; }
        public string nimi { get; set; }
    }
}
