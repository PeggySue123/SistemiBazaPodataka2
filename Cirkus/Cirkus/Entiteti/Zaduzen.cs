﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class Zaduzen
    {
        public virtual int Id { get; protected set; }

        public virtual PomocnoOsoblje Pomocno_Osoblje { get; set; }
        public virtual CirkuskaTacka Cirkuska_Tacka { get; set; }
    }
}
