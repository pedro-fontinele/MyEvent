namespace MyEvents.API.Domain.Entity.Dto
{
    public class BatchDto
    {
        public uint IdBatch { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public uint TheAmount { get; set; }
        public uint IdEvent { get; set; }
        public EventDto EventDto { get; set; }
    }
}
