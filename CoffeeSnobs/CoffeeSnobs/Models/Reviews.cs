using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeSnobs.Models
{
    public class Reviews
    {
        [DisplayName("Review")]
        public virtual int ReviewId { get; set; }

        [DisplayName("Date Visited:")]
        [Required(ErrorMessage = "Need to specify a date.")]
        public virtual int Date { get; set; }

        [DisplayName("Coffee Snob:")]
        [DataType(DataType.EmailAddress)]
        public virtual string Email{ get; set; }

        [DisplayName("Coffee Drink:")]
        [Required(ErrorMessage = "Need to specify a coffee drink.")]
        public virtual string Drink { get; set; }

        [DisplayName("Coffee Rating:")]
        public virtual string CoffeeRating{ get; set; }

        [DisplayName("Service Rating:")]
        public virtual string ServRating { get; set; }

        [DisplayName("Would coffee snob return?")]
        [Required(ErrorMessage = "Please let the fellow coffee snobs know if you would revist this shop.")]
        public virtual string Return { get; set; }
    }
}