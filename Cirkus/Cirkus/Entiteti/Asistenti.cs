using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class Asistenti : Artista
    {
        public virtual Artista Artista_Sa_Asistentima { get; set; }
    }
}
