@echo off
title PORTABLE MINECRAFT LAUNCHER
set nag=BE SURE TO TURN CAPS LOCK OFF! (never said it was on just make sure)
goto TOP
:FOLDERCHECK
if not exist %CD%\bin mkdir %CD%\bin
if not exist %CD%\data\profiles mkdir %CD%\data\profiles
IF ERRORLEVEL 1 (goto :error_main) 
goto FILECHECK

:FILECHECK
if not exist %CD%\bin\minecraft.jar goto DOWNLOADMINECRAFT
if not exist %CD%\data\.minecraft\launcher.pack.lzma set nag=COPY %APPDATA%\.minecraft TO %CD%\data IF YOU HAVE EXISTING SAVEDATA AND THEN LAUNCH DEFAULT PROFILE
IF ERRORLEVEL 1 (goto :error_debug) 

:TOP 
cls
::mode con cols=85 lines=54
color 1f
title PORTABLE MINECRAFT LAUNCHER - NOTES
echo ==========================
echo Script by MarioMasta64 and Dr.Hacknik (C) 2017
echo --------------------------
echo Script Version: 1.0.5 [DEBUG_BUILD] 
echo ==========================
echo This Script is licensed-
echo -under the Open GNU GPL Open-Source License. 
echo You may Modify this or the Software, as long
echo as you include a copy of the License, and give 
echo credit to the Original Creator.
pause
goto :AGREEMENT


:ERROR
title PORTABLE MINECRAFT LAUNCHER - ERROR
cls
color 4f
echo There has been an error! 
echo ===========================
echo It seems that we couldn't use the function that you asked for.
echo Please make sure that you have a working Internet connection.
pause
goto :MENU

:ERROR_MAIN
title PORTABLE MINECRAFT LAUNCHER - ERROR
cls
color 4f
echo There has been an error! 
echo ===========================
echo It seems that we couldn't use the function that you asked for.
echo Please make sure that you have a working Internet connection.
pause
goto :AGREEMENT

:ERROR_DEBUG
title PORTABLE MINECRAFT LAUNCHER - ERROR
cls
color 4f
echo There has been an error! 
echo ===========================
echo It seems that we couldn't use the function that you asked for.
echo Please make sure that you have a working Internet connection.
pause
goto :DEBUGTOOLS

:NOINPUT
cls
color 4f
echo Please Input an option! Or the option is invalid!
echo Either that was the case, or an error has occurred. 
pause
goto :MENU

:AGREEMENT

title PORTABLE MINECRAFT LAUNCHER - AGREEMENT
cls
color 1f
::SET FILENAME=%~nx0 //this returns the name of the batch file running (doesn't work when packaged in an exe)
::SET PATHNAME=%0 //this returns the filename but also with absolute path

set warning=
echo                                 Minecraft Portable Script
echo                                     by MarioMasta64
echo                                     and Dr.Hacknik
echo			================================================== 
echo			=      Script by MarioMasta64 and Dr.Hacknik     = 
echo			=          Script Version: v1.0.6-alpha          = 
echo			================================================== 
echo			=You may Modify this WITH consent of the original= 
echo			= creator, as long as you include a copy of this = 
echo			=      as you include a copy of the License      = 
echo			================================================== 
echo			=    You may also modify this script without     = 
echo			=        consent for PERSONAL USE ONLY           = 
echo			================================================== 
echo.
echo.
echo.


set /p warning= Type Yes if you Agree; or Press any key to exit:  

if /i "%warning%" EQU "Yes" goto:FOLDERCHECK
if /i "%warning%" EQU "DEBUG_MODE" goto:DEBUG
echo.
echo                                Exiting the Script...
Exit

:SAVESETTINGS
::if exist Common\dev_settings.bat -ls!"AGREEDVERSION=" -write -yes
::echo set AGREEDVERSION=%currentversion%>> Common\dev_settings.bat
goto :MENU


:WGETUPDATE
wget https://eternallybored.org/misc/wget/current/wget.exe
move wget.exe %CD%\bin\
if errorlevel 1 ()
if exist %CD%\bin\wget.exe.1 goto WGETREPLACE
IF ERRORLEVEL 1 (goto :ERROR) 
goto WGETREPLACE

:WGETREPLACE
del %CD%\bin\wget.exe
ren %CD%\bin\wget.exe.1 %CD%\bin\wget.exe
IF ERRORLEVEL 1 (goto :error) 
goto MENU

:DOWNLOADMINECRAFT
cls
if not exist %CD%\bin\wget.exe goto DOWNLOADWGET_RES
%CD%\bin\wget.exe http://s3.amazonaws.com/Minecraft.Download/launcher/Launcher.jar
move %CD%\Launcher.jar %CD%\bin
IF ERRORLEVEL 1 (goto :error) 
goto FILECHECK

