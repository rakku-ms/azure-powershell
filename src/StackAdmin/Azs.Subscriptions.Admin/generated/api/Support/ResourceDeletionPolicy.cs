namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct ResourceDeletionPolicy :
        System.IEquatable<ResourceDeletionPolicy>
    {
        /// <summary>The resource deletion policy is cascade.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy Cascade = @"Cascade";

        /// <summary>The resource deletion policy is not specified.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy NotSpecified = @"NotSpecified";

        /// <summary>the value for an instance of the <see cref="ResourceDeletionPolicy" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResourceDeletionPolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceDeletionPolicy" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new ResourceDeletionPolicy(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResourceDeletionPolicy</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResourceDeletionPolicy (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResourceDeletionPolicy && Equals((ResourceDeletionPolicy)obj);
        }

        /// <summary>Returns hashCode for enum ResourceDeletionPolicy</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResourceDeletionPolicy" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResourceDeletionPolicy(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResourceDeletionPolicy</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResourceDeletionPolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResourceDeletionPolicy" />.</param>

        public static implicit operator ResourceDeletionPolicy(string value)
        {
            return new ResourceDeletionPolicy(value);
        }

        /// <summary>Implicit operator to convert ResourceDeletionPolicy to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResourceDeletionPolicy" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResourceDeletionPolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResourceDeletionPolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy e2)
        {
            return e2.Equals(e1);
        }
    }
}