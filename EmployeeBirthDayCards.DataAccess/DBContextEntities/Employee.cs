namespace EmployeeBirthDayCards.DataAccess.DBContextEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int Employee_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        public DateTime Birth_Date { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(50)]
        public string Email_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Created { get; set; }

        public DateTime Date_Created { get; set; }

        [StringLength(50)]
        public string User_Changed { get; set; }

        public DateTime? Date_Changed { get; set; }
    }
}
