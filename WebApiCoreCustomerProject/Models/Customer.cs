using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreCustomerProject.Models {

    public class Customer {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public double Sales { get; set; }
        public bool Active { get; set; }

        public Customer() {}
    }
}
