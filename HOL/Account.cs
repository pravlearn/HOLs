using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HOL4.Models
{
    public class Account
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int AccountNumber { get; set; }

        public string Name { get; set; }

        public double CurrentBalance { get; set; }
    }
}