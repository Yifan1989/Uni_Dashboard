using System;
using System.ComponentModel.DataAnnotations;

namespace Uni_Dash.Models
{
    public class Login
    {
        [Key]
        public string user { get; set; }
        public string passwd { get; set; }
        public Login()
        {
        }
    }
}
