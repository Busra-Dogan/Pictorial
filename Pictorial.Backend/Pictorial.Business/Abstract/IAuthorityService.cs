using Pictorial.Core.Results;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Abstract
{
    public interface IAuthorityService
    {
        IDataResult<List<Authority>> GetAll();
        IResult Add(Authority authority);
        IResult Delete(Authority category);
    }
}
