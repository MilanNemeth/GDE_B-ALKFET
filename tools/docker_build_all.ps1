# set working directory to the script's directory
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $scriptDir
$src = Join-Path $scriptDir '..\source'

$tag = "latest"
$labelKey = "project"
$labelValue = "balkfet"

$rels = @(
    @{path = "WebUI/Dockerfile"; name = "balkfet-webui" },
    @{path = "WebApi/Dockerfile"; name = "balkfet-webapi" }
)

foreach ($rel in $rels) {
    docker build -f "$src/$($rel['path'])" `
        -t "$($rel['name']):$tag" `
        --label "$labelKey=$labelValue" "$src"
}
