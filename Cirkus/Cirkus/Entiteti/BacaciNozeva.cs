using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class BacaciNozeva : Artista
    {
        public virtual IList<Asistenti> Asistenti { get; set; }

        public BacaciNozeva()
        {
            Asistenti = new List<Asistenti>();
        }
    }
}
