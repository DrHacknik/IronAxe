@echo off

set /p profile=<profile.txt
set appdata=%CD%\data\profiles\%profile%
set COMMONPROGRAMFILES(X86)=%CD%\bin\commonfiles
start "" "%CD%\bin\minecraft.jar