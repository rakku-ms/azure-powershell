namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The linked resource access checks.</summary>
    public partial class LinkedOperationRule :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRule,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleInternal
    {

        /// <summary>Backing field for <see cref="DependsOnType" /> property.</summary>
        private string[] _dependsOnType;

        /// <summary>The list of resource types this rule depends on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] DependsOnType { get => this._dependsOnType; set => this._dependsOnType = value; }

        /// <summary>Backing field for <see cref="LinkedAction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? _linkedAction;

        /// <summary>The linked action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? LinkedAction { get => this._linkedAction; set => this._linkedAction = value; }

        /// <summary>Backing field for <see cref="LinkedOperation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation? _linkedOperation;

        /// <summary>The linked operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation? LinkedOperation { get => this._linkedOperation; set => this._linkedOperation = value; }

        /// <summary>Creates an new <see cref="LinkedOperationRule" /> instance.</summary>
        public LinkedOperationRule()
        {

        }
    }
    /// The linked resource access checks.
    public partial interface ILinkedOperationRule :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The list of resource types this rule depends on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of resource types this rule depends on.",
        SerializedName = @"dependsOnTypes",
        PossibleTypes = new [] { typeof(string) })]
        string[] DependsOnType { get; set; }
        /// <summary>The linked action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The linked action.",
        SerializedName = @"linkedAction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? LinkedAction { get; set; }
        /// <summary>The linked operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The linked operation.",
        SerializedName = @"linkedOperation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation? LinkedOperation { get; set; }

    }
    /// The linked resource access checks.
    internal partial interface ILinkedOperationRuleInternal

    {
        /// <summary>The list of resource types this rule depends on.</summary>
        string[] DependsOnType { get; set; }
        /// <summary>The linked action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? LinkedAction { get; set; }
        /// <summary>The linked operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedOperation? LinkedOperation { get; set; }

    }
}