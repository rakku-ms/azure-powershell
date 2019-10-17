namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json
{
    public sealed class StringConverter : JsonConverter<string>
    {
        internal override JsonNode ToJson(string value) => new JsonString(value);

        internal override string FromJson(JsonNode node) => node.ToString();
    }
}