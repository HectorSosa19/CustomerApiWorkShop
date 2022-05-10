﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkShopApi.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    } 
    public class Jwt
    {
        public string key { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public string Subject { get; set; }
    }
}
