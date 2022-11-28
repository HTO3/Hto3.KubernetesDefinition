# define name of installer
OutFile "Installer.exe"

# define installation directory
InstallDir "$PROFILE\AppData\Local\Programs\Kubernetes Definition"

# Set the execution level
RequestExecutionLevel user

# start default section
Section

    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR
    
    # include all program files
    file *.exe
    file *.config
    file *.dll

    # create the uninstaller
    WriteUninstaller "$INSTDIR\Uninstall.exe"

    # create a shortcut
    CreateShortcut "$SMPROGRAMS\Kubernetes Definition.lnk" "$INSTDIR\Hto3.KubernetesDefinition.UI.exe"
SectionEnd

# uninstaller section start
Section "uninstall"

    # Remove the link from the start menu
    Delete "$SMPROGRAMS\Kubernetes Definition.lnk"

    FindFirst $0 $1 $INSTDIR\..\..\Hto3\Hto3.KubernetesDefinition*
    loop:
      StrCmp $1 "" done

      RMDir /r $INSTDIR\..\..\Hto3\$1

      FindNext $0 $1
    Goto loop
    done:
    FindClose $0
    
    RMDir "$INSTDIR\..\..\Hto3"
    RMDir /r $INSTDIR

SectionEnd