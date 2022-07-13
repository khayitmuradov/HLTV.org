using HLTV.org.Interfaces.Common;
using HLTV.org.Models;

namespace HLTV.org.Interfaces.Repositories
{
    public interface IPostRepository :
        ICreateable<Post>, IReadable<Post>,
        IUpdateAble<Post>, IDeleteable<Post>
    {

    }
}