:DOWNLOADMINECRAFT_RES
cls
if not exist %CD%\bin\wget.exe goto DOWNLOADWGET
%CD%\bin\wget.exe http://s3.amazonaws.com/Minecraft.Download/launcher/Launcher.jar
move %CD%\Launcher.jar %CD%\bin
IF ERRORLEVEL 1 (goto :error_debug) 
goto FILECHECK

:DOWNLOADWGET
IF ERRORLEVEL 1 (goto :error_main) 

:DOWNLOADWGET_RES
IF ERRORLEVEL 1 (goto :error_debug) 

:CHECKWGETDOWNLOADER
if exist %CD%\bin\downloadwget.vbs goto EXECUTEWGETDOWNLOADER

:CREATEWGETDOWNLOADER
echo ' Set your settings > %CD%\bin\downloadwget.vbs
echo    strFileURL = "https://eternallybored.org/misc/wget/current/wget.exe" >> %CD%\bin\downloadwget.vbs
echo    strHDLocation = "wget.exe" >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo ' Fetch the file >> %CD%\bin\downloadwget.vbs
echo     Set objXMLHTTP = CreateObject("MSXML2.XMLHTTP") >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo     objXMLHTTP.open "GET", strFileURL, false >> %CD%\bin\downloadwget.vbs
echo     objXMLHTTP.send() >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo If objXMLHTTP.Status = 200 Then >> %CD%\bin\downloadwget.vbs
echo Set objADOStream = CreateObject("ADODB.Stream") >> %CD%\bin\downloadwget.vbs
echo objADOStream.Open >> %CD%\bin\downloadwget.vbs
echo objADOStream.Type = 1 'adTypeBinary >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo objADOStream.Write objXMLHTTP.ResponseBody >> %CD%\bin\downloadwget.vbs
echo objADOStream.Position = 0    'Set the stream position to the start >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo Set objFSO = Createobject("Scripting.FileSystemObject") >> %CD%\bin\downloadwget.vbs
echo If objFSO.Fileexists(strHDLocation) Then objFSO.DeleteFile strHDLocation >> %CD%\bin\downloadwget.vbs
echo Set objFSO = Nothing >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo objADOStream.SaveToFile strHDLocation >> %CD%\bin\downloadwget.vbs
echo objADOStream.Close >> %CD%\bin\downloadwget.vbs
echo Set objADOStream = Nothing >> %CD%\bin\downloadwget.vbs
echo End if >> %CD%\bin\downloadwget.vbs
echo. >> %CD%\bin\downloadwget.vbs
echo Set objXMLHTTP = Nothing >> %CD%\bin\downloadwget.vbs

:EXECUTEWGETDOWNLOADER
cscript.exe %CD%\bin\downloadwget.vbs
move wget.exe %CD%\bin\
goto DOWNLOADMINECRAFT

:DEBUG 
title PORTABLE MINECRAFT LAUNCHER - MAIN MENU [DEBUG] 
cls
color 1f
echo %NAG%
set nag=SELECTION TIME!
echo ===================
echo 1. New profile
echo 2. Default profile
echo 3. Launch profile
echo 4. Delete profile
echo 5. Update
echo 6. Exit
echo 7. Debug Tools
echo ===================
set /p choice="Enter a number and press enter to confirm: "
if %choice%==1 goto NEW
if %choice%==2 goto DEFAULT
if %choice%==3 goto SELECT
if %choice%==4 goto DELETE
if %choice%==4 goto UPDATE
if %choice%==6 goto END
if %choice%==7 goto DEBUGTOOLS
IF ERRORLEVEL 1 (goto :ERROR) 
goto NOINPUT

:DEBUGTOOLS
title PORTABLE MINECRAFT LAUNCHER - DEBUG_TOOLS
cls
echo ===================
echo 1. Restart Script
echo 2. Download wget
echo 3. Launch Minecraft [JAVA]
echo 4. Download Resources
echo 5. Return to the Menu
echo ===================
set /p choice="Enter a number and press enter to confirm: "
if %choice%==1 goto FOLDERCHECK
if %choice%==2 goto WGETUPDATE
if %choice%==3 goto JAVALAUNCH__RES
if %choice%==4 goto DOWNLOADMINECRAFT_RES
if %choice%==5 goto DEBUG
IF ERRORLEVEL 1 (goto :ERROR_DEBUG) 
goto NOINPUT

:MENU
title PORTABLE MINECRAFT LAUNCHER - MAIN MENU
cls
color 1f
echo %NAG%
set nag=SELECTION TIME!
echo ===================
echo 1. New profile
echo 2. Default profile
echo 3. Launch profile
echo 4. Delete profile
echo 5. Update
echo 6. Exit
echo ===================
set /p choice="Enter a number and press enter to confirm: "
if %choice%==1 goto NEW
if %choice%==2 goto DEFAULT
if %choice%==3 goto SELECT
if %choice%==4 goto DELETE
if %choice%==4 goto UPDATE
if %choice%==6 goto END
goto NOINPUT

