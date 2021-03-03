using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUsersDal:IEntityRepository<User>
    {
        List<OperationClaim>GetClaims(User user);
    }
}
