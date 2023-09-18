using Pictorial.Core.Results;
using Pictorial.Entities.Concrete;
using Pictorial.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Abstract
{
    public interface IWordService
    {
        IDataResult<List<CourseWords>> GetAllByCourseId(int id);
        IResult Add(Word word);
        IResult Update(Word word);
        IResult Delete(Word word);
    }
}
