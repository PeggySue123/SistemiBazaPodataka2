using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class KlovnMapiranja : SubclassMap<Klovn>
    {
        public KlovnMapiranja()
        {
            Table("KLOVN");

            KeyColumn("ID");

            Map(x => x.Tip).Column("TIP");
            Map(x => x.Predmet_Za_Zabavu).Column("PREDMET_ZA_ZABAVU");
        }
    }
}
