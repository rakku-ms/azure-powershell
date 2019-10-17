namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct MetricUnit :
        System.IEquatable<MetricUnit>
    {
        /// <summary>The bytes.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit Bytes = @"Bytes";

        /// <summary>The bytes per second.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit BytesPerSecond = @"BytesPerSecond";

        /// <summary>The count.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit Count = @"Count";

        /// <summary>The count per second.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit CountPerSecond = @"CountPerSecond";

        /// <summary>The seconds.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit Seconds = @"Seconds";

        /// <summary>the value for an instance of the <see cref="MetricUnit" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MetricUnit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MetricUnit" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new MetricUnit(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MetricUnit</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MetricUnit (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MetricUnit && Equals((MetricUnit)obj);
        }

        /// <summary>Returns hashCode for enum MetricUnit</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MetricUnit" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MetricUnit(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MetricUnit</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MetricUnit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MetricUnit" />.</param>

        public static implicit operator MetricUnit(string value)
        {
            return new MetricUnit(value);
        }

        /// <summary>Implicit operator to convert MetricUnit to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MetricUnit" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MetricUnit</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MetricUnit</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit e2)
        {
            return e2.Equals(e1);
        }
    }
}