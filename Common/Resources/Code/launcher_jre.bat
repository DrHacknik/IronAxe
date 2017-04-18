@echo off

:LAUNCH
cls
set APPDATA=%CD%\data\profiles\%PROFILE%
goto oscheck

:OSCHECK
title PORTABLE MINECRAFT LAUNCHER - JAVA
cls
echo type y for system or anything else for portable java
echo press enter afterwards
set /p choice="choice: "
if %choice%==y goto JAVALAUNCH
goto JAVACHECK

:JAVALAUNCH
cls
start %CD%\bin\Minecraft.jar
goto END

:JAVACHECK
cls
if not exist %CD%\bin\commonfiles\java\bin\javaw.exe goto JAVAINSTALLERCHECK
start "" "%CD%\bin\commonfiles\java\bin\javaw.exe" -jar "%CD%\bin\Minecraft.jar
goto END

:JAVAINSTALLERCHECK
cls
if not exist jPortable_8_Update_121.paf.exe goto DOWNLOADJAVA
start jPortable_8_Update_121.paf.exe
title READMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADMEREADME
echo INSTALL JAVA TO %CD%\bin\commonfiles\Java AND PRESS ENTER TO CONTINUE
pause
del jPortable_8_Update_121.paf.exe
goto JAVACHECK

:END 
Exit 