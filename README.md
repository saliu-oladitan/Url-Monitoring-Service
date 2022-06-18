Url Monitoring System
It is a Windows Service created using Worker Service for monitoring a URL/URLs if they are ONLINE OR NOT. The service logs the results into a file at a specified interval and runs in the background.

Use this to install the windows service

New-Service -Name {SERVICE NAME} -BinaryPathName {EXE FILE PATH} -Description "{DESCRIPTION}" -DisplayName "{DISPLAY NAME}" -StartupType Automatic

Note: Your Visual Studio should be started as an admin to enable remote calls (ti URLs).
