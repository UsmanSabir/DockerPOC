@ECHO OFF
docker-compose up -d
ECHO Running... Press any key to stop
pause
docker-compose down
cls
