echo "Building dotnet project dependencies"
cd ./Core
dotnet restore
cd ../Integration.EntityFramework
dotnet restore
cd ../Test.Unit
dotnet restore
cd ../UI
dotnet restore
echo "All dependencies built"
echo "Project ready...run 'dotnet run' in UI project to launch"
