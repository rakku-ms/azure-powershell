namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>
    /// A plan represents a package of quotas and capabilities that are offered tenants. A tenant can acquire this plan through
    /// an offer to upgrade his access to underlying cloud services.
    /// </summary>
    public partial class Plan :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlan,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.Resource();

        /// <summary>Description of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).Description = value; }

        /// <summary>Display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).DisplayName = value; }

        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string ExternalReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).ExternalReferenceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).ExternalReferenceId = value; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanProperties Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.PlanProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal.Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Tag = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Name; }

        /// <summary>Name of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string PropertiesName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).Name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanProperties _property;

        /// <summary>Properties of a plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.PlanProperties()); set => this._property = value; }

        /// <summary>Quota identifiers under the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string[] QuotaId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).QuotaId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).QuotaId = value; }

        /// <summary>SKU identifiers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string[] SkuId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).SkuId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).SkuId = value; }

        /// <summary>Subscription count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public int? SubscriptionCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).SubscriptionCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanPropertiesInternal)Property).SubscriptionCount = value; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Tag; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Plan" /> instance.</summary>
        public Plan()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A plan represents a package of quotas and capabilities that are offered tenants. A tenant can acquire this plan through
    /// an offer to upgrade his access to underlying cloud services.
    public partial interface IPlan :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResource
    {
        /// <summary>Description of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the plan.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External reference identifier.",
        SerializedName = @"externalReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalReferenceId { get; set; }
        /// <summary>Name of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the plan.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesName { get; set; }
        /// <summary>Quota identifiers under the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Quota identifiers under the plan.",
        SerializedName = @"quotaIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] QuotaId { get; set; }
        /// <summary>SKU identifiers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SKU identifiers.",
        SerializedName = @"skuIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] SkuId { get; set; }
        /// <summary>Subscription count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription count.",
        SerializedName = @"subscriptionCount",
        PossibleTypes = new [] { typeof(int) })]
        int? SubscriptionCount { get; set; }

    }
    /// A plan represents a package of quotas and capabilities that are offered tenants. A tenant can acquire this plan through
    /// an offer to upgrade his access to underlying cloud services.
    internal partial interface IPlanInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceInternal
    {
        /// <summary>Description of the plan.</summary>
        string Description { get; set; }
        /// <summary>Display name.</summary>
        string DisplayName { get; set; }
        /// <summary>External reference identifier.</summary>
        string ExternalReferenceId { get; set; }
        /// <summary>Name of the plan.</summary>
        string PropertiesName { get; set; }
        /// <summary>Properties of a plan.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanProperties Property { get; set; }
        /// <summary>Quota identifiers under the plan.</summary>
        string[] QuotaId { get; set; }
        /// <summary>SKU identifiers.</summary>
        string[] SkuId { get; set; }
        /// <summary>Subscription count.</summary>
        int? SubscriptionCount { get; set; }

    }
}