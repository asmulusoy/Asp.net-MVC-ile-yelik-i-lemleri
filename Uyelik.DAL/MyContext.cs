using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyelik.Entity.Entities;
using Uyelik.Entity.IdentityModels;

namespace Uyelik.DAL
{
    public class MyContext:IdentityDbContext<ApplicationUser> //burada DbContext yerine Identitydb contextten kalıtım alıyoruz.Kullanıcı tablolarının oluşması için.
    {
        public MyContext():base("name=MyCon")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }


    }
}
