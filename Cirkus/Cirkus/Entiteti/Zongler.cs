using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class Zongler : Artista
    {
        public virtual string Naziv { get; set; }
        public virtual int Broj_Predmeta { get; set; }
    }
}
