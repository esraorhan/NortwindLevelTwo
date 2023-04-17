using Core_FrameworkLayer_.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //bu kısımdan sonra Concrete klasöründe ef klosürününün içindeki implemente edip kodlamamız gerekecek.
    }
}
