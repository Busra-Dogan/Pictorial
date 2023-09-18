using Pictorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Entities.Dtos
{
    public class CourseCategoryDto:IDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set;}
        public string CategoryName { get; set;}
        public string LearnLanguageName{ get; set; }
        public string TeachLanguageName { get; set; }
        public string Description { get; set; }
        public string CreatedMemberName { get; set; }
    }
}
