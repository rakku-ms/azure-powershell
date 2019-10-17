namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct HealthStatus :
        System.IEquatable<HealthStatus>
    {
        /// <summary>The health status is healthy, indicating nothing is wrong.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus Healthy = @"Healthy";

        /// <summary>
        /// The health status is unhealthy, indicating something is wrong or a sub-health status is Unhealthy or Unknown.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus Unhealthy = @"Unhealthy";

        /// <summary>The health status is unknown.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="HealthStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to HealthStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="HealthStatus" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new HealthStatus(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type HealthStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type HealthStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is HealthStatus && Equals((HealthStatus)obj);
        }

        /// <summary>Returns hashCode for enum HealthStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="HealthStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private HealthStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for HealthStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to HealthStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="HealthStatus" />.</param>

        public static implicit operator HealthStatus(string value)
        {
            return new HealthStatus(value);
        }

        /// <summary>Implicit operator to convert HealthStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="HealthStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum HealthStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum HealthStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}