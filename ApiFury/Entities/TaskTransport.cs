using System.Collections.Generic;
using ApiFury.Entities;

namespace ApiFury.Models
{
    public class TaskTransport
    {
        public int Id { get; set; }
        public List<Transport> Transports { get; set; } = new List<Transport>();
        public Task task { get; set; }
    }
}