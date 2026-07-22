$assignmentPattern = '(?i)(api[_-]?key|client[_-]?secret|password|passwd|access[_-]?token)\s*[:=]\s*["''][^"''\s]{8,}'
$credentialPatterns = @(
    'AKIA[0-9A-Z]{16}',
    'gh[pousr]_[A-Za-z0-9]{36,}'
)

$findings = [System.Collections.Generic.List[string]]::new()
$excludedExtensions = @('.dll', '.exe', '.pdb', '.png', '.jpg', '.jpeg', '.gif', '.ico', '.zip', '.pdf')
$repositoryPath = (Get-Location).Path.Replace('\', '/')
$trackedFiles = @(git -c "safe.directory=$repositoryPath" ls-files)

if ($LASTEXITCODE -ne 0) {
    throw 'Git could not list the tracked files.'
}

foreach ($file in $trackedFiles) {
    if ($file -eq 'scripts/verify-secrets.ps1') {
        continue
    }

    if ($excludedExtensions -contains [IO.Path]::GetExtension($file).ToLowerInvariant()) {
        continue
    }

    $content = Get-Content -LiteralPath $file -Raw -ErrorAction SilentlyContinue
    if ($null -eq $content) {
        continue
    }

    if ($content -match $assignmentPattern) {
        $findings.Add("${file}: possible assigned secret")
    }

    foreach ($pattern in $credentialPatterns) {
        if ($content -match $pattern) {
            $findings.Add("${file}: possible credential pattern")
            break
        }
    }
}

if ($findings.Count -gt 0) {
    $findings | ForEach-Object { Write-Error $_ }
    throw 'Potential secrets were found in tracked files.'
}

Write-Host 'No common secret patterns were found in tracked files.'
