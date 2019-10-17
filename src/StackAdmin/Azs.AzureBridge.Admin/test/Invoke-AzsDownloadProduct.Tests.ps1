$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzsDownloadProduct.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-AzsDownloadProduct' {
    It 'Download' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DownloadViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
