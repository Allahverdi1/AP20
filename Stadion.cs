using System;
using System.Collections.Generic;
using System.Text;

namespace StadionTask.Data.Entities
{
    internal class Stadion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double HourPrice { get; set; }
        public int Capacity { get; set; }
        
    }
}