:NEW
title PORTABLE MINECRAFT LAUNCHER - NEW PROFILE
cls
echo %NAG%
set nag=SELECTION TIME!
echo Type the name of the profile
echo only use letters and numbers
echo type menu to return to the main menu
set /p profile="enter a name for the new profile: "
if %profile%==menu goto MENU
if exist %CD%\data\%profile% then goto EXIST
goto CREATE

:CREATE
title PORTABLE MINECRAFT LAUNCHER - CREATE PROFILE
cls
echo %NAG%
set nag=SELECTION TIME!
echo create profile "%PROFILE%"?
echo type yes or no and press enter
set /p choice="choice: "
if %choice%==no goto NEWTITLE
if %choice%==yes goto NOWCREATING
set nag="please enter YES or NO"
goto CREATE

:NOWCREATING
cls
if exist %CD%\data\profiles\%PROFILE% goto EXISTS
mkdir %CD%\data\profiles\%PROFILE%
if exist %CD%\data\profiles\%PROFILE% goto LAUNCH
set LEGITCHECK="INVALID NAME"
goto NEW

:EXISTS
title PORTABLE MINECRAFT LAUNCHER - LAUNCH PROFILE
cls
echo %NAG%
set nag=SELECTION TIME!
echo PROFILE "%PROFILE%" EXISTS
echo launch it?
echo type yes or no and press enter
set /p choice="choice: "
if %choice%==no goto NEWTITLE
if %choice%==yes goto LAUNCH
set nag="please enter YES or NO"
goto EXISTS

:NEWTITLE
cls
set nag="ENTER A DIFFERENT TITLE THEN"
goto NEW

:SELECT
title PORTABLE MINECRAFT LAUNCHER - SELECT PROFILE
cls
echo %NAG%
set nag=SELECTION TIME!
echo type the name of the profile
echo only use letters and numbers
echo type menu to return to the main menu
set /p profile="enter a name for the profile to launch: "
set appdata=%CD%\data\profiles\%PROFILE%
if %PROFILE%==default goto DEFAULT
if %profile%==menu goto MENU
if exist %CD%\data\profiles\%PROFILE% goto LAUNCH
set nag=PROFILE "%profile%" DOES NOT EXISTS
goto CREATE
goto ERROR

:LAUNCH
cls
set APPDATA=%CD%\data\profiles\%PROFILE%
goto oscheck

:DEFAULT
cls
set APPDATA=%CD%\data
goto OSCHECK

:DELETE
title PORTABLE MINECRAFT LAUNCHER - DELETE PROFILE
cls
echo %NAG%
set nag=SELECTION TIME!
echo type the name of the profile to delete
echo default for default profile
echo type menu to return to the main menu
set /p profile="enter a name for the profile you wish to delete: "
if exist %CD%\data\profiles\%PROFILE% goto NOWDELETING
if %profile%==menu goto MENU
if %profile%==default goto DELETEMAIN
set nag=PROFILE %profile% DOES NOT EXIST
goto DELETE

:NOWDELETING
cls
rmdir /s %CD%\data\profiles\%PROFILE%
goto MENU

:DELETEMAIN
cls
DEL README.TXT
ECHO TO PROTECT MY SAVES I MADE THIS THE HARDEST OPTION TO DO. PLEASE LEAVE THE COMPUTER. > README.TXT
COPY README.TXT %CD%\data\README.TXT
START NOTEPAD.EXE README.TXT
GOTO MENU

:OSCHECK
title PORTABLE MINECRAFT LAUNCHER - JAVA
cls
echo type y for system or anything else for portable java
echo press enter afterwards
set /p choice="choice: "
if %choice%==y goto JAVALAUNCH
goto JAVACHECK
goto ERROR

:JAVALAUNCH
cls
start %CD%\bin\Launcher.jar
IF ERRORLEVEL 1 (goto :ERROR) 
goto end

:JAVALAUNCH_RES
cls
start %CD%\bin\Launcher.jar
IF ERRORLEVEL 1 (goto :ERROR_DEBUG) 
goto :DEBUGTOOLS

:JAVACHECK
cls
if not exist %CD%\bin\commonfiles\java\bin\javaw.exe goto JAVAINSTALLERCHECK
start "" "%CD%\bin\commonfiles\java\bin\javaw.exe" -jar "%CD%\bin\Launcher.jar
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

:DOWNLOADJAVA
cls
%CD%\bin\wget.exe http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe
IF ERRORLEVEL 1 (goto :ERROR) 
goto JAVAINSTALLERCHECK

:UPDATE


:END