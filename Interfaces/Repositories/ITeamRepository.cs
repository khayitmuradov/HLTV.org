using HLTV.org.Interfaces.Common;
using HLTV.org.Models;

namespace HLTV.org.Interfaces.Repositories
{
    public interface ITeamRepository :
        ICreateable<Team>, IReadable<Team>,
        IUpdateAble<Team>, IDeleteable<Team>
    {

    }
}
