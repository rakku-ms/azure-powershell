@{
  GUID = '4d3456f0-8284-4cdd-b477-ce995caa47db'
  RootModule = 'Azs.InfrastructureInsights.Admin.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.InfrastructureInsights.Admin.private.dll'
  FormatsToProcess = './Azs.InfrastructureInsights.Admin.format.ps1xml'
  CmdletsToExport = 'Close-AzsAlert', 'Get-AzsAlert', 'Get-AzsRegionHealth', 'Get-AzsResourceHealth', 'Get-AzsServiceHealth', 'Repair-AzsAlert', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = ''
      LicenseUri = ''
      ProjectUri = ''
      ReleaseNotes = ''
    }
  }
}
