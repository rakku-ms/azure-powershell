$TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzsInfraRoleInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Start-AzsInfraRoleInstance' {
    It 'PowerOn' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PowerOnViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
