using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmdApp.Models
{
    public class Patient
    {
        public int PatientID{ get; set; }
        public string Name { get; set; }

        public ICollection<Ailment>Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }

    }

}
