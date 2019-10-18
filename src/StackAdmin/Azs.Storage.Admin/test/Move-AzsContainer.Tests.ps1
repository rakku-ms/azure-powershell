$TestRecordingFile = Join-Path $PSScriptRoot 'Move-AzsContainer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Move-AzsContainer' {
    It 'MigrateExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Migrate' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MigrateViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MigrateViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
