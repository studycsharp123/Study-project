using Study.Data.Infrastructure;

namespace Study.Data.Repositories
{
    public interface IVisistorStatisticRepository
    {
    }

    public class VisistorStatisticRepository : RepositoryBase<VisistorStatistic>, IVisistorStatisticRepository
    {
        public VisistorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}