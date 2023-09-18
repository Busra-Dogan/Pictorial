using Pictorial.Business.Abstract;
using Pictorial.Business.Constants;
using Pictorial.Core.Results;
using Pictorial.DataAccess.Abstract;
using Pictorial.DataAccess.Concrete;
using Pictorial.Entities.Concrete;
using Pictorial.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Concrete
{
    public class WordManager:IWordService
    {
        IWord _word;
        public WordManager(IWord word )
        {
            _word = word;
        }

        public IResult Add(Word word)
        {
            if (word != null)
            {
                _word.Add(word);
                return new SuccessResult(Messages.WordAdded);
            }
            else
            {
                return new ErrorResult(ErrorMessages.WordCanNotAdded);
            }
        }

        public IDataResult<List<CourseWords>> GetAllByCourseId(int id)
        {
            List<CourseWords> words =  _word.GetAllByCourseId(id);
            if (words != null && words.Count > 0)
            {
                return new SuccessDataResult<List<CourseWords>>(words, Messages.WordsListed);
            }
            else
            {
                return new ErrorDataResult<List<CourseWords>>(words, ErrorMessages.NoWord);
            }
        }

        public IResult Update(Word word)
        {
            if (word != null)
            {
                _word.Update(word);
                return new SuccessResult(Messages.WordUpdated);
            }
            else
            {
                return new ErrorResult(ErrorMessages.WordCanNotUpdated);
            }
        }

        public IResult Delete(Word word)
        {
            if (word != null)
            {
                _word.Delete(word);
                return new SuccessResult(Messages.WordDeleted);
            }
            else
            {
                return new ErrorResult(ErrorMessages.WordCanNotDeleted);
            }
        }
    }
}
