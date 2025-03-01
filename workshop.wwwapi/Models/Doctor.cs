﻿using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    //TODO: decorate class/columns accordingly
    [Table("doctors")]
    public class Doctor
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("full_name")]
        public string FullName { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
