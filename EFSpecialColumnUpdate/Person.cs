using System;
using System.ComponentModel.DataAnnotations;

namespace EFSpecialColumnUpdate
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public double Salary { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
