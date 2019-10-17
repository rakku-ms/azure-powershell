namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct RoutingType :
        System.IEquatable<RoutingType>
    {
        /// <summary>The resource routing type is default.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType Default = @"Default";

        /// <summary>The resource routing type is extension.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType Extension = @"Extension";

        /// <summary>The resource routing type is fan out.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType Fanout = @"Fanout";

        /// <summary>The resource routing type is host based.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType HostBased = @"HostBased";

        /// <summary>The resource routing type is Location based.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType LocationBased = @"LocationBased";

        /// <summary>The resource routing type is proxy only.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType ProxyOnly = @"ProxyOnly";

        /// <summary>The resource routing type is tenant.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType Tenant = @"Tenant";

        /// <summary>the value for an instance of the <see cref="RoutingType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RoutingType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RoutingType" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new RoutingType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RoutingType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RoutingType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RoutingType && Equals((RoutingType)obj);
        }

        /// <summary>Returns hashCode for enum RoutingType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RoutingType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RoutingType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RoutingType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RoutingType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RoutingType" />.</param>

        public static implicit operator RoutingType(string value)
        {
            return new RoutingType(value);
        }

        /// <summary>Implicit operator to convert RoutingType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RoutingType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RoutingType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RoutingType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType e2)
        {
            return e2.Equals(e1);
        }
    }
}