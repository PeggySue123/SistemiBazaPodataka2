using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class AkrobataMapiranja : SubclassMap<Akrobata>
    {
        public AkrobataMapiranja()
        {
            Table("AKROBATA");

            KeyColumn("ID");

            HasMany(x => x.Poseduje_Vestine).KeyColumn("ID_AKROBATE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
