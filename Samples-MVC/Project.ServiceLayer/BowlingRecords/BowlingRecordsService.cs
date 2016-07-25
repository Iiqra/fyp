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
    public class BowlingRecordsService : IBowlingRecordsService
    {
        private IBowlingRecordsRepository bowlingRecordsRepository;

        public BowlingRecordsService()
        {

        }

        //public BattingRecordsService(IBattingRecordsRepository battingRecordsRepository)
        //{
        //    this.battingRecordsRepository = battingRecordsRepository;
        //}
        public IEnumerable<BowlingRecords> GetAllBowlingRecords()
        {
            this.bowlingRecordsRepository = new BowlingRecordsrepository();
            return bowlingRecordsRepository.GetAllBowlingRecords();
        }
    }
}
