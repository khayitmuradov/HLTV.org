using HLTV.org.Interfaces.Common;
using HLTV.org.Models;

namespace HLTV.org.Interfaces.Repositories
{
    public interface ICoachRepository :
        ICreateable<Coach>, IReadable<Coach>,
        IUpdateAble<Coach>, IDeleteable<Coach>
    {

    }
}
