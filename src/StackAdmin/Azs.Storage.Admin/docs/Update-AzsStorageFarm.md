---
external help file:
Module Name: Azs.Storage.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/update-azsstoragefarm
schema: 2.0.0
---

# Update-AzsStorageFarm

## SYNOPSIS
Update an existing storage farm.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzsStorageFarm -FarmName <String> -ResourceGroupName <String> [-Id <String>] [-SubscriptionId <String>]
 [-Location <String>] [-Name <String>] [-PropertiesFarmId <String>] [-Setting <IFarmSettings>]
 [-SettingsStore <String>] [-Tag <Hashtable>] [-Type <String>] [-Version <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-AzsStorageFarm -Id <String> -ResourceGroupName <String> -FarmObject <IFarm> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-AzsStorageFarm -InputObject <IStorageAdminIdentity> -FarmObject <IFarm> [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzsStorageFarm -InputObject <IStorageAdminIdentity> [-FarmName <String>] [-Id <String>]
 [-Location <String>] [-Name <String>] [-Setting <IFarmSettings>] [-SettingsStore <String>] [-Tag <Hashtable>]
 [-Type <String>] [-Version <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update an existing storage farm.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FarmName
Farm Id.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FarmObject
Storage farm.
To construct, see NOTES section for FARMOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api20151201Preview.IFarm
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
Farm Id.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases: FarmId

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.IStorageAdminIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzLocation)[0].Location
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
Resource Name.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PropertiesFarmId
Farm identifier.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
Resource group name.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Setting
The properties of storage farm.
To construct, see NOTES section for SETTING properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api20151201Preview.IFarmSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingsStore
The settings of storage farm.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
Subscription Id.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Type
Resource type.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Version
Resource version.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api20151201Preview.IFarm

### Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.IStorageAdminIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api20151201Preview.IFarm

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### FARMOBJECT <IFarm>: Storage farm.
  - `[Id <String>]`: Resource ID.
  - `[Location <String>]`: Resource location.
  - `[Name <String>]`: Resource Name.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Resource type.
  - `[FarmId <String>]`: Farm identifier.
  - `[Setting <IFarmSettings>]`: The properties of storage farm.
    - `[BandwidthThrottleIsEnabled <Boolean?>]`: Switch of bandwidth throttle enablement.
    - `[CorsAllowedOriginsList <String>]`: The list of allowed origins.
    - `[DataCenterUriHostSuffix <String>]`: The suffixes of URI of hosts in data center.
    - `[DefaultEgressThresholdInGbps <Single?>]`: Default egress threshold (in Gbps).
    - `[DefaultIngressThresholdInGbps <Single?>]`: Default ingress threshold (in Gbps).
    - `[DefaultIntranetEgressThresholdInGbps <Single?>]`: Default Intranet egress threshold (in Gbps).
    - `[DefaultIntranetIngressThresholdInGbps <Single?>]`: Default Intranet ingress threshold (in Gbps).
    - `[DefaultRequestThresholdInTp <Single?>]`: Default request threshold (in TPS).
    - `[DefaultThrottleProbabilityDecayIntervalInSecond <Int32?>]`: Interval (in seconds) of default throttle probability decay.
    - `[DefaultTotalEgressThresholdInGbps <Single?>]`: Default total egress threshold (in Gbps).
    - `[DefaultTotalIngressThresholdInGbps <Single?>]`: Default total ingress threshold (in Gbps).
    - `[FeedbackRefreshIntervalInSecond <Int32?>]`: Interval (in seconds) of feedback refresh.
    - `[GracePeriodForFullThrottlingInRefreshInterval <Int32?>]`: Grace period for full throttling in refresh intervals.
    - `[GracePeriodMaxThrottleProbability <Single?>]`: Maximum probability of throttle in grace period.
    - `[HostStyleHttpPort <Int32?>]`: Host style HTTP port.
    - `[HostStyleHttpsPort <Int32?>]`: Host style HTTPs port.
    - `[MinimumEgressThresholdInGbps <Single?>]`: Minimum egress threshold (in Gbps).
    - `[MinimumIngressThresholdInGbps <Single?>]`: Minimum ingress threshold (in Gbps).
    - `[MinimumIntranetEgressThresholdInGbps <Single?>]`: Minimum Intranet egress threshold (in Gbps).
    - `[MinimumIntranetIngressThresholdInGbps <Single?>]`: Minimum Intranet ingress threshold (in Gbps).
    - `[MinimumRequestThresholdInTp <Single?>]`: Minimum request threshold (in TPS).
    - `[MinimumTotalEgressThresholdInGbps <Single?>]`: Minimum total egress threshold (in Gbp
    - `[MinimumTotalIngressThresholdInGbps <Single?>]`: Minimum total ingress threshold (in Gbps).
    - `[NumberOfAccountsToSync <Int32?>]`: Number of accounts to sync.
    - `[OverallEgressThresholdInGbps <Single?>]`: Overall egress threshold (in Gbps).
    - `[OverallIngressThresholdInGbps <Single?>]`: Overall ingress threshold (in Gbps)
    - `[OverallIntranetEgressThresholdInGbps <Single?>]`: Overall Intranet egress threshold (in Gbps).
    - `[OverallIntranetIngressThresholdInGbps <Single?>]`: Overall Intranet ingress threshold (in Gbps).
    - `[OverallRequestThresholdInTp <Single?>]`: Overall request threshold (in TPS).
    - `[OverallTotalEgressThresholdInGbps <Single?>]`: Overall total egress threshold (in Gbps).
    - `[OverallTotalIngressThresholdInGbps <Single?>]`: Overall total ingress threshold (in Gbps).
    - `[RetentionPeriodForDeletedStorageAccountsInDay <Int32?>]`: The retention period (in days) for deleted storage account.
    - `[SettingsPollingIntervalInSecond <Int32?>]`: The polling interval (in second).
    - `[ToleranceFactorForEgress <Single?>]`: Tolerance factor for egress.
    - `[ToleranceFactorForIngress <Single?>]`: Tolerance factor for ingress.
    - `[ToleranceFactorForIntranetEgress <Single?>]`: Tolerance factor for Intranet egress.
    - `[ToleranceFactorForIntranetIngress <Single?>]`: Tolerance factor for Intranet ingress.
    - `[ToleranceFactorForTotalEgress <Single?>]`: Tolerance factor for total egress.
    - `[ToleranceFactorForTotalIngress <Single?>]`: Tolerance factor for total ingress.
    - `[ToleranceFactorForTp <Single?>]`: Tolerance factor for TPS.
    - `[UsageCollectionIntervalInSecond <Int32?>]`: Interval (in seconds) of storage usage collection.
  - `[SettingsStore <String>]`: The settings of storage farm.
  - `[Version <String>]`: Resource version.

#### INPUTOBJECT <IStorageAdminIdentity>: Identity Parameter
  - `[AccountId <String>]`: Internal storage account ID, which is not visible to tenant.
  - `[FarmId <String>]`: Farm Id.
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: Resource location.
  - `[OperationId <String>]`: Operation Id.
  - `[QuotaName <String>]`: The name of the storage quota.
  - `[ResourceGroupName <String>]`: Resource group name.
  - `[ServiceType <ServiceType?>]`: The service type.
  - `[ShareName <String>]`: Share name.
  - `[SubscriptionId <String>]`: Subscription Id.

#### SETTING <IFarmSettings>: The properties of storage farm.
  - `[BandwidthThrottleIsEnabled <Boolean?>]`: Switch of bandwidth throttle enablement.
  - `[CorsAllowedOriginsList <String>]`: The list of allowed origins.
  - `[DataCenterUriHostSuffix <String>]`: The suffixes of URI of hosts in data center.
  - `[DefaultEgressThresholdInGbps <Single?>]`: Default egress threshold (in Gbps).
  - `[DefaultIngressThresholdInGbps <Single?>]`: Default ingress threshold (in Gbps).
  - `[DefaultIntranetEgressThresholdInGbps <Single?>]`: Default Intranet egress threshold (in Gbps).
  - `[DefaultIntranetIngressThresholdInGbps <Single?>]`: Default Intranet ingress threshold (in Gbps).
  - `[DefaultRequestThresholdInTp <Single?>]`: Default request threshold (in TPS).
  - `[DefaultThrottleProbabilityDecayIntervalInSecond <Int32?>]`: Interval (in seconds) of default throttle probability decay.
  - `[DefaultTotalEgressThresholdInGbps <Single?>]`: Default total egress threshold (in Gbps).
  - `[DefaultTotalIngressThresholdInGbps <Single?>]`: Default total ingress threshold (in Gbps).
  - `[FeedbackRefreshIntervalInSecond <Int32?>]`: Interval (in seconds) of feedback refresh.
  - `[GracePeriodForFullThrottlingInRefreshInterval <Int32?>]`: Grace period for full throttling in refresh intervals.
  - `[GracePeriodMaxThrottleProbability <Single?>]`: Maximum probability of throttle in grace period.
  - `[HostStyleHttpPort <Int32?>]`: Host style HTTP port.
  - `[HostStyleHttpsPort <Int32?>]`: Host style HTTPs port.
  - `[MinimumEgressThresholdInGbps <Single?>]`: Minimum egress threshold (in Gbps).
  - `[MinimumIngressThresholdInGbps <Single?>]`: Minimum ingress threshold (in Gbps).
  - `[MinimumIntranetEgressThresholdInGbps <Single?>]`: Minimum Intranet egress threshold (in Gbps).
  - `[MinimumIntranetIngressThresholdInGbps <Single?>]`: Minimum Intranet ingress threshold (in Gbps).
  - `[MinimumRequestThresholdInTp <Single?>]`: Minimum request threshold (in TPS).
  - `[MinimumTotalEgressThresholdInGbps <Single?>]`: Minimum total egress threshold (in Gbp
  - `[MinimumTotalIngressThresholdInGbps <Single?>]`: Minimum total ingress threshold (in Gbps).
  - `[NumberOfAccountsToSync <Int32?>]`: Number of accounts to sync.
  - `[OverallEgressThresholdInGbps <Single?>]`: Overall egress threshold (in Gbps).
  - `[OverallIngressThresholdInGbps <Single?>]`: Overall ingress threshold (in Gbps)
  - `[OverallIntranetEgressThresholdInGbps <Single?>]`: Overall Intranet egress threshold (in Gbps).
  - `[OverallIntranetIngressThresholdInGbps <Single?>]`: Overall Intranet ingress threshold (in Gbps).
  - `[OverallRequestThresholdInTp <Single?>]`: Overall request threshold (in TPS).
  - `[OverallTotalEgressThresholdInGbps <Single?>]`: Overall total egress threshold (in Gbps).
  - `[OverallTotalIngressThresholdInGbps <Single?>]`: Overall total ingress threshold (in Gbps).
  - `[RetentionPeriodForDeletedStorageAccountsInDay <Int32?>]`: The retention period (in days) for deleted storage account.
  - `[SettingsPollingIntervalInSecond <Int32?>]`: The polling interval (in second).
  - `[ToleranceFactorForEgress <Single?>]`: Tolerance factor for egress.
  - `[ToleranceFactorForIngress <Single?>]`: Tolerance factor for ingress.
  - `[ToleranceFactorForIntranetEgress <Single?>]`: Tolerance factor for Intranet egress.
  - `[ToleranceFactorForIntranetIngress <Single?>]`: Tolerance factor for Intranet ingress.
  - `[ToleranceFactorForTotalEgress <Single?>]`: Tolerance factor for total egress.
  - `[ToleranceFactorForTotalIngress <Single?>]`: Tolerance factor for total ingress.
  - `[ToleranceFactorForTp <Single?>]`: Tolerance factor for TPS.
  - `[UsageCollectionIntervalInSecond <Int32?>]`: Interval (in seconds) of storage usage collection.

## RELATED LINKS

