@echo off
Color 1A

echo Press enter to pull (get the latest version)
pause

Color 1c

@echo on
git pull
@echo off

Color 1A
echo/
echo/
echo ++++++++++++++++++++++++++++++++++++++++++++
echo [INFO] : Add your art now then press enter.
echo ++++++++++++++++++++++++++++++++++++++++++++
echo/
echo/
echo [INFO] : If you just wanted to update your git folder
echo [INFO] : you can close the application now. 
echo/
set /p message="[Commit Message] : "

color 1c

@echo on
git add Assets/Art
git commit -m "%message%"
git push -u
@echo off

Color 1A


echo [INFO] : Done Press "ENTER" to quit
pause >> null
