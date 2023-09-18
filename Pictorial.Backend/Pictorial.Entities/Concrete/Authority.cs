using Pictorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Entities.Concrete
{
    public class Authority : IEntity
    {
        #region Private Properties
        private string authorityId;
        private string authorityCode;
        private string authorityName;
        #endregion

        #region Public Properties
        public string AuthorityId
        {
            get { return authorityId; }
            set { authorityId = value; }
        }
        public string AuthorityCode
        {
            get { return authorityCode; }
            set { authorityCode = value; }
        }

        public string AuthorityName
        {
            get { return authorityName; }
            set { authorityName = value; }
        }
        #endregion Public Properties
    }
}
