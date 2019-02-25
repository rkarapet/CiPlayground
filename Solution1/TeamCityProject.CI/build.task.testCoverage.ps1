Include ".\build.config.ps1"

Task -name TestCoverage -action {
    Write-Host ""
    TestDlls
    Write-Host ""
}

Function TestDlls {
    Write-Host "`tConsoleApp.Tests.dll:"
    Write-Host ""
    $cmd = -join ("&'$dotCover' cover", 
        " /TargetExecutable='$vsTest'", 
        " /TargetArguments='..\.build\ConsoleApp.Tests.dll ..\.build\ClassLibrary.Tests.dll'", 
        " /Output='..\.build\AppCoverageReport.html'",
        " /ReportType='HTML'") 
    
    Invoke-Expression $cmd
    Write-Host ""
}