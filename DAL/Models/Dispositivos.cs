using System;

namespace DAL.Models
{
    public partial class Dispositivos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Hostname { get; set; }
        public string Macaddress { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
