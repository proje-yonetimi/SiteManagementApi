using Microsoft.EntityFrameworkCore;

namespace SiteManagementApi.Operation.Interfaces
{
    public interface ISpCall
    {
        void SetBool(string name, bool? value);
        void SetBool(string name, bool? value,bool defaultValue);
        void SetBoolInputOutput(string name, bool? value);
        void SetBoolInputOutput(string name, bool? value, bool defaultValue);
        void SetBoolOutput(string name);
        void SetByte(string name, byte? value);
        void SetByte(string name, byte? value, byte defaultValue);
        void SetByteInputOutput(string name, byte? value);
        void SetByteInputOutput(string name, byte? value, byte defaultValue);
        void SetByteOutput(string name);
        void SetChar(string name, char? value);
        void SetChar(string name, char? value, char defaultValue);
        void SetCharInputOutput(string name, char? value);
        void SetCharInputOutput(string name, char? value, char defaultValue);
        void SetCharOutput(string name);
        void SetDateTime(string name, DateTime? value);
        void SetDateTime(string name, DateTime? value, DateTime defaultValue);
        void SetDateTimeInputOutput(string name, DateTime? value);
        void SetDateTimeInputOutput(string name, DateTime? value, DateTime defaultValue);
        void SetDateTimeOutput(string name);
        void SetDecimal(string name, decimal? value);
        void SetDecimal(string name, decimal? value, decimal defaultValue);
        void SetDecimalInputOutput(string name, decimal? value, byte precision, byte scale);
        void SetDecimalInputOutput(string name, decimal? value, byte precision, byte scale,  decimal defaultValue);
        void SetDecimalOutput(string name, byte precision, byte scale);
        void SetDouble(string name, double? value);
        void SetDouble(string name, double? value, double defaultValue);
        void SetDoubleInputOutput(string name, double? value);
        void SetDoubleInputOutput(string name, double? value, double defaultValue);
        void SetDoubleOutput(string name);
        void SetFloat(string name, float? value);
        void SetFloat(string name, float? value, float defaultValue);
        void SetFloatInputOutput(string name, float? value);
        void SetFloatInputOutput(string name, float? value, float defaultValue);
        void SetFloatOutput(string name);
        void SetGuid(string name, Guid? value);
        void SetGuidInputOutput(string name, Guid? value);
        void SetGuidOutput(string name);
        void SetInt(string name, int? value);
        void SetInt(string name, int? value, int defaultValue);
        void SetIntInputOutput(string name, int? value);
        void SetIntInputOutput(string name, int? value, int defaultValue);
        void SetIntOutput(string name);
        void SetLong(string name, long? value);
        void SetLong(string name, long? value, long defaultValue);
        void SetLongInputOutput(string name, long? value);
        void SetLongInputOutput(string name, long? value, long defaultValue);
        void SetLongOutput(string name);
        void SetObject(string name, byte[] value);
        void SetShort(string name, short? value);
        void SetShort(string name, short? value, short defaultValue);
        void SetShort(string name, int? value);
        void SetShort(string name, int? value, int defaultValue);
        void SetShortInputOutput(string name, short? value);
        void SetShortInputOutput(string name, short? value, short defaultValue);
        void SetShortInputOutput(string name, int? value);
        void SetShortInputOutput(string name, int? value, int defaultValue);
        void SetShortOutput(string name);
        void SetString(string name, string? value);
        void SetString(string name, string? value, int size);
        void SetString(string name, string? value, string defaultValue);
        void SetString(string name, string? value, string defaultValue,int size);
        void SetStringInputOutput(string name, string? value, int size);
        void SetStringInputOutput(string name, string? value, int size, string defaultValue);
        void SetStringOutput(string name, int size);
        void SetValue(string name, object value, Type valueType);
        string Statement { get; set; }

    }
}
