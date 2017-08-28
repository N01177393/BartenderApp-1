using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BartenderApp.Models
{
    public class Drink
    {
        //Properties of a drink
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public string DrinkDescription { get; set; }
        public int DrinkPrice { get; set; }
    }
}