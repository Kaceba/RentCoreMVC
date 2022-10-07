using System;
using System.Collections.Generic;

namespace RentCore.Models.Entitites
{
    public partial class TipiSpese
    {
        public TipiSpese()
        {
            Speses = new HashSet<Spese>();
        }

        public long IdTipoSpesa { get; set; }
        public string Descrizione { get; set; } = null!;

        public virtual ICollection<Spese> Speses { get; set; }
    }
}
