namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    public partial class SubscriptionsAdminIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.ISubscriptionsAdminIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.ISubscriptionsAdminIdentityInternal
    {

        /// <summary>Backing field for <see cref="DelegatedProvider" /> property.</summary>
        private string _delegatedProvider;

        /// <summary>DelegatedProvider identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string DelegatedProvider { get => this._delegatedProvider; set => this._delegatedProvider = value; }

        /// <summary>Backing field for <see cref="DelegatedProviderSubscriptionId" /> property.</summary>
        private string _delegatedProviderSubscriptionId;

        /// <summary>Delegated provider subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string DelegatedProviderSubscriptionId { get => this._delegatedProviderSubscriptionId; set => this._delegatedProviderSubscriptionId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The AzureStack location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="ManifestName" /> property.</summary>
        private string _manifestName;

        /// <summary>The manifest name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ManifestName { get => this._manifestName; set => this._manifestName = value; }

        /// <summary>Backing field for <see cref="Offer" /> property.</summary>
        private string _offer;

        /// <summary>Name of an offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Offer { get => this._offer; set => this._offer = value; }

        /// <summary>Backing field for <see cref="OfferDelegationName" /> property.</summary>
        private string _offerDelegationName;

        /// <summary>Name of a offer delegation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string OfferDelegationName { get => this._offerDelegationName; set => this._offerDelegationName = value; }

        /// <summary>Backing field for <see cref="OperationsStatusName" /> property.</summary>
        private string _operationsStatusName;

        /// <summary>The operation status name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string OperationsStatusName { get => this._operationsStatusName; set => this._operationsStatusName = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private string _plan;

        /// <summary>Name of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Plan { get => this._plan; set => this._plan = value; }

        /// <summary>Backing field for <see cref="PlanAcquisitionId" /> property.</summary>
        private string _planAcquisitionId;

        /// <summary>The plan acquisition Identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string PlanAcquisitionId { get => this._planAcquisitionId; set => this._planAcquisitionId = value; }

        /// <summary>Backing field for <see cref="Quota" /> property.</summary>
        private string _quota;

        /// <summary>Name of the quota.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Quota { get => this._quota; set => this._quota = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The resource group the resource is located under.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="Subscription" /> property.</summary>
        private string _subscription;

        /// <summary>Subscription parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Subscription { get => this._subscription; set => this._subscription = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TargetSubscriptionId" /> property.</summary>
        private string _targetSubscriptionId;

        /// <summary>The target subscription ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TargetSubscriptionId { get => this._targetSubscriptionId; set => this._targetSubscriptionId = value; }

        /// <summary>Backing field for <see cref="Tenant" /> property.</summary>
        private string _tenant;

        /// <summary>Directory tenant name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Tenant { get => this._tenant; set => this._tenant = value; }

        /// <summary>Creates an new <see cref="SubscriptionsAdminIdentity" /> instance.</summary>
        public SubscriptionsAdminIdentity()
        {

        }
    }
    public partial interface ISubscriptionsAdminIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>DelegatedProvider identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DelegatedProvider identifier.",
        SerializedName = @"delegatedProvider",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedProvider { get; set; }
        /// <summary>Delegated provider subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Delegated provider subscription identifier.",
        SerializedName = @"delegatedProviderSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedProviderSubscriptionId { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The AzureStack location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The AzureStack location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The manifest name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The manifest name.",
        SerializedName = @"manifestName",
        PossibleTypes = new [] { typeof(string) })]
        string ManifestName { get; set; }
        /// <summary>Name of an offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of an offer.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string Offer { get; set; }
        /// <summary>Name of a offer delegation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of a offer delegation.",
        SerializedName = @"offerDelegationName",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDelegationName { get; set; }
        /// <summary>The operation status name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operation status name.",
        SerializedName = @"operationsStatusName",
        PossibleTypes = new [] { typeof(string) })]
        string OperationsStatusName { get; set; }
        /// <summary>Name of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the plan.",
        SerializedName = @"plan",
        PossibleTypes = new [] { typeof(string) })]
        string Plan { get; set; }
        /// <summary>The plan acquisition Identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The plan acquisition Identifier",
        SerializedName = @"planAcquisitionId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanAcquisitionId { get; set; }
        /// <summary>Name of the quota.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the quota.",
        SerializedName = @"quota",
        PossibleTypes = new [] { typeof(string) })]
        string Quota { get; set; }
        /// <summary>The resource group the resource is located under.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group the resource is located under.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>Subscription parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription parameter.",
        SerializedName = @"subscription",
        PossibleTypes = new [] { typeof(string) })]
        string Subscription { get; set; }
        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The target subscription ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target subscription ID.",
        SerializedName = @"targetSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetSubscriptionId { get; set; }
        /// <summary>Directory tenant name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Directory tenant name.",
        SerializedName = @"tenant",
        PossibleTypes = new [] { typeof(string) })]
        string Tenant { get; set; }

    }
    internal partial interface ISubscriptionsAdminIdentityInternal

    {
        /// <summary>DelegatedProvider identifier.</summary>
        string DelegatedProvider { get; set; }
        /// <summary>Delegated provider subscription identifier.</summary>
        string DelegatedProviderSubscriptionId { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The AzureStack location.</summary>
        string Location { get; set; }
        /// <summary>The manifest name.</summary>
        string ManifestName { get; set; }
        /// <summary>Name of an offer.</summary>
        string Offer { get; set; }
        /// <summary>Name of a offer delegation.</summary>
        string OfferDelegationName { get; set; }
        /// <summary>The operation status name.</summary>
        string OperationsStatusName { get; set; }
        /// <summary>Name of the plan.</summary>
        string Plan { get; set; }
        /// <summary>The plan acquisition Identifier</summary>
        string PlanAcquisitionId { get; set; }
        /// <summary>Name of the quota.</summary>
        string Quota { get; set; }
        /// <summary>The resource group the resource is located under.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>Subscription parameter.</summary>
        string Subscription { get; set; }
        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        string SubscriptionId { get; set; }
        /// <summary>The target subscription ID.</summary>
        string TargetSubscriptionId { get; set; }
        /// <summary>Directory tenant name.</summary>
        string Tenant { get; set; }

    }
}