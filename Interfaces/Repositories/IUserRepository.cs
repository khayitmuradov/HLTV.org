using HLTV.org.Interfaces.Common;
using HLTV.org.Models;

namespace HLTV.org.Interfaces.Repositories
{
    public interface IUserRepository :
        ICreateable<User>, IReadable<User>,
        IUpdateAble<User>, IDeleteable<User>
    {
    }
}
