using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class AngazujeZivotinjuMapiranja : ClassMap<AngazujeZivotinju>
    {
        public AngazujeZivotinjuMapiranja()
        {
            Table("ANGAZUJE_ZIVOTINJU");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Zivotinja).Column("ID_ZIVOTINJE");
            References(x => x.Cirkuska_Tacka).Column("ID_TACKE");
        }
    }
}
