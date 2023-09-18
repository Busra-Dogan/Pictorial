using Pictorial.Core.Results;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByLanguageId(int id);
        IDataResult<List<Course>> GetAllByCategoryId(int id);
        IDataResult<List<Course>> GetAllByName(string name);
        IDataResult<Course> GetCourseDetails(int id);
        IDataResult<Course> GetById(int courseId);
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
    }
}
