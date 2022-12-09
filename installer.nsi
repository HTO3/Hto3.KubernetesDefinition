# define the installer name
Name "Kubernetes Definition ${VERSION}"

# define name of installer
OutFile "Installer.exe"

# define installation directory
InstallDir "$PROFILE\AppData\Local\Programs\Kubernetes Definition"

# Set the execution level
RequestExecutionLevel user

# Registry key to check for directory (so if you install again, it will 
# overwrite the old one automatically)
InstallDirRegKey HKCU "Software\Kubernetes Definition" "Install_Dir"

# Set the best compressor
SetCompressor /SOLID lzma

Page license
Page instfiles

UninstPage uninstconfirm
UninstPage instfiles

ShowInstDetails show
ShowUninstDetails show

LicenseText "Kubernetes Definition"
LicenseData LICENSE

# start default section
Section
    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR
    
    # include all program files
    file *.exe
    file *.config
    file *.dll

    # get the size of this section
    SectionGetSize 0 $0

    # Write the installation path into the registry
    WriteRegStr HKCU "Software\Kubernetes Definition" "Install_Dir" "$INSTDIR"
  
    # Write the uninstall keys for Windows
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "DisplayIcon" "$INSTDIR\Hto3.KubernetesDefinition.UI.exe"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "DisplayName" "Kubernetes Definition"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "DisplayVersion" "${VERSION}"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "URLUpdateInfo" "https://github.com/HTO3/Hto3.KubernetesDefinition/releases"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "HelpLink" "https://github.com/HTO3/Hto3.KubernetesDefinition/issues"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "URLInfoAbout" "https://github.com/HTO3/Hto3.KubernetesDefinition"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "InstallLocation" "$INSTDIR"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "Publisher" "HTO3"
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "UninstallString" "$INSTDIR\Uninstall.exe"
    WriteRegDWORD HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "NoModify" 1
    WriteRegDWORD HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "NoRepair" 1
    WriteRegDWORD HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition" "EstimatedSize" "$0"

    # create the uninstaller
    WriteUninstaller "$INSTDIR\Uninstall.exe"

    # create a shortcut
    CreateShortcut "$SMPROGRAMS\Kubernetes Definition.lnk" "$INSTDIR\Hto3.KubernetesDefinition.UI.exe"
SectionEnd

# uninstaller section start
Section "uninstall"

    # Remove the link from the start menu
    Delete "$SMPROGRAMS\Kubernetes Definition.lnk"

    # Remove registry keys
    DeleteRegKey HKCU "Software\Microsoft\Windows\CurrentVersion\Uninstall\Kubernetes Definition"
    DeleteRegKey HKCU "Software\Kubernetes Definition"

    # Remove configuration files
    FindFirst $0 $1 $INSTDIR\..\..\Hto3\Hto3.KubernetesDefinition*
    loop:
      StrCmp $1 "" done

      RMDir /r $INSTDIR\..\..\Hto3\$1

      FindNext $0 $1
    Goto loop
    done:
    FindClose $0    
    RMDir "$INSTDIR\..\..\Hto3"

    # Remove the application dir
    RMDir /r $INSTDIR

SectionEnd