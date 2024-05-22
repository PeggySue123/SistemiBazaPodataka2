﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class EmailDirektora
    {
        public virtual int Id { get; protected set; }
        public virtual string Email { get; set; }

        public virtual Direktor Direktor { get; set; }
    }
}
