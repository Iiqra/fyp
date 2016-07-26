using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ServiceLayer
{
    public interface IQuertPanelService
    {
        IEnumerable<QueryPanel> GetAllRecords();
    }
}
//