using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class AsistentiMapiranja : SubclassMap<Asistenti>
    {
        public AsistentiMapiranja()
        {
            Table("ASISTENTI");

            KeyColumn("ID");

            References(x => x.Artista_Sa_Asistentima).Column("ID_ARTISTE_SA_ASISTENTIMA").Not.Nullable();
        }
    }
}
