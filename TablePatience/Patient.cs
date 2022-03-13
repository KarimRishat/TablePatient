using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablePatience
{
    public enum Sex { Male, Female };
    
    class Patient
    {
        private uint genNum = 1;
        public uint Id { get; }
        public string NamePatient { get; set; }
        public string SurnamePatient { get; set; }
        public Sex SexPatient { get; set; }
        public DateTime BirthDate { get; set; }
        public string Desease { get; set; }
        public Patient(string[] array)
        {
            NamePatient = array[0];
            SurnamePatient = array[1];
            BirthDate = DateTime.Parse(array[2]);            
            if (array[3].Equals('Ж'))
            {
                SexPatient = Sex.Female;
            }
            else
            {
                SexPatient = Sex.Male;
            }
            Desease = array[4];
            Id = genNum++;
        }
        
    }
}
