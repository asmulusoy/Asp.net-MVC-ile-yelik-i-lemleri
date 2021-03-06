﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Uyelik.Entity.Entities;

namespace Uyelik.Entity.IdentityModels
{
    public class ApplicationUser:IdentityUser//Burda username password filan var burdan kalitim alıyorum.
    {
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Surname { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public virtual List<Message> Messages { get; set; } = new List<Message>();
    }
}
