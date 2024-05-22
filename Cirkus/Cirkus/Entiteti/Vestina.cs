﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class Vestina
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual float Broj_Godina { get; set; }

        public virtual Akrobata Akrobata { get; set; }
    }
}
