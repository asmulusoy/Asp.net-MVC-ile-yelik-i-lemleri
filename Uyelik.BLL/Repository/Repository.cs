using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyelik.Entity.Entities;

namespace Uyelik.BLL.Repository
{
    class Repository
    {
        public class MessageRepo : RepositoryBase<Message , long> { }
    }
}
