$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzsScaleUnitOut.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-AzsScaleUnitOut' {
    It 'ScaleExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Scale' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ScaleViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ScaleViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
