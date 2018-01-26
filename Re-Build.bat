@echo off

setlocal
echo.

rem detect latest msbuild tools
for %%v in (2.0, 3.5, 4.0, 12.0, 14.0, 15.0) do (
  for /f "usebackq tokens=2* delims= " %%c in (`reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\%%v" /v MSBuildToolsPath`) do (
    set msBuildExe=%%dMSBuild.exe
  )
)

rem remove bin dir
if exist bin\nul.ext rmdir /s /q bin\Release

rem 
echo Cleaning and Building ASML_Task.sln
call "%msBuildExe%" source\ASML_Task.sln /t:Clean "/p:Configuration=Release;Platform=Any CPU"
call "%msBuildExe%" source\ASML_Task.sln /t:Build "/p:Configuration=Release;Platform=Any CPU"
@IF %ERRORLEVEL% NEQ 0 PAUSE
