using HLTV.org.Interfaces.Common;
using HLTV.org.Models;

namespace HLTV.org.Interfaces.Repositories
{
    public interface IPlayerRepository :
        ICreateable<Player>, IReadable<Player>,
        IUpdateAble<Player>, IDeleteable<Player>
    {

    }
}
