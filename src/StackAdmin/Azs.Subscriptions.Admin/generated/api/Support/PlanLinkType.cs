namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct PlanLinkType :
        System.IEquatable<PlanLinkType>
    {
        /// <summary>FIXME: Field Addon is MISSING DESCRIPTION</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType Addon = @"Addon";

        /// <summary>FIXME: Field Base is MISSING DESCRIPTION</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType Base = @"Base";

        /// <summary>FIXME: Field None is MISSING DESCRIPTION</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType None = @"None";

        /// <summary>the value for an instance of the <see cref="PlanLinkType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PlanLinkType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PlanLinkType" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new PlanLinkType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PlanLinkType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PlanLinkType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PlanLinkType && Equals((PlanLinkType)obj);
        }

        /// <summary>Returns hashCode for enum PlanLinkType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PlanLinkType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PlanLinkType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PlanLinkType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PlanLinkType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PlanLinkType" />.</param>

        public static implicit operator PlanLinkType(string value)
        {
            return new PlanLinkType(value);
        }

        /// <summary>Implicit operator to convert PlanLinkType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PlanLinkType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PlanLinkType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PlanLinkType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType e2)
        {
            return e2.Equals(e1);
        }
    }
}