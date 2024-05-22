using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class TelefonDirektoraMapiranja : ClassMap<TelefonDirektora>
    {
        public TelefonDirektoraMapiranja()
        {
            Table("TELEFON_DIREKTORA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Broj_Telefona, "BROJ_TELEFONA");

            References(x => x.Direktor).Column("ID_DIREKTORA").LazyLoad();
        }
    }
}
