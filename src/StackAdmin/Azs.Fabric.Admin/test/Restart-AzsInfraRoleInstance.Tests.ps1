$TestRecordingFile = Join-Path $PSScriptRoot 'Restart-AzsInfraRoleInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restart-AzsInfraRoleInstance' {
    It 'Reboot' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RebootViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
