using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
namespace ChartLibrary
{
    public class PlayerDAL
    {
        Database objDB;
        string ConnectionString;


        public List<T> ConvertTo<T>(DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }
        }
        public T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        value = row[columnname].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                            }
                            else
                            {
                                value = row[columnname].ToString();
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                            }
                        }
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                return obj;
            }
        }
        public PlayerDAL()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["PlayerConnectionString"].ToString();
        }
        public List<Players> GetPlayerDetails()
        {
            List<Players> objPlayers = null;
            objDB = new SqlDatabase(ConnectionString);
            using (DbCommand objcmd = objDB.GetStoredProcCommand("SC_GetPlayers"))
            {
                try
                {
                    using (DataTable dataTable = objDB.ExecuteDataSet(objcmd).Tables[0])
                    {
                        objPlayers = ConvertTo<Players>(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    return null;
                }
            }
            return objPlayers;
        }

        public List<Players> GetPlayerRecordByPlayerId(Int16? playerId)
        {
            List<Players> objPlayerRecords = null;
            objDB = new SqlDatabase(ConnectionString);
            using (DbCommand objcmd = objDB.GetStoredProcCommand("SC_GetPlayerRecordsBtPlayerId"))
            {
                objDB.AddInParameter(objcmd, "@PlayerId", DbType.Int16, playerId);
                try
                {
                    using (DataTable dataTable = objDB.ExecuteDataSet(objcmd).Tables[0])
                    {
                        objPlayerRecords = ConvertTo<Players>(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    return null;
                }
            }
            return objPlayerRecords;
        }
    } }
