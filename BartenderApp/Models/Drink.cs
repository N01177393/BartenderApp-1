using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace BartenderApp.Models
{
    public class Drink
    {
        //Properties of a drink
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrinkID { get; set; }
        [Display(Name = "Poison")]
        public string DrinkName { get; set; }
        [Display(Name = "Oh I Like This...")]
        public string DrinkDescription { get; set; }
        [Display(Name = "Pay What?")]
        public int DrinkPrice { get; set; }
    }
}