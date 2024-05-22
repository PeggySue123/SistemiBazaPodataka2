using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class AngazujeArtistuMapiranja : ClassMap<AngazujeArtistu>
    {
        public AngazujeArtistuMapiranja()
        {
            Table("ANGAZUJE_ARTISTU");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Artista).Column("ID_ARTISTE");
            References(x => x.Cirkuska_Tacka).Column("ID_TACKE");
        }
    }
}
