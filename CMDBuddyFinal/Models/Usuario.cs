using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMDBuddyFinal.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Display(Name = "Usuário")]
        public string Username { get; set; }
        [Display(Name = "Senha")]
        public string Userpass { get; set; }
    }
}