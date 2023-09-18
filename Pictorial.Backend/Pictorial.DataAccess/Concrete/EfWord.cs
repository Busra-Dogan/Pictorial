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
    public class EfWord : EfEntityRepositoryBase<Word, PictorialDbContext>, IWord
    {
        public List<CourseWords> GetAllByCourseId(int id)
        {
            using (PictorialDbContext context = new PictorialDbContext())
            {
                var result = from c in context.COURSE
                             join c2 in context.WORD on c.Id equals c2.CourseId
                             select new CourseWords
                             {
                                 TeachWord = c2.MainWord,
                                 MeanofWord = c2.MeanOfWord
                             };
                return result.ToList();
            }
        }
    }
}
