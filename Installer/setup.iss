#define MyAppName "ConvertPro"
#define MyAppVersion "1.5.0"
#define MyAppPublisher "WR Soft Serviços, Inc."
#define MyAppExeName "ConvertPro.exe"

[Setup]
AppId={{59292DF2-0813-4235-A96F-95AA5528051D}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
SetupIconFile=Resources\ConvertPro.ico

ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible

Compression=lzma2
SolidCompression=yes
WizardStyle=modern
DisableProgramGroupPage=yes

OutputDir=Output
OutputBaseFilename=ConvertPro_Setup_{#MyAppVersion}

PrivilegesRequired=admin

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; \
Description: "{cm:CreateDesktopIcon}"; \
GroupDescription: "{cm:AdditionalIcons}"; \
Flags: unchecked

[Files]
; === APP (SELF-CONTAINED) ===
Source: "bin\Release\net10.0-windows\win-x64\publish\*"; \
DestDir: "{app}"; \
Flags: recursesubdirs createallsubdirs ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; \
Description: "Executar {#MyAppName}"; \
Flags: nowait postinstall skipifsilent
