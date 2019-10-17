namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct ResourceManagerType :
        System.IEquatable<ResourceManagerType>
    {
        /// <summary>FIXME: Field Admin is MISSING DESCRIPTION</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType Admin = @"Admin";

        /// <summary>FIXME: Field Default is MISSING DESCRIPTION</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType Default = @"Default";

        /// <summary>the value for an instance of the <see cref="ResourceManagerType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResourceManagerType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceManagerType" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new ResourceManagerType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResourceManagerType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResourceManagerType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResourceManagerType && Equals((ResourceManagerType)obj);
        }

        /// <summary>Returns hashCode for enum ResourceManagerType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResourceManagerType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResourceManagerType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResourceManagerType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResourceManagerType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceManagerType" />.</param>

        public static implicit operator ResourceManagerType(string value)
        {
            return new ResourceManagerType(value);
        }

        /// <summary>Implicit operator to convert ResourceManagerType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResourceManagerType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResourceManagerType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResourceManagerType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType e2)
        {
            return e2.Equals(e1);
        }
    }
}