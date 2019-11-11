using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using dotnetangular.Enum;

namespace dotnetangular.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public dotnetangular.Enum.RommStatus Status { get; set; }

        public bool AllowedSmoking { get; set; }

        public Room()
        {

        }
        public Room(int number, string name, dotnetangular.Enum.RommStatus status, bool allowedSmoking)
        {
            Number = number;
            Name = name;
            Status = status;
            AllowedSmoking = allowedSmoking;
        }
    }
}
