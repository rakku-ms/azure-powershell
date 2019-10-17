namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct MarketplaceType :
        System.IEquatable<MarketplaceType>
    {
        /// <summary>The marketplace offer is an add-on to a resource.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType AddOn = @"AddOn";

        /// <summary>The marketplace type is not specified.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType NotSpecified = @"NotSpecified";

        /// <summary>the value for an instance of the <see cref="MarketplaceType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MarketplaceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MarketplaceType" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new MarketplaceType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MarketplaceType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MarketplaceType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MarketplaceType && Equals((MarketplaceType)obj);
        }

        /// <summary>Returns hashCode for enum MarketplaceType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MarketplaceType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MarketplaceType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MarketplaceType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MarketplaceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MarketplaceType" />.</param>

        public static implicit operator MarketplaceType(string value)
        {
            return new MarketplaceType(value);
        }

        /// <summary>Implicit operator to convert MarketplaceType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MarketplaceType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MarketplaceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MarketplaceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType e2)
        {
            return e2.Equals(e1);
        }
    }
}