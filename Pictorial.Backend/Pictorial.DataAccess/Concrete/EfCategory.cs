using Pictorial.Core.DataAccess;
using Pictorial.DataAccess.Abstract;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.DataAccess.Concrete
{
    public class EfCategory : EfEntityRepositoryBase<Category, PictorialDbContext>, ICategory
    {
    }
}
