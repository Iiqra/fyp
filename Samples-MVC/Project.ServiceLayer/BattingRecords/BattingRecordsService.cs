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
    public class BattingRecordsService : IBattingRecordsService
    {
        private IBattingRecordsRepository battingRecordsRepository;

        public BattingRecordsService()
        {

        }

        public BattingRecordsService(IBattingRecordsRepository battingRecordsRepository)
        {
            this.battingRecordsRepository = battingRecordsRepository;
        }
        public IEnumerable<BattingRecords> GetAllBattingRecords()
        {
            this.battingRecordsRepository = new BattingRecordsRepository();
            return battingRecordsRepository.GetAllBattingRecords();
        }
    }
}
