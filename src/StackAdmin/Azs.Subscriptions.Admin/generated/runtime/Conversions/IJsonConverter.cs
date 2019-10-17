namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json
{
    internal interface IJsonConverter
    {
        JsonNode ToJson(object value);

        object FromJson(JsonNode node);
    }
}