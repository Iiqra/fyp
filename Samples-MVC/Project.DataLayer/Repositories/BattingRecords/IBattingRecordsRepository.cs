using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.DataLayer.Repositories
{
    public interface IBattingRecordsRepository : IRepository<BattingRecords>
    {
        IEnumerable<BattingRecords> GetAllBattingRecords();
        BattingRecords GetBattingRecordByCountry(string country);
    }
}
