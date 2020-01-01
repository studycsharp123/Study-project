    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Data.Infrastructure
{
    //su dung de khoi tao cac doi tuong entity
    //khong khoi tao truc tiep ma thong qua Factory
    public interface IDbFactory : IDisposable
    {
        StudyDbContext Init();
    }
}
