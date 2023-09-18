using Pictorial.Core.Results;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Business.Abstract
{
    public interface IMemberService
    {
        IDataResult<List<Member>> GetAll();
        IResult Add(Member member);
        IResult Delete(Member member);
        IResult Update(Member member);
    }
}
