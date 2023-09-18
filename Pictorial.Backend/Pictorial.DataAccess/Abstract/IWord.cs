using Pictorial.Core.DataAccess;
using Pictorial.Entities.Concrete;
using Pictorial.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.DataAccess.Abstract
{
    public interface IWord : IEntityRepository<Word>
    {
        List<CourseWords> GetAllByCourseId(int id);
    }
}
