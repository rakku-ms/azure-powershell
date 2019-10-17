$TestRecordingFile = Join-Path $PSScriptRoot 'Repair-AzsAlert.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Repair-AzsAlert' {
    It 'Repair' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RepairViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
