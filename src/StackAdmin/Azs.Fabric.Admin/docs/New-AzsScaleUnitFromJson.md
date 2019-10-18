---
external help file:
Module Name: Azs.Fabric.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/new-azsscaleunitfromjson
schema: 2.0.0
---

# New-AzsScaleUnitFromJson

## SYNOPSIS
Add a new scale unit.

## SYNTAX

### CreateExpanded (Default)
```
New-AzsScaleUnitFromJson -ResourceGroupName <String> -ScaleUnit <String> [-Location <String>]
 [-SubscriptionId <String>] [-ClusterName <String>] [-InfrastructureNetworkSubnet <String[]>]
 [-InfrastructureNetworkVlanId <String[]>] [-NetQosPriority <Int32>]
 [-PhysicalNode <IDeploymentJsonPhysicalNodeParameters[]>] [-SoftwareBgpAsn <String>]
 [-StorageNetworkSubnet <String[]>] [-StorageNetworkVlanId <String[]>] [-TorSwitchBgpAsn <String>]
 [-TorSwitchBgpPeerIP <String[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-AzsScaleUnitFromJson -ResourceGroupName <String> -ScaleUnit <String>
 -CreationData <ICreateFromJsonScaleUnitParametersList> [-Location <String>] [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzsScaleUnitFromJson -InputObject <IFabricAdminIdentity>
 -CreationData <ICreateFromJsonScaleUnitParametersList> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzsScaleUnitFromJson -InputObject <IFabricAdminIdentity> [-ClusterName <String>]
 [-InfrastructureNetworkSubnet <String[]>] [-InfrastructureNetworkVlanId <String[]>] [-NetQosPriority <Int32>]
 [-PhysicalNode <IDeploymentJsonPhysicalNodeParameters[]>] [-SoftwareBgpAsn <String>]
 [-StorageNetworkSubnet <String[]>] [-StorageNetworkVlanId <String[]>] [-TorSwitchBgpAsn <String>]
 [-TorSwitchBgpPeerIP <String[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add a new scale unit.

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

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ClusterName
Cluster name for the new scale unit.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreationData
A list of input data that allows for creating the new scale unit.
To construct, see NOTES section for CREATIONDATA properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ICreateFromJsonScaleUnitParametersList
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -InfrastructureNetworkSubnet
The subnet IP mask in the example format 10.0.0.0/25.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InfrastructureNetworkVlanId
The Vlan ID of the subnet.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
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
Type: Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Location
Location of the resource.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzLocation)[0].Location
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NetQosPriority
The network QOS priority setting.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PhysicalNode
List of nodes in the scale unit.
To construct, see NOTES section for PHYSICALNODE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IDeploymentJsonPhysicalNodeParameters[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
Name of the resource group.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ScaleUnit
Name of the scale units.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SoftwareBgpAsn
The software ASN for the cluster's rack.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StorageNetworkSubnet
The subnet IP mask in the example format 10.0.0.0/25.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StorageNetworkVlanId
The Vlan ID of the subnet.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
Subscription credentials that uniquely identify Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TorSwitchBgpAsn
The ASN for the cluster's rack TOR.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TorSwitchBgpPeerIP
The list of IP addresses used for TOR communication.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ICreateFromJsonScaleUnitParametersList

### Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### CREATIONDATA <ICreateFromJsonScaleUnitParametersList>: A list of input data that allows for creating the new scale unit.
  - `[ClusterName <String>]`: Cluster name for the new scale unit.
  - `[InfrastructureNetworkSubnet <String[]>]`: The subnet IP mask in the example format 10.0.0.0/25.
  - `[InfrastructureNetworkVlanId <String[]>]`: The Vlan ID of the subnet.
  - `[NetQosPriority <Int32?>]`: The network QOS priority setting.
  - `[PhysicalNode <IDeploymentJsonPhysicalNodeParameters[]>]`: List of nodes in the scale unit.
    - `[BmcipAddress <String>]`: BMC address of the physical machine.
    - `[Name <String>]`: Computer name of the physical machine.
  - `[SoftwareBgpAsn <String>]`: The software ASN for the cluster's rack.
  - `[StorageNetworkSubnet <String[]>]`: The subnet IP mask in the example format 10.0.0.0/25.
  - `[StorageNetworkVlanId <String[]>]`: The Vlan ID of the subnet.
  - `[TorSwitchBgpAsn <String>]`: The ASN for the cluster's rack TOR.
  - `[TorSwitchBgpPeerIP <String[]>]`: The list of IP addresses used for TOR communication.

#### INPUTOBJECT <IFabricAdminIdentity>: Identity Parameter
  - `[Drive <String>]`: Name of the storage drive.
  - `[EdgeGateway <String>]`: Name of the edge gateway.
  - `[EdgeGatewayPool <String>]`: Name of the edge gateway pool.
  - `[FabricLocation <String>]`: Fabric location.
  - `[FileShare <String>]`: Fabric file share name.
  - `[IPPool <String>]`: IP pool name.
  - `[Id <String>]`: Resource identity path
  - `[InfraRole <String>]`: Infrastructure role name.
  - `[InfraRoleInstance <String>]`: Name of an infrastructure role instance.
  - `[Location <String>]`: Location of the resource.
  - `[LogicalNetwork <String>]`: Name of the logical network.
  - `[LogicalSubnet <String>]`: Name of the logical subnet.
  - `[MacAddressPool <String>]`: Name of the MAC address pool.
  - `[Operation <String>]`: Operation identifier.
  - `[ResourceGroupName <String>]`: Name of the resource group.
  - `[ScaleUnit <String>]`: Name of the scale units.
  - `[ScaleUnitNode <String>]`: Name of the scale unit node.
  - `[SlbMuxInstance <String>]`: Name of a SLB MUX instance.
  - `[StoragePool <String>]`: Storage pool name.
  - `[StorageSubSystem <String>]`: Name of the storage system.
  - `[SubscriptionId <String>]`: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
  - `[Volume <String>]`: Name of the storage volume.

#### PHYSICALNODE <IDeploymentJsonPhysicalNodeParameters[]>: List of nodes in the scale unit.
  - `[BmcipAddress <String>]`: BMC address of the physical machine.
  - `[Name <String>]`: Computer name of the physical machine.

## RELATED LINKS

