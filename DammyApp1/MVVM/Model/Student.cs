using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DammyApp1.MVVM.Model
{
    public  class Student
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public double Percentage { get; set; }
        public Student(int id, string fName,string lName,string gender,double percentage)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
            this.Gender = gender;
            this.Percentage = percentage;

        }
    }
}
