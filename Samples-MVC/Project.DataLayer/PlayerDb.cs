using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Project.DataLayer;

namespace Bootstrap_Libraries.Models
{
    public class PlayerDb : IPlayerDb
    {
        #region Data members Declaration
        private readonly string _connectionString;
        private readonly SqlConnection _connection;
        private readonly SqlCommand _command;
        private readonly SqlDataAdapter _adapter;
        private DataTable _datatable;
        private int _status;
        #endregion

        public PlayerDb()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PlayersDb"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;
            _adapter = new SqlDataAdapter(_command);
        }

        public int Create(String storedProcedure, Dictionary<string, string> parameters)
        {
            try
            {
                AddParameters(parameters);
                return Execute(storedProcedure, parameters);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public int Update(String storedProcedure, Dictionary<string, string> parameters)
        {
            try
            {
                AddParameters(parameters);
                return Execute(storedProcedure, parameters);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Responsible for Insert and Update operations
        /// </summary>
        /// <returns>returns no. of records inserted or updated</returns>
        /// 
        private int Execute(String storedProcedure, Dictionary<string, string> parameters)
        {
            try
            {
                _command.CommandText = storedProcedure;
                OpenConnection();
                _status = _command.ExecuteNonQuery();
                _connection.Close();
                return _status;//num of records inserted // ths no of rcds can be multiple .(trigger *)
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public int Delete(string storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                if (_command.Parameters.Count > 0)
                    _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@id", id);
                OpenConnection();
                return _command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetAll(string storedProcedure)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _datatable = new DataTable();
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetById(string storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@id", id);
                _datatable = new DataTable();
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public string Getsinglecolumn(String storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _command.Parameters.Clear();
                _command.Parameters.AddWithValue("@id", id);
                _connection.Open();
                string var = _command.ExecuteScalar().ToString();
                return var;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        public DataTable GetOne(String storedProcedure, int id)
        {
            try
            {
                _command.CommandText = storedProcedure;
                _command.Parameters.Clear();
                _datatable = new DataTable();
                _command.Parameters.AddWithValue("@Id", id);
                _adapter.Fill(_datatable);
                return _datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void AddParameters(Dictionary<String, string> parameters)
        {
            if (_command.Parameters.Count > 0)
                _command.Parameters.Clear();
            foreach (KeyValuePair<string, string> parameter in parameters)
            {
                _command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
            }
        }
        private void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }
    }
}