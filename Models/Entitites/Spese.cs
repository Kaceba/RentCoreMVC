using System;
using System.Collections.Generic;

namespace RentCore.Models.Entitites
{
    public partial class Spese
    {
        public long IdSpesa { get; set; }
        public long? IdTipoSpesa { get; set; }
        public byte[]? Importo { get; set; }
        public byte[]? DataSpesa { get; set; }

        public virtual TipiSpese? IdTipoSpesaNavigation { get; set; }
    }
}
