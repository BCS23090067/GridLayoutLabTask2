\# GridLayoutLabTask2 - Puppy Adoption App



A .NET MAUI application for puppy adoption built with .NET 8.0.



\## Requirements

\- Visual Studio 2022 with .NET MAUI workload

\- Windows 10/11

\- Windows App Runtime (will be prompted to install if missing)



\## How to Run



\### Option 1: Visual Studio

1\. Open `GridLayoutLabTask2.sln` in Visual Studio 2022

2\. Press F5 to run



\### Option 2: Command Line

```bash

dotnet restore

dotnet build -f net8.0-windows10.0.19041.0

dotnet build -t:Run -f net8.0-windows10.0.19041.0

```



\### If you get "Class not registered" error:

Install Windows App Runtime:

```bash

dotnet workload install maui-windows

```



\## Features

\- Displays puppy adoption information

\- Includes owner details

\- Shows location and adoption button



\## Author

BCS23090067

