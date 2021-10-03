using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Students.Domain
{
    public class Schedule
    {
        public int IdSchedule { get; set; }
        public string Name { get; set; }
        public string WorkingDay { get; set; }

        public string ShowScheduleName() 
        {
            return "Este es el horario del lunes";
        }
    }
}
