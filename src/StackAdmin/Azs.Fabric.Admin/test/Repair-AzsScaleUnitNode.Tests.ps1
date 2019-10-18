$TestRecordingFile = Join-Path $PSScriptRoot 'Repair-AzsScaleUnitNode.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Repair-AzsScaleUnitNode' {
    It 'RepairExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Repair' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RepairViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RepairViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
