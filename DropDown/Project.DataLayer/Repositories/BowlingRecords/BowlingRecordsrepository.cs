using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using Bootstrap_Libraries.Models;

namespace Project.DataLayer.Repositories
{
    public class BowlingRecordsrepository : IBowlingRecordsRepository
    {

        private IPlayerDb _database;
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
            this._database = new PlayerDb();
            return _database.GetAll("GetAllBattingRecords").ToList<BowlingRecords>();
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
