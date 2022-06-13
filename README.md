# eBordo-desktop-mobile

eBordo setup:

1. Open bash
2. Clone repository

You need:

1. .NET Framework v4.6.2: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462
2. Flutter: https://docs.flutter.dev/get-started/install
3. Docker Desktop: https://www.docker.com/products/docker-desktop/
4. Visual Studio 2022: https://visualstudio.microsoft.com/vs/
5. Code editor like:
   Android Studio: https://developer.android.com/studio
   Visual Studio Code: https://code.visualstudio.com/
6. Windows terminal or some other bash: https://apps.microsoft.com/store/detail/windows-terminal/9N0DX20HK701?hl=hr-ba&gl=BA

API setup:

1. Open cloned repository in bash
2. Change directory to project root
3. Open Docker Desktop, and make sure that Docker engine started
4. Run command: docker-compose build
5. Run command: docker-compose up
6. Make sure that you can open http://localhost:5000/swagger/index.html in your browser

eBordo DESKTOP setup:

1. Open Visual studio solution eBordo.sln
2. Make sure that startup project is eBordo.WinUI
3. Go on Debug -> Start Without Debugging or only press Ctrl + F5 on keyboard

NOTES: If you have problems with Bunifu Licencing on build, you need to copy Bunifu.Licensing.dll (File is located in project root) in packages\Bunifu.UI.WinForms.5.2.3\lib\net40 and you can override with current .dll file.

eBordo MOBILE setup:

1. Open your MOBILE solution in some Code editor (ebordo_mobile)
2. Make sure that you launched some emulator
3. Run command: flutter pub get
4. Run command: flutter run

NOTES: With Visual Studio Code you can run mobile app like Windows application, it can be more easier and faster.

BEST platform for testing is Windows, so you can run it with Visual Studio Code!

Credentials:

Every user in DB have same template for username and password: username: name.surname@fksarajevo.ba
password: Test1234!

Examples:

ADMIN
username: haris.pandzic@fksarajevo.ba
password: Test1234!

PLAYER:
username: mersudin.ahmetovic@fksarajevo.ba
password: Test1234!

username: dal.varesanovic@fksarajevo.ba
password: Test1234!

COACH:
username: goran.sablic@fksarajevo.ba
password: Test1234!
