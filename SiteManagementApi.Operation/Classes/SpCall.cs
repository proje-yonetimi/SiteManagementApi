using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Operation.Interfaces;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;

namespace SiteManagementApi.Operation.Classes
{
    public class SpCall : ISpCall
    {
        static readonly int EMPTY_STRING_SIZE = 8000;
        const string NonexistentParameter = "'{0}' parametresi SP parametreleri içinde yok!";
        const string NonexistentParameterWithSpName = "'{0}' parametresi '{1}' SP parametreleri içinde yok!";
        const string ParameterAlreadyExists = "'{0}' parametresi SP parametreleri içine zaten eklenmiş!";
        const string ParameterAlreadyExistsWithSpName = "'{0}' parametresi '{1}' SP parametreleri içine zaten eklenmiş!";
        /// <summary>
        /// Paramaters
        /// </summary>
        internal Dictionary<string, SqlParameter> Parameters { get; private set; }
        /// <summary>
        /// Sp name
        /// </summary>
        public string StoredProcedureName
        {
            get { return Statement; }
            set { Statement = value; }
        }
        /// <summary>
        /// Sp name
        /// </summary>
        public string Statement { get; set; }
        public CommandType CommandType { get; set; }
        /// <summary>
        /// Empty instance. Sp name should set after
        /// </summary>
        public SpCall()
        {
            Parameters = new Dictionary<string, SqlParameter>();
            CommandType = CommandType.StoredProcedure;
        }
        public SpCall(string statement) : this() { Statement = statement; }
        public SpCall(string statement, CommandType commandType) : this() { Statement = statement; CommandType = commandType; }
        public Dictionary<string, SqlParameter> GetParameters() { return Parameters; }
        public void SetParameter(string name, SqlDbType sqlDbType, ParameterDirection direction, object value)
        {
            if (Parameters.ContainsKey(name))
            {
                string msg;
                if (string.IsNullOrEmpty(Statement))
                {
                    msg = string.Format(ParameterAlreadyExists, name);
                }
                else
                {
                    msg = string.Format(ParameterAlreadyExistsWithSpName, name, Statement);
                }
                throw new ArgumentException(msg);
            }
            SqlParameter sp = new SqlParameter(name, value);
            sp.SqlDbType = sqlDbType;
            sp.Value = value ?? DBNull.Value;
            sp.Direction = direction;

            Parameters.Add(name, sp);
        }
        public void SetParameter(string name, SqlDbType sqlDbType, ParameterDirection direction, object value, string typeName)
        {
            if (Parameters.ContainsKey(name))
            {
                string msg;
                if (string.IsNullOrEmpty(Statement))
                {
                    msg = string.Format(ParameterAlreadyExists, name);
                }
                else
                {
                    msg = string.Format(ParameterAlreadyExistsWithSpName, name, Statement);
                }
                throw new ArgumentException(msg);
            }
            SqlParameter sp = new SqlParameter(name, value);
            sp.SqlDbType = sqlDbType;
            sp.Value = value ?? DBNull.Value;
            sp.Direction = direction;

            if (!string.IsNullOrEmpty(typeName))
            {
                sp.TypeName = typeName;
            }

            Parameters.Add(name, sp);
        }
        public SqlParameter this[string name]
        {
            get
            {
                SqlParameter parameter;
                if (Parameters.TryGetValue(name, out parameter)) { return parameter; }
                string msg;
                if (string.IsNullOrEmpty(Statement))
                {
                    msg = string.Format(NonexistentParameter, name);
                }
                else
                {
                    msg = string.Format(NonexistentParameterWithSpName, name, Statement);
                }
                throw new ArgumentException(msg);
            }
        }

        public void SetBool(string name, bool? value)
        {
            SetParameter(name, SqlDbType.Bit, ParameterDirection.Input, value, string.Empty);
        }

