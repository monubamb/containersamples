FROM microsoft/windowsservercore
ADD /ConsoleApp3/bin/Debug /
ENTRYPOINT ConsoleApp3.exe
