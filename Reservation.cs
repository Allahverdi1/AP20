using System;
using System.Collections.Generic;
using System.Text;

namespace StadionTask.Data.Entities
{
    internal class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StadionId { get; set; }
        public Stadion Stadions { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
