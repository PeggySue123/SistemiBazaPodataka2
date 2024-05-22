﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class GutaciPlamena : Artista
    {
        public virtual IList<Asistenti> Asistenti { get; set; }

        public GutaciPlamena()
        {
            Asistenti = new List<Asistenti>();
        }
    }
}
