using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;

namespace Project.DataLayer.Repositories
{
    public class BowlingRecordsrepository : IBowlingRecordsRepository
    {
        public IEnumerable<BowlingRecords> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Create(BowlingRecords entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BowlingRecords FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BowlingRecords> GetAllBattingRecords()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BowlingRecords> GetAllBowlingRecords()
        {
            throw new NotImplementedException();
        }

        public BowlingRecords GetBowlingRecordByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public int Update(BowlingRecords entity)
        {
            throw new NotImplementedException();
        }
    }
}
