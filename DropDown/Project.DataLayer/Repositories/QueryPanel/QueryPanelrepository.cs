using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using Bootstrap_Libraries.Models;

namespace Project.DataLayer.Repositories
{
    public class QueryPanelrepository : IQueryPanelRepository
    {

        private IPlayerDb _database;
        public IEnumerable<QueryPanel> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Create(QueryPanel entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public QueryPanel FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QueryPanel> GetAllRecords()
        {
            this._database = new PlayerDb();
            return _database.GetAll("getBattingPlayersOA").ToList<QueryPanel>();
        }

        public BowlingRecords GetRecordsById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(QueryPanel entity)
        {
            throw new NotImplementedException();
        }

        QueryPanel IQueryPanelRepository.GetRecordsById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
