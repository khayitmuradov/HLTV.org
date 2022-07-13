using HLTV.org.Interfaces.Common;
using HLTV.org.Models;

namespace HLTV.org.Interfaces.Repositories
{
    public interface IMatchRepository :
        ICreateable<Match>, IReadable<Match>,
        IUpdateAble<Match>, IDeleteable<Match>
    {
    }
}
