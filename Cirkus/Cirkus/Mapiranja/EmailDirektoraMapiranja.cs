using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class EmailDirektoraMapiranja : ClassMap<EmailDirektora>
    {
        public EmailDirektoraMapiranja()
        {
            Table("EMAIL_DIREKTORA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Email, "EMAIL");

            References(x => x.Direktor).Column("ID_DIREKTORA").Not.Nullable().LazyLoad();
        }
    }
}
