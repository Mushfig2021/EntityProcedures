using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirst.Procedure.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int? ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}