namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct ResourceProviderType :
        System.IEquatable<ResourceProviderType>
    {
        /// <summary>The resource provider can always be routed to without explicit access via plan.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType AlwaysRoutable = @"AlwaysRoutable";

        /// <summary>
        /// The resource provider type is external. This is used for 3rd party resource providers.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType External = @"External";

        /// <summary>The resource provider type is internal.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType Internal = @"Internal";

        /// <summary>The resource provider type is not specified.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType NotSpecified = @"NotSpecified";

        /// <summary>The resource provider doesn't require subscription registrations.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType RegistrationFree = @"RegistrationFree";

        /// <summary>The resource provider operates only at tenant level.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType TenantOnly = @"TenantOnly";

        /// <summary>the value for an instance of the <see cref="ResourceProviderType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResourceProviderType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceProviderType" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new ResourceProviderType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResourceProviderType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResourceProviderType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResourceProviderType && Equals((ResourceProviderType)obj);
        }

        /// <summary>Returns hashCode for enum ResourceProviderType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResourceProviderType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResourceProviderType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResourceProviderType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResourceProviderType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceProviderType" />.</param>

        public static implicit operator ResourceProviderType(string value)
        {
            return new ResourceProviderType(value);
        }

        /// <summary>Implicit operator to convert ResourceProviderType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResourceProviderType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResourceProviderType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResourceProviderType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType e2)
        {
            return e2.Equals(e1);
        }
    }
}