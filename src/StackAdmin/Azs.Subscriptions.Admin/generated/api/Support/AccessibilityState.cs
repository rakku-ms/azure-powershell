namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct AccessibilityState :
        System.IEquatable<AccessibilityState>
    {
        /// <summary>
        /// The offer or plan is decommissioned. Current subscriptions can still consume it but new subscriptions cannot.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState Decommissioned = @"Decommissioned";

        /// <summary>The offer or plan is private. Only an Admin can see and manage it.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState Private = @"Private";

        /// <summary>The offer or plan is public. Users can see and self-subscribe to it.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState Public = @"Public";

        /// <summary>the value for an instance of the <see cref="AccessibilityState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AccessibilityState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AccessibilityState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AccessibilityState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccessibilityState" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new AccessibilityState(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AccessibilityState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AccessibilityState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AccessibilityState && Equals((AccessibilityState)obj);
        }

        /// <summary>Returns hashCode for enum AccessibilityState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AccessibilityState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AccessibilityState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccessibilityState" />.</param>

        public static implicit operator AccessibilityState(string value)
        {
            return new AccessibilityState(value);
        }

        /// <summary>Implicit operator to convert AccessibilityState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AccessibilityState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AccessibilityState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AccessibilityState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState e2)
        {
            return e2.Equals(e1);
        }
    }
}