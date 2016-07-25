using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataLayer
{
    public interface IPlayerDb
    {
        int Create(string storedProcedure, Dictionary<string, string> parameters);
        int Update(string storedProcedure, Dictionary<string, string> parameters);
        int Delete(string storedProcedure, int id);
        DataTable GetAll(string storedProcedure);
        DataTable GetOne(string storedProcedure, int id);
        string Getsinglecolumn(string p, int userId);
    }
}
