﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRestaurantMenu.Infrastructure.Data.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [Required]
        public string UserId { get; set; }
        public List<Drink> Drinks { get; set; } = new List<Drink>();    
        public List<Foods> Foods { get; set; } = new List<Foods>();
        public bool IsPay { get; set; }
        public bool CallToWaiter { get; set; }
      
    }
}