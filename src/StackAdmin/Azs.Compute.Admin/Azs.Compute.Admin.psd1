@{
  GUID = '79e8dac7-36bb-4085-816c-ceb357a48e06'
  RootModule = 'Azs.Compute.Admin.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Compute.Admin.private.dll'
  FormatsToProcess = './Azs.Compute.Admin.format.ps1xml'
  CmdletsToExport = 'Get-AzsDisk', 'Get-AzsDiskMigrationJob', 'Get-AzsPlatformImage', 'Get-AzsQuota', 'Get-AzsVMExtension', 'New-AzsDiskMigrationJob', 'New-AzsPlatformImage', 'New-AzsQuota', 'New-AzsVMExtension', 'Remove-AzsPlatformImage', 'Remove-AzsQuota', 'Remove-AzsVMExtension', 'Set-AzsQuota', 'Stop-AzsDiskMigrationJob', '*'
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
