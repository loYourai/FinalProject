using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RecurrencySetting
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime StartDate { get; set; }


        public RepeatInterval RepeatInterval { get; set; }

        public DateTime RepeatUntil { get; set; }
    }
}