        public void SetBool(string name, bool? value, bool defaultValue)
        {
            SetParameter(name, SqlDbType.Bit, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetBoolInputOutput(string name, bool? value)
        {
            SetParameter(name, SqlDbType.Bit, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetBoolInputOutput(string name, bool? value, bool defaultValue)
        {
            SetParameter(name, SqlDbType.Bit, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetBoolOutput(string name)
        {
            SetParameter(name, SqlDbType.Bit, ParameterDirection.Output, null, string.Empty);
        }

        public void SetByte(string name, byte? value)
        {
            SetParameter(name, SqlDbType.TinyInt, ParameterDirection.Input, value, string.Empty);
        }

        public void SetByte(string name, byte? value, byte defaultValue)
        {
            SetParameter(name, SqlDbType.TinyInt, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetByteInputOutput(string name, byte? value)
        {
            SetParameter(name, SqlDbType.TinyInt, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetByteInputOutput(string name, byte? value, byte defaultValue)
        {
            SetParameter(name, SqlDbType.TinyInt, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetByteOutput(string name)
        {
            SetParameter(name, SqlDbType.TinyInt, ParameterDirection.Output, null, string.Empty);
        }

        public void SetChar(string name, char? value)
        {
            SetParameter(name, SqlDbType.Char, ParameterDirection.Input, value, string.Empty);
        }

        public void SetChar(string name, char? value, char defaultValue)
        {
            SetParameter(name, SqlDbType.Char, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetCharInputOutput(string name, char? value)
        {
            SetParameter(name, SqlDbType.Char, ParameterDirection.InputOutput, value, string.Empty);
            Parameters[name].Size = 1;
        }

        public void SetCharInputOutput(string name, char? value, char defaultValue)
        {
            SetParameter(name, SqlDbType.Char, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
            Parameters[name].Size = 1;
        }

        public void SetCharOutput(string name)
        {
            SetParameter(name, SqlDbType.Char, ParameterDirection.Output, null, string.Empty);
            Parameters[name].Size = 1;
        }

        public void SetDateTime(string name, DateTime? value)
        {
            SetParameter(name, SqlDbType.DateTime, ParameterDirection.Input, value, string.Empty);
        }

        public void SetDateTime(string name, DateTime? value, DateTime defaultValue)
        {
            SetParameter(name, SqlDbType.DateTime, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetDateTimeInputOutput(string name, DateTime? value)
        {
            SetParameter(name, SqlDbType.DateTime, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetDateTimeInputOutput(string name, DateTime? value, DateTime defaultValue)
        {
            SetParameter(name, SqlDbType.DateTime, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetDateTimeOutput(string name)
        {
            SetParameter(name, SqlDbType.DateTime, ParameterDirection.Output, null, string.Empty);
        }

        public void SetDecimal(string name, decimal? value)
        {
            SetParameter(name, SqlDbType.Decimal, ParameterDirection.Input, value, string.Empty);
        }

        public void SetDecimal(string name, decimal? value, byte precision, byte scale)
        {
            SetParameter(name, SqlDbType.Decimal, ParameterDirection.Input, value, string.Empty);
            Parameters[name].Precision = precision;
            Parameters[name].Scale = scale;
        }

        public void SetDecimal(string name, decimal? value, decimal defaultValue)
        {
            SetParameter(name, SqlDbType.Decimal, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetDecimalInputOutput(string name, decimal? value, byte precision, byte scale)
        {
            SetParameter(name, SqlDbType.Decimal, ParameterDirection.InputOutput, value, string.Empty);
            Parameters[name].Precision = precision;
            Parameters[name].Scale = scale;
        }

        public void SetDecimalInputOutput(string name, decimal? value, byte precision, byte scale, decimal defaultValue)
        {
            SetParameter(name, SqlDbType.Decimal, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
            Parameters[name].Precision = precision;
            Parameters[name].Scale = scale;
        }

        public void SetDecimalOutput(string name, byte precision, byte scale)
        {
            SetParameter(name, SqlDbType.Decimal, ParameterDirection.Output, null, string.Empty);
            Parameters[name].Precision = precision;
            Parameters[name].Scale = scale;
        }

        public void SetDouble(string name, double? value)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.Input, value, string.Empty);
        }

        public void SetDouble(string name, double? value, double defaultValue)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetDoubleInputOutput(string name, double? value)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetDoubleInputOutput(string name, double? value, double defaultValue)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetDoubleOutput(string name)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.Output, null, string.Empty);
        }

        public void SetFloat(string name, float? value)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.Input, value, string.Empty);
        }

        public void SetFloat(string name, float? value, float defaultValue)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetFloatInputOutput(string name, float? value)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetFloatInputOutput(string name, float? value, float defaultValue)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetFloatOutput(string name)
        {
            SetParameter(name, SqlDbType.Float, ParameterDirection.Output, null, string.Empty);
        }

        public void SetGuid(string name, Guid? value)
        {
            SetParameter(name, SqlDbType.UniqueIdentifier, ParameterDirection.Input, value, string.Empty);
        }

        public void SetGuidInputOutput(string name, Guid? value)
        {
            SetParameter(name, SqlDbType.UniqueIdentifier, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetGuidOutput(string name)
        {
            SetParameter(name, SqlDbType.UniqueIdentifier, ParameterDirection.Output, null, string.Empty);
        }

        public void SetInt(string name, int? value)
        {
            SetParameter(name, SqlDbType.Int, ParameterDirection.Input, value, string.Empty);
        }

        public void SetInt(string name, int? value, int defaultValue)
        {
            SetParameter(name, SqlDbType.Int, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetIntInputOutput(string name, int? value)
        {
            SetParameter(name, SqlDbType.Int, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetIntInputOutput(string name, int? value, int defaultValue)
        {
            SetParameter(name, SqlDbType.Int, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetIntOutput(string name)
        {
            SetParameter(name, SqlDbType.Int, ParameterDirection.Output, null, string.Empty);
        }

        public void SetLong(string name, long? value)
        {
            SetParameter(name, SqlDbType.BigInt, ParameterDirection.Input, value, string.Empty);
        }

        public void SetLong(string name, long? value, long defaultValue)
        {
            SetParameter(name, SqlDbType.BigInt, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetLongInputOutput(string name, long? value)
        {
            SetParameter(name, SqlDbType.BigInt, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetLongInputOutput(string name, long? value, long defaultValue)
        {
            SetParameter(name, SqlDbType.BigInt, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetLongOutput(string name)
        {
            SetParameter(name, SqlDbType.BigInt, ParameterDirection.Output, null, string.Empty);
        }

        public void SetUSerDefinedTable(string name, DataTable dt, string typeName)
        {
            SetParameter(name, SqlDbType.Structured, ParameterDirection.Input, dt, typeName);
            if (dt!=null && dt.Rows.Count>0)
            {
                Parameters[name].Size = dt.Rows.Count;
            }
            else
            {
                Parameters[name].Size = 1;
            }
        }

        public void SetObject(string name, byte[] value)
        {
            SetParameter(name, SqlDbType.VarBinary, ParameterDirection.Input, value, string.Empty);
        }
        public void SetXml(string name, SqlXml xml)
        {
            SetParameter(name, SqlDbType.Xml, ParameterDirection.Input, xml, string.Empty);
        }

        public void SetShort(string name, short? value)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.Input, value, string.Empty);
        }

        public void SetShort(string name, short? value, short defaultValue)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.Input, value ?? defaultValue, string.Empty);
        }

        public void SetShort(string name, int? value)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.Input, (short?)value, string.Empty);
        }

        public void SetShort(string name, int? value, int defaultValue)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.Input, (short?)(value ?? defaultValue), string.Empty);
        }

        public void SetShortInputOutput(string name, short? value)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.InputOutput, value, string.Empty);
        }

        public void SetShortInputOutput(string name, short? value, short defaultValue)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
        }

        public void SetShortInputOutput(string name, int? value)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.InputOutput, (short?)value, string.Empty);
        }

        public void SetShortInputOutput(string name, int? value, int defaultValue)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.InputOutput, (short?)(value ?? defaultValue), string.Empty);
        }

        public void SetShortOutput(string name)
        {
            SetParameter(name, SqlDbType.SmallInt, ParameterDirection.Output, null, string.Empty);
        }

        public void SetString(string name, string? value)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.Input, value, string.Empty);
            if (string.IsNullOrWhiteSpace(value))
            {
                Parameters[name].Size = EMPTY_STRING_SIZE;
            }
        }

        public void SetString(string name, string? value, int size)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.Input, value, string.Empty);
            if (string.IsNullOrWhiteSpace(value))
            {
                Parameters[name].Size = EMPTY_STRING_SIZE;
            }
            else
            {
                Parameters[name].Size = size;
            }
        }

        public void SetString(string name, string? value, string defaultValue)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.Input, value ?? defaultValue, string.Empty);
            if (string.IsNullOrWhiteSpace(value))
            {
                Parameters[name].Size = EMPTY_STRING_SIZE;
            }
        }

        public void SetString(string name, string? value, string defaultValue, int size)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.Input, value ?? defaultValue, string.Empty);
            if (string.IsNullOrWhiteSpace(value))
            {
                Parameters[name].Size = EMPTY_STRING_SIZE;
            }
            else
            {
                Parameters[name].Size = size;
            }
        }

        public void SetStringInputOutput(string name, string? value, int size)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.InputOutput, value, string.Empty);
            Parameters[name].Size = size;
        }

        public void SetStringInputOutput(string name, string? value, int size, string defaultValue)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.InputOutput, value ?? defaultValue, string.Empty);
            Parameters[name].Size = size;
        }

        public void SetStringOutput(string name, int size)
        {
            SetParameter(name, SqlDbType.VarChar, ParameterDirection.Output, null, string.Empty);
            Parameters[name].Size = size;
        }

        public void SetValue(string name, object value, Type valueType)
        {
            valueType = Nullable.GetUnderlyingType(valueType) ?? valueType;

            TypeCode typeCode = Type.GetTypeCode(valueType);

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    SetBool(name, value as bool?);
                    break;
                case TypeCode.Byte:
                    SetByte(name, value as byte?);
                    break;
                case TypeCode.Char:
                    SetChar(name, value as char?);
                    break;
                case TypeCode.DateTime:
                    SetDateTime(name, value as DateTime?);
                    break;
                case TypeCode.Decimal:
                    SetDecimal(name, value as decimal?);
                    break;
                case TypeCode.Double:
                    SetDouble(name, value as double?);
                    break;
                case TypeCode.Int16:
                    SetShort(name, value as short?);
                    break;
                case TypeCode.Int32:
                    SetInt(name, value as int?);
                    break;
                case TypeCode.Int64:
                    SetLong(name, value as long?);
                    break;
                default:
                    throw new NotSupportedException("Not supported value");
            }
        }

        public override string ToString()
        {
            List<string> args = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (SqlParameter item in Parameters.Values)
            {
                args.Add(string.Format("{0}={0}", item.ParameterName));
                if (item.Value == null || item.Value == DBNull.Value)
                {
                    sb.AppendFormat("\n DECLARE {0} {1} \n", item.ParameterName, item.SqlDbType.ToString());
                }
                else
                {
                    switch (item.SqlDbType) {
                        case SqlDbType.Char:
                        case SqlDbType.NChar:
                        case SqlDbType.NText:
                        case SqlDbType.NVarChar:
                        case SqlDbType.VarChar:
                        case SqlDbType.Text:
                            sb.AppendFormat("DECLARE {0} {1}({2}) = '{3}'",
                                item.ParameterName, item.SqlDbType.ToString(),
                                item.Size >= 4000 ? "MAX" : (item.Size + 1).ToString(),
                                item.Value);
                            break;
                        case SqlDbType.DateTime:
                        case SqlDbType.SmallDateTime:
                            DateTime dateTime = (DateTime)item.Value;
                            sb.AppendFormat("\n DECLARE {0} {1} = '{2}'",
                                item.ParameterName,
                                item.SqlDbType.ToString(),
                                dateTime.ToString("yyyyMMdd"));
                            break;
                        case SqlDbType.Structured:
                            try
                            {
                                if (!string.IsNullOrWhiteSpace(item.TypeName))
                                {
                                    string userDefinedTableParamsText = "\n DECLARE "
                                        + item.ParameterName + " " + item.TypeName + " ";
                                    DataTable dtStructured = (DataTable)item.Value;
                                    foreach (var dr in dtStructured.Rows) {
                                        string parColStr = "";
                                        foreach (var parCol in ((DataRow)dr).ItemArray)
                                        {
                                            if (!string.IsNullOrWhiteSpace(parColStr))
                                            {
                                                parColStr += ",";
                                            }
                                            parColStr += "N'" + parCol.ToString() + "'";
                                        }
                                        userDefinedTableParamsText += " \n INSERT INTO " +
                                            item.ParameterName + " VALUES(" + parColStr + ")";
                                    }
                                    sb.Append(userDefinedTableParamsText);
                                }
                            }
                            catch
                            {
                                // do nothing
                            }
                            break;
                        default:
                            sb.AppendFormat("\n DECLARE {0} {1} = {2} ",
                                item.ParameterName,
                                item.SqlDbType.ToString(), item.Value);
                            break
                    }
                }
            }
            return sb.ToString() + "\n\n -- EXEC \n\t" + StoredProcedureName + "\n\t\t--" +
                string.Join(", ", args.ToArray());
        }
    }
}
