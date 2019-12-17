using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesOrdersProject.Models { 
    public class BillingInfo
    {
        [Required(ErrorMessage="Billing First Name Is Mandatory")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Billing Last Name Is Mandatory")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Billing Credit Card Number Is Mandatory")]

        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Billing Address Is Mandatory")]

        public string Address { get; set; }

        [Required(ErrorMessage = "Billing City Is Mandatory")]

        public string City { get; set; }

        [Required(ErrorMessage = "Billing State Is Mandatory")]

        public string State { get; set; }

        [Required(ErrorMessage = "Billing Postal Code Is Mandatory")]

        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Billing Expire Month Is Mandatory")]

        public string ExpireMonth { get; set; }

        public SelectList Months()
        {
            return new SelectList(new string[]{
                "January", "February", "March", "April", "May", "June",
                "July", "August", "August",
                "September", "October", "November", "December"
            });
        }

        [Required(ErrorMessage = "Billing Expire Year Is Mandatory")]

        public string ExpireYear { get; set; }

        public SelectList Years()
        {
            return new SelectList(new string[]{
                "2019", "2020", "2021", "2022", "2023",
                "2024", "2025", "2026", "2027", "2028",
                "2029", "2030", "2031"
            });
        }
    }
}