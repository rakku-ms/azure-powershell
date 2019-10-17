$TestRecordingFile = Join-Path $PSScriptRoot 'Close-AzsAlert.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Close-AzsAlert' {
    It 'CloseExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CloseViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Close' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CloseViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
