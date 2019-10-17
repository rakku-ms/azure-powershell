@{
  GUID = 'ebf4f46b-ea45-4ac5-b2b5-6ed8ea259941'
  RootModule = 'Azs.AzureBridge.Admin.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = 'Azure Bridge Admin module'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.AzureBridge.Admin.private.dll'
  FormatsToProcess = './Azs.AzureBridge.Admin.format.ps1xml'
  CmdletsToExport = 'Get-AzsActivation', 'Get-AzsDownloadedProduct', 'Get-AzsProduct', 'Invoke-AzsDownloadProduct', 'New-AzsActivation', 'Remove-AzsActivation', 'Remove-AzsDownloadedProduct', 'Set-AzsActivation', '*'
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
