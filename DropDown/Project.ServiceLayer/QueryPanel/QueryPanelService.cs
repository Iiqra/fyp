using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataLayer.Repositories;
using Microsoft.Practices.Unity;

namespace Project.ServiceLayer
{
    public class QueryPanelService : IQuertPanelService
    {
         private IQueryPanelRepository queryPanelRepository;

        public QueryPanelService()
        {

        }

        //public BattingRecordsService(IBattingRecordsRepository battingRecordsRepository)
        //{
        //    this.battingRecordsRepository = battingRecordsRepository;
        //}


        public IEnumerable<QueryPanel> GetAllRecords()
        {
            this.queryPanelRepository = new QueryPanelrepository();
            return queryPanelRepository.GetAllRecords();
        }
    }
}
