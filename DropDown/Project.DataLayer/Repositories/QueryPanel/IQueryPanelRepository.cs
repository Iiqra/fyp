using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.DataLayer.Repositories
{
    public interface IQueryPanelRepository : IRepository<Project.Model.QueryPanel>
    {
        IEnumerable<Project.Model.QueryPanel> GetAllRecords();
        Project.Model.QueryPanel GetRecordsById(int Id);
    }
}
