using System.Data;
using Microsoft.Data.SqlClient;


namespace SiteManagementApi.Business.Interfaces
{
    public interface IForaDb : IDisposable,IDataRecord,IDataReader
    {
        IDataRecord ExecuteReader(ISpCall sp);
    }
}
