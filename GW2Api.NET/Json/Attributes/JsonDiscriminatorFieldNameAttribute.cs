using System;

namespace GW2Api.NET.Json.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal class JsonDiscriminatorFieldNameAttribute : Attribute
    {
        public string FieldName { get; init; }

        public JsonDiscriminatorFieldNameAttribute(string fieldName)
            => FieldName = fieldName;
    }
}
