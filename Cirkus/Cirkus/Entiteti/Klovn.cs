using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class Klovn : Artista
    {
        public virtual int Tip { get; set; }
        public virtual string Predmet_Za_Zabavu { get; set; }
    }
}
