using System;
using System.Collections.Generic;

namespace RentCore.Models.Entitites
{
    public partial class Clienti
    {
        public long IdCliente { get; set; }
        public string? RagioneSociale { get; set; }
        public string PartitaIva { get; set; } = null!;
        public string? CodiceFiscale { get; set; }
        public string? Indirizzo { get; set; }
        public string? Cap { get; set; }
        public string? Citta { get; set; }
        public string? Provincia { get; set; }
    }
}
