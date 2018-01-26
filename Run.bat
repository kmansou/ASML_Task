@echo off

setlocal
echo.

set fileExists=0

IF exist bin\Runner.exe (
	set fileExists=1
)

IF %fileExists%==1 (
	goto run
)

IF %fileExists%==0 (
	echo Runner.exe doesn't exist.Press CTRL-C now to abort, Enter to build and run.
	set /p yesno=.
	call Re-Build.bat
	goto run
)

:run
start /d "bin" Runner.exe
goto end

:end
echo.
if "%direct%" == "0" pause
endlocal