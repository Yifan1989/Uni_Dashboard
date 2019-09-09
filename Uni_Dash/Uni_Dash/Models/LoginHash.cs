using System;
using System.ComponentModel.DataAnnotations;

namespace Uni_Dash.Models
{
    public class LoginHash
    {
        [Key]
        public string user { get; set; }
        public string pwd { get; set; }
        public string hashPwd { get; set; }
        public string role { get; set; }
        public LoginHash()
        {
        }
    }
}