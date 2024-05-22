using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class ZaduzenMapiranja : ClassMap<Zaduzen>
    {
        public ZaduzenMapiranja()
        {
            Table("ZADUZEN");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Pomocno_Osoblje).Column("ID_POMOCNOG_OSOBLJA").LazyLoad();
            References(x => x.Cirkuska_Tacka).Column("ID_TACKE").LazyLoad();
        }
    }
}
