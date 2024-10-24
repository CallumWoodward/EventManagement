namespace EventManagement.Models
{
    public class Events
    {
        public int Id { get; set; }

        public string EventName { get; set; }

        public string? EventHost { get; set; }

        public bool Online { get; set; }

        public string? EventLocation { get; set; }

        public string? EventDescription { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly? EndDate { get; set;}

        public TimeOnly StartTime { get; set; }

        public TimeOnly? EndTime { get; set;  }
    }
}
