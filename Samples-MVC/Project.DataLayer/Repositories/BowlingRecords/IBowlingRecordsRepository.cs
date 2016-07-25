using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.DataLayer.Repositories
{
    public interface IBowlingRecordsRepository : IRepository<Project.Model.BowlingRecords>
    {
        IEnumerable<Project.Model.BowlingRecords> GetAllBowlingRecords();
        Project.Model.BowlingRecords GetBowlingRecordByCountry(string country);
    }
}
