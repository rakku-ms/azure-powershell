namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The linked notification rule.</summary>
    public partial class LinkedNotificationRule :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRule,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string[] _action;

        /// <summary>List of actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] Action { get => this._action; set => this._action = value; }

        /// <summary>Creates an new <see cref="LinkedNotificationRule" /> instance.</summary>
        public LinkedNotificationRule()
        {

        }
    }
    /// The linked notification rule.
    public partial interface ILinkedNotificationRule :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of actions.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(string) })]
        string[] Action { get; set; }

    }
    /// The linked notification rule.
    internal partial interface ILinkedNotificationRuleInternal

    {
        /// <summary>List of actions.</summary>
        string[] Action { get; set; }

    }
}