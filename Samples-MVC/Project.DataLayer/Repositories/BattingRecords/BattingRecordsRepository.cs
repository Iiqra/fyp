using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using Microsoft.Practices.Unity;
using Bootstrap_Libraries.Models;

namespace Project.DataLayer.Repositories
{
    public class BattingRecordsRepository : IBattingRecordsRepository
    {
        private IPlayerDb database;

        public BattingRecordsRepository()
        {

        }

        public BattingRecordsRepository(IPlayerDb database)
        {
            this.database = database;
        }

        public IEnumerable<BattingRecords> List
        {
            get
            {
                this.database = new PlayerDb();
                return database.GetAll("GetAllBattingRecords").ToList<BattingRecords>();
            }
        }

        public int Create(BattingRecords entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BattingRecords FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BattingRecords> GetAllBattingRecords()
        {
            this.database = new PlayerDb();
            return database.GetAll("GetAllBattingRecords").ToList<BattingRecords>();
        }

        public BattingRecords GetBattingRecordByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public int Update(BattingRecords entity)
        {
            throw new NotImplementedException();
        }
    }
}
