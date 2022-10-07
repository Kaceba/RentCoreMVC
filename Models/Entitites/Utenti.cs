using System;
using System.Collections.Generic;

namespace RentCore.Models.Entitites
{
    public partial class Utenti
    {
        public long IdUtente { get; set; }
        public string NomeUtente { get; set; } = null!;
        public string Pwd { get; set; } = null!;
    }
}
