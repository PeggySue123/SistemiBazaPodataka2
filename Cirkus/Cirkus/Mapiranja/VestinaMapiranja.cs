using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class VestinaMapiranja : ClassMap<Vestina>
    {
        public VestinaMapiranja()
        {
            Table("VESTINA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Broj_Godina, "BROJ_GODINA");

            References(x => x.Akrobata).Column("ID_AKROBATE").LazyLoad();
        }
    }
}
