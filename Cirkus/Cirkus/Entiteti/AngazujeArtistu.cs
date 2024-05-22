using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class AngazujeArtistu
    {
        public virtual int Id { get; protected set; }

        public virtual Artista Artista { get; set; }
        public virtual CirkuskaTacka Cirkuska_Tacka { get; set; }
    }
}
