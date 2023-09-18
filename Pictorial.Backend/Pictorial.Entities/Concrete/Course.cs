using Pictorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Entities.Concrete
{
    public class Course : IEntity
    {
		public int Id { get; set; }
		public string CourseName { get; set; }
		public int CategoryId { get; set; }
		public int LearnLanguageId { get; set; }
		public int TeachLanguageId { get; set; }
		public string Description { get; set; }
		public int CreatedMemberId { get; set; }
		public DateTime InsertDate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
