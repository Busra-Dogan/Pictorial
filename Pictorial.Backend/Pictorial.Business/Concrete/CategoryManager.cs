using Pictorial.Business.Abstract;
using Pictorial.Business.Constants;
using Pictorial.Core.Results;
using Pictorial.DataAccess.Abstract;
using Pictorial.DataAccess.Concrete;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategory _category;

        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public IResult Add(Category category)
        {
            if (category != null && category.CategoryName.Length < 1)
            {
                _category.Add(category);
                return new SuccessResult(Messages.CategoryAdded);
            }
            else
            {
                return new ErrorResult(ErrorMessages.CategoryCanNotAdd);
            }

        }

        public IResult Delete(Category category)
        {
            if (category != null)
            {
                _category.Delete(category);
                return new SuccessResult(Messages.CategoryDeleted);
            }
            else
            {
                return new ErrorResult(ErrorMessages.CategoryCanNotDelete);
            }

        }

        public IDataResult<List<Category>> GetAll()
        {
            List<Category> categories = _category.GetAll();
            if (categories != null && categories.Count != 0)
            {
                return new SuccessDataResult<List<Category>>(categories, Messages.CategoriesListed);
            }
            else
            {
                return new ErrorDataResult<List<Category>>(categories, ErrorMessages.NoCategory);
            }
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            Category category = _category.Get(c => c.Id == categoryId);
            if (category != null)
            {
                return new SuccessDataResult<Category>(category, Messages.CategoriesListed);
            }
            else
            {
                return new ErrorDataResult<Category>(category, ErrorMessages.CategoryNotFind);
            }
        }

        public IResult Update(Category category)
        {
            if (category != null )
            {
                _category.Update(category);
                return new SuccessResult(Messages.CategoryUpdated);
            }
            else
            {
                return new ErrorResult(ErrorMessages.CategoryCanNotUpdate);
            }
        }
    }
}
