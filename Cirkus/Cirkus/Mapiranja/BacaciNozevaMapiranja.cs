using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranja
{
    class BacaciNozevaMapiranja : SubclassMap<BacaciNozeva>
    {
        public BacaciNozevaMapiranja()
        {
            Table("BACACI_NOZEVA");

            KeyColumn("ID");
        }
    }
}
