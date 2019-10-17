---
external help file:
Module Name: Azs.AzureBridge.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.azurebridge.admin/set-azsactivation
schema: 2.0.0
---

# Set-AzsActivation

## SYNOPSIS
Create a new activation.

## SYNTAX

### UpdateExpanded (Default)
```
Set-AzsActivation -Name <String> -ResourceGroup <String> [-SubscriptionId <String>]
 [-AzureRegistrationResourceIdentifier <String>] [-DisplayName <String>] [-Expiration <String>]
 [-MarketplaceSyndicationEnabled] [-ProvisioningState <ProvisioningState>] [-UsageReportingEnabled]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Set-AzsActivation -Name <String> -ResourceGroup <String> -Activation <IActivation> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new activation.

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

### -Activation
Holds properties related to activation.
To construct, see NOTES section for ACTIVATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivation
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -AzureRegistrationResourceIdentifier
Azure registration resource identifier.

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

### -DisplayName
Name displayed for the product.

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

### -Expiration
The activation expiration.

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

### -MarketplaceSyndicationEnabled
Value indicating whether the marketplace syndication feature is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
Name of the activation.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ActivationName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningState
Provisioning state of the resource.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroup
The resource group the resource is located under.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UsageReportingEnabled
Value indicating whether the usage reporting feature is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivation

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivationResource

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ACTIVATION <IActivation>: Holds properties related to activation.
  - `[AzureRegistrationResourceIdentifier <String>]`: Azure registration resource identifier.
  - `[DisplayName <String>]`: Name displayed for the product.
  - `[Expiration <String>]`: The activation expiration.
  - `[MarketplaceSyndicationEnabled <Boolean?>]`: Value indicating whether the marketplace syndication feature is enabled.
  - `[ProvisioningState <ProvisioningState?>]`: Provisioning state of the resource.
  - `[UsageReportingEnabled <Boolean?>]`: Value indicating whether the usage reporting feature is enabled.

## RELATED LINKS

