﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseholdManager.Models
{
    public class Household
    {
        public Household()
        {
            Members = new HashSet<Member>();
            Rooms = new HashSet<Room>();
            Missions = new HashSet<Mission>();
        }

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = "";

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Mission> Missions { get; set; }

        [NotMapped]
        public string? NameWithIcon
        {
            get
            {
                return this.Icon + " " + this.Name;
            }
        }

    }
}
