using System;

namespace GW2Api.NET.Json
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal class JsonDiscriminatorAttribute : Attribute
    {
        public string Discriminator { get; init; }

        public JsonDiscriminatorAttribute(string discriminator)
        {
            this.Discriminator = discriminator;
        }
    }
}
