using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cirkus.Entiteti
{
    public class TelefonNarucioca
    {
        public virtual int Id { get; protected set; }
        public virtual string Broj_Telefona { get; set; }

        public virtual Predstava Narucioc_Predstave { get; set; }
    }
}
