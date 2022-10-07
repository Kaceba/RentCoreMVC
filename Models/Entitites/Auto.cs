using System;
using System.Collections.Generic;

namespace RentCore.Models.Entitites
{
    public partial class Auto
    {
        public long IdAuto { get; set; }
        public long? IdModello { get; set; }
        public string? Targa { get; set; }
        public byte[]? Costo { get; set; }
        public byte[]? DataAcquisto { get; set; }
    }
}
