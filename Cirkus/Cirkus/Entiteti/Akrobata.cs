using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class Akrobata : Artista 
    {
        public virtual IList<Vestina> Poseduje_Vestine { get; set; }

        public Akrobata()
        {
            Poseduje_Vestine = new List<Vestina>();
        }
    }
}
