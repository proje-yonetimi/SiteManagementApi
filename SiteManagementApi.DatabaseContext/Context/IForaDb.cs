using SiteManagementApi.Business.Interfaces;
using System.Data;

namespace SiteManagementApi.Data.Context
{
    public interface IForaDb : IDisposable, IDataRecord, IDataReader
    {
        IDataReader ExecuteReader(ISpCall sp);
    }
}
