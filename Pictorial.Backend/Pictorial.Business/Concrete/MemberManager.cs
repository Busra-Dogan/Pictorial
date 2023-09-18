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
    public class MemberManager : IMemberService
    {
        IMember _member;
        public MemberManager(IMember member)
        {
            _member = member;
        }
        public IResult Add(Member member)
        {
            if (member != null)
            {
                //buraya authortiy codunu ekle. Normal üye için default yetki kodu ver
                _member.Add(member);
                return new SuccessResult(Messages.MemberAdded);
            }
            else
            {
                return new ErrorResult(ErrorMessages.MemberCanNotAdded);
            }
        }

        public IResult Delete(Member member)
        {
            if (member != null)
            {
                _member.Delete(member);
                return new SuccessResult(Messages.MemberDeleted);
            }
            else
            {
                return new ErrorResult(ErrorMessages.MemberCanNotDeleted);
            }
        }

        public IDataResult<List<Member>> GetAll()
        {
            List<Member> members = _member.GetAll();
            if (members != null && members.Count != 0)
            {
                return new SuccessDataResult<List<Member>>(members, Messages.MembersListed);             
            }
            else
            {
                return new ErrorDataResult<List<Member>>(members, Messages.NoMember);
            }
        }

        public IResult Update(Member member)
        {
            if (member != null)
            {
                _member.Update(member);
                return new SuccessResult(Messages.MemberUpdated);
            }
            else
            {
                return new ErrorResult(ErrorMessages.MemberCanNotUpdated);
            }
        }
    }
}
