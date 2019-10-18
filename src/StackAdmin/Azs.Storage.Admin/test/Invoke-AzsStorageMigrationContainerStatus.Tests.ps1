$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzsStorageMigrationContainerStatus.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-AzsStorageMigrationContainerStatus' {
    It 'Migration' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MigrationViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
