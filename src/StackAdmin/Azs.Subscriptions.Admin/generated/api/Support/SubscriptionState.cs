namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    public partial struct SubscriptionState :
        System.IEquatable<SubscriptionState>
    {
        /// <summary>
        /// Final state of subscription. All resources and data are deleted. This state cannot be reversed.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState Deleted = @"Deleted";

        /// <summary>
        /// This state is unique to Azure Stack and is only visible to the Azure Stack Operator, and if used, to the respective Delegated
        /// Provider. Resources and Data are being deleted before subscription state is set to Deleted. This state cannot be reversed.
        /// It means that deletion is in progress.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState Deleting = @"Deleting";

        /// <summary>
        /// Subscription is not active and usage is not reported. Resources are shut down (VMs stopped and deallocated, IP addresses
        /// are freed, etc). During this period, the Azure Stack Operator can re-enable the subscription which allows creation of
        /// new resources but doesn’t automatically restore disabled resources.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState Disabled = @"Disabled";

        /// <summary>Subscription is active. New resources can be created.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState Enabled = @"Enabled";

        /// <summary>This state is not used in Azure Stack.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState NotDefined = @"NotDefined";

        /// <summary>
        /// This state is unique to Azure Stack and is only visible to the Azure Stack Operator, and if used, to the respective Delegated
        /// Provider. It means that deletion failed. You can’t reverse the deletion process, so in this state all you can do is restart
        /// deletion. This state is not reported to RPs.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState PartiallyDeleted = @"PartiallyDeleted";

        /// <summary>This state is not used in Azure Stack.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState PastDue = @"PastDue";

        /// <summary>This state is not used in Azure Stack.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState Warned = @"Warned";

        /// <summary>the value for an instance of the <see cref="SubscriptionState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SubscriptionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SubscriptionState" />.</param>
        /// <returns>FIXME: Method CreateFrom <returns> is MISSING DESCRIPTION</returns>
        internal static object CreateFrom(object value)
        {
            return new SubscriptionState(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SubscriptionState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SubscriptionState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SubscriptionState && Equals((SubscriptionState)obj);
        }

        /// <summary>Returns hashCode for enum SubscriptionState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SubscriptionState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SubscriptionState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SubscriptionState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SubscriptionState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SubscriptionState" />.</param>

        public static implicit operator SubscriptionState(string value)
        {
            return new SubscriptionState(value);
        }

        /// <summary>Implicit operator to convert SubscriptionState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SubscriptionState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SubscriptionState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SubscriptionState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState e2)
        {
            return e2.Equals(e1);
        }
    }
}