#define MyAppName "ContactsApp"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Zorin Daniil"
#define MyAppURL "https://github.com/SirDTor/ContactsApp"
#define MyAppExeName "ContactsApp.View.exe"

[Setup]
AppId={{1EE29FB6-D543-4620-B75A-155B55001031}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
LicenseFile=..\LICENSE
OutputDir=..\install\output
OutputBaseFilename=ContactsApp
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; Исполняемый файл
Source: "..\src\ContactsApp\ContactsApp.View\bin\Release\ContactsApp.View.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: "..\src\ContactsApp\ContactsApp.View\bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#"ContactsApp.View.exe"}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#"ContactsApp.View.exe"}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

