using System;
using System.ComponentModel.DataAnnotations;

namespace nature
{
    public class natureProgramme
    {
        public int ID { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set; }
        public string Use { get; set; }
        public string example { get; set; } // this is an auto property
        // public string Fullname { get{
        //     return Firstname + " " + Lastname;
        //     } set{
        //         Firstname = value;
        //     } 
        // }

    }
}

