using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class GradPredstavaMapiranja : ClassMap<GradPredstava>
    {
        public GradPredstavaMapiranja()
        {
            Table("GRAD_PREDSTAVA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Vreme_Odrzavanja, "VREME_ODRZAVANJA");
            Map(x => x.Broj_Prodatih_Karata, "BROJ_PRODATIH_KARATA");

            References(x => x.Grad).Column("ID_GRADA");
            References(x => x.Predstava).Column("ID_PREDSTAVA");
        }
    }
}
