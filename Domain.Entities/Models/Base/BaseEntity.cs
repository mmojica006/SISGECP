using System;

namespace Domain.Entities.Models.Base
{
    public class BaseEntity
    {
        public int id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public bool estado { get; set; }
    }
}
