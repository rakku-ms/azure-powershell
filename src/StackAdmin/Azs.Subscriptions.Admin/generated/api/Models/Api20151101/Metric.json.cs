namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The resource metric set that represents the metrics for a particular resource.</summary>
    public partial class Metric
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetric.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetric.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetric FromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json ? new Metric(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject into a new instance of <see cref="Metric" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Metric(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_endTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("endTime"), out var __jsonEndTime) ? global::System.DateTime.TryParse((string)__jsonEndTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndTimeValue) ? __jsonEndTimeValue : EndTime : EndTime;}
            {_unit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("metricUnit"), out var __jsonMetricUnit) ? (string)__jsonMetricUnit : (string)Unit;}
            {_value = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonArray>("metricValues"), out var __jsonMetricValues) ? If( __jsonMetricValues as Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValue[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValue) (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.MetricValue.FromJson(__u) )) ))() : null : Value;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? global::System.DateTime.TryParse((string)__jsonStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : StartTime : StartTime;}
            {_timeGrain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("timeGrain"), out var __jsonTimeGrain) ? (string)__jsonTimeGrain : (string)TimeGrain;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Metric" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Metric" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._endTime ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._endTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endTime" ,container.Add );
            AddIf( null != (((object)this._unit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._unit.ToString()) : null, "metricUnit" ,container.Add );
            if (null != this._value)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._value )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("metricValues",__w);
            }
            AddIf( null != this._startTime ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._startTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startTime" ,container.Add );
            AddIf( null != (((object)this._timeGrain)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._timeGrain.ToString()) : null, "timeGrain" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}