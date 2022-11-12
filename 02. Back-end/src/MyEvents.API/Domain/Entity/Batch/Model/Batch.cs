using System;
using System.ComponentModel.DataAnnotations;

namespace MyEvents.API.Domain.Entity.Model
{
    public class Batch
    {
        [Key]
        public uint IdBatch { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public uint TheAmount { get; set; }
        public uint IdEvent { get; set; }
        public Event Event { get; set; }
    }
}
