using System;
using System.Collections.Generic;

namespace RentCore.Models.Entitites
{
    public partial class Contratti
    {
        public long IdContratto { get; set; }
        public long? IdCliente { get; set; }
        public long? IdAuto { get; set; }
        public byte[]? DataInizio { get; set; }
        public byte[]? DataFine { get; set; }
    }
}
