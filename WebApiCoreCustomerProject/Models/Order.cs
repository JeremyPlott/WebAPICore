using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProject.Models {

    public class Order {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [StringLength(80)]
        public string Description { get; set; }
        public double Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Order() {}
    }
}
