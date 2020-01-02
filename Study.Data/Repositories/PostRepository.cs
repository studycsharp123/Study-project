using Study.Data.Infrastructure;
using Study.Model.Models;

namespace Study.Data.Repositories
{
    public interface IPostRepository
    {
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}