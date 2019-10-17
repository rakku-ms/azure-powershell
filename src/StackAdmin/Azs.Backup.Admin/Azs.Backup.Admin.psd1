@{
  GUID = '3c392cdf-a89a-43cf-aa6d-ea020a768e73'
  RootModule = 'Azs.Backup.Admin.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Backup.Admin.private.dll'
  FormatsToProcess = './Azs.Backup.Admin.format.ps1xml'
  CmdletsToExport = 'Get-AzsBackup', 'Get-AzsBackupLocation', 'New-AzsBackupLocationBackup', 'Restore-AzsBackup', 'Set-AzsBackupLocation', '*'
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
