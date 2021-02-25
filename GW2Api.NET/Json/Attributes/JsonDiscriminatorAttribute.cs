using System;

namespace GW2Api.NET.Json.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal class JsonDiscriminatorAttribute : Attribute
    {
        public string Discriminator { get; init; }

        public JsonDiscriminatorAttribute(string discriminator)
            => Discriminator = discriminator;
    }
}
