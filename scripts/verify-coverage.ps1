param(
    [Parameter(Mandatory = $true)]
    [string]$Path,

    [double]$MinimumLineRate = 40
)

$coverageFile = Get-ChildItem -LiteralPath $Path -Recurse -Filter coverage.cobertura.xml |
    Sort-Object LastWriteTime -Descending |
    Select-Object -First 1

if ($null -eq $coverageFile) {
    throw "No coverage.cobertura.xml file was found under '$Path'."
}

$coverage = [xml](Get-Content -LiteralPath $coverageFile.FullName -Raw)
$lineRateText = $coverage.coverage.GetAttribute("line-rate")
$lineRate = [double]::Parse($lineRateText, [Globalization.CultureInfo]::InvariantCulture) * 100

Write-Host ("Line coverage: {0:N2}% (minimum: {1:N2}%)" -f $lineRate, $MinimumLineRate)

if ($lineRate -lt $MinimumLineRate) {
    throw ("Line coverage {0:N2}% is below the required {1:N2}%." -f $lineRate, $MinimumLineRate)
}
