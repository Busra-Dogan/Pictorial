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
    public class AuthorityManager : IAuthorityService
    {
        IAuthority _authority;
        public AuthorityManager(IAuthority authority)
        {
            _authority = authority;
        }

        public IResult Add(Authority authority)
        {
            if (authority.AuthorityCode.Length > 4)
            {
                return new ErrorResult(ErrorMessages.AuthorityCodeLength);
            }
            else if (authority.AuthorityName.Length > 4)
            {

            }
            _authority.Add(authority);
            return new SuccessResult(Messages.AuthorityAdded);
        }

        public IResult Delete(Authority authority)
        {
            if (!String.IsNullOrEmpty(authority?.AuthorityCode))
            {
                _authority.Delete(authority);
                return new SuccessResult(Messages.AuthorityDeleted);
            }
            else
            {
                return new ErrorResult(ErrorMessages.AuthorityNotNull);
            }
        }

        public IDataResult<List<Authority>> GetAll()
        {
            List<Authority> authorities = _authority.GetAll();

            if (authorities != null && authorities.Count != 0)
            {
                return new SuccessDataResult<List<Authority>>(authorities, Messages.AuthoritiesListed);
            }
            else
            {
                return new ErrorDataResult<List<Authority>>(authorities, Messages.NoAuthority);
            }
        }
    }
}
