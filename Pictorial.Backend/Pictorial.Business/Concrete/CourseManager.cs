using Pictorial.Business.Abstract;
using Pictorial.Business.Constants;
using Pictorial.Core.Results;
using Pictorial.DataAccess.Abstract;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Concrete
{
    public class CourseManager:ICourseService
    {
        ICourse _course;
        public CourseManager(ICourse course)
        {
            _course = course;
        }

        public IResult Add(Course course)
        {
            if (course != null)
            {
                _course.Add(course);
                return new SuccessResult(Messages.CourseAdded);
            }
            else
            {
                return new ErrorResult(ErrorMessages.CourseCanNotAdded);
            }

        }

        public IResult Delete(Course course)
        {
            if (course != null)
            {
                _course.Delete(course);
                return new SuccessResult(Messages.CourseDeleted);
            }
            else
            {
                return new ErrorResult(ErrorMessages.CourseCanNotDeleted);
            }
        }

        public IDataResult<List<Course>> GetAll()
        {
            List<Course> courses = _course.GetAll();
            if (courses != null && courses.Count != 0)
            {
                return new SuccessDataResult<List<Course>>(courses, Messages.CoursesListed);
            }
            else
            {
                return new ErrorDataResult<List<Course>>(courses, ErrorMessages.NoCourse);
            }
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int id)
        {
            List<Course> coursesByCategory = _course.GetAll(c => c.CategoryId == id);
            if (coursesByCategory != null && coursesByCategory.Count > 0)
            {
                return new SuccessDataResult<List<Course>>(coursesByCategory, Messages.CoursesGetByCategoryId);
            }
            else
            {
                return new ErrorDataResult<List<Course>>(coursesByCategory, ErrorMessages.NoCourse);
            }

        }

        public IDataResult<List<Course>> GetAllByLanguageId(int id)
        {
            List<Course> coursesByLanguage = _course.GetAll(c => c.LearnLanguageId == id);
            if (coursesByLanguage != null && coursesByLanguage.Count > 0)
            {
                return new SuccessDataResult<List<Course>>(coursesByLanguage, Messages.CoursesGetByLanguageId);
            }
            else
            {
                return new ErrorDataResult<List<Course>>(coursesByLanguage, ErrorMessages.NoCourse);
            }
           
        }

        public IDataResult<List<Course>> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Course> GetById(int courseId)
        {
            Course course = _course.Get(c => c.Id == courseId);
            if (course == null)
            {
                return new SuccessDataResult<Course>(course, Messages.CourseGetById);
            }
            else
            {
                return new ErrorDataResult<Course>(course, ErrorMessages.CourseGetNotById);
            }
            
        }

        public IDataResult<Course> GetCourseDetails(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Course>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Course>(_course.GetCourseDetails(id));
        }

        public IResult Update(Course course)
        {
            if (course != null)
            {
                _course.Update(course);
                return new SuccessResult(Messages.CourseUpdated);
            }
            else
            {
                return new ErrorResult(ErrorMessages.CourseCanNotUpdated);
            }
        }
    }
}
