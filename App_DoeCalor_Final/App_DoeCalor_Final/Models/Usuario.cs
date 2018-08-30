using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_DoeCalor_Final.Models
{
   public class  Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UrlPhoto { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsLogged { get; set; }

   
    }
}
