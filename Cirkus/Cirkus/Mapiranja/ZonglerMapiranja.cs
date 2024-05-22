using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class ZonglerMapiranja : SubclassMap<Zongler>
    {
        public ZonglerMapiranja()
        {
            Table("ZONGLER");

            KeyColumn("ID");

            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Broj_Predmeta).Column("BROJ_PREDMETA");
        }
    }
}
