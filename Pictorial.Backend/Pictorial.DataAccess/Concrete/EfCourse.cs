using Pictorial.Core.DataAccess;
using Pictorial.DataAccess.Abstract;
using Pictorial.Entities.Concrete;
using Pictorial.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.DataAccess.Concrete
{
    public class EfCourse : EfEntityRepositoryBase<Course, PictorialDbContext>, ICourse
    {
        public List<CourseCategoryDto> GetAllByCategoryId(int id)
        {
            using (PictorialDbContext context = new PictorialDbContext())
            {
                var result = from c in context.COURSE
                             join c2 in context.CATEGORY on c.CategoryId equals c2.Id
                             join c3 in context.LANGUAGE on c.LearnLanguageId equals c3.Id
                             join c4 in context.MEMBER on c.CreatedMemberId equals c4.Id
                             select new CourseCategoryDto
                             {
                                 CourseId = c.Id,
                                 CourseName = c.CourseName,
                                 CategoryName = c2.CategoryName,
                                 LearnLanguageName = c3.LanguageName,
                                 Description = c.Description,
                                 CreatedMemberName = c4.MemberName
                             };
                return result.ToList();
            }
        }

        public List<Course> GetAllByName(string name)
        {
            return new List<Course>();
        }

        public Course GetCourseDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
