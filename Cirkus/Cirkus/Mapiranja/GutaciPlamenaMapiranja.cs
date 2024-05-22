using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class GutaciPlamenaMapiranja : SubclassMap<GutaciPlamena>
    {
        public GutaciPlamenaMapiranja()
        {
            Table("GUTACI_PLAMENA");

            KeyColumn("ID");

            HasMany(x => x.Asistenti).KeyColumn("ID_ARTISTE_SA_ASISTENTIMA").LazyLoad().Cascade.All().Inverse();
        }
    }
}