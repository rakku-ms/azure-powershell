using System;

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json
{
    public sealed class JsonConverterAttribute : Attribute
    {
        internal JsonConverterAttribute(Type type)
        {
            Converter = (IJsonConverter)Activator.CreateInstance(type);
        }

        internal IJsonConverter Converter { get; }
    }
}