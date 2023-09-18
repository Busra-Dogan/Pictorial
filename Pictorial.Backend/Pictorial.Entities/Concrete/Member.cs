using Pictorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Entities.Concrete
{
    public class Member : IEntity
    {
		public int Id { get; set; }
		public string MemberName { get; set; }
		public string Email { get; set; }
		public string PasswordSalt { get; set; }
		public string PasswordHash { get; set; }
		public string Authority { get; set; }
        public DateTime InsertDate { get; set; }
		public DateTime UpdateDate { get; set; }
    }
}
