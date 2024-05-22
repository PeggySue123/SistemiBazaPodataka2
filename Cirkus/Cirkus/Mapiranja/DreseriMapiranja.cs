using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class DreseriMapiranja : SubclassMap<Dreseri>
    {
        public DreseriMapiranja()
        {
            Table("DRESERI");

            KeyColumn("ID");

            HasMany(x => x.Dresira).KeyColumn("ID_DRESERA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Asistenti).KeyColumn("ID_ARTISTE_SA_ASISTENTIMA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
