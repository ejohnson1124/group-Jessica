﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HouseholdManager.Models
{
    public class MessageProperty
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public TwilioUser? User { get; set; }

        public virtual IList<Send> Send { get; set; }
    }
}