Imports System
Imports System.Runtime.InteropServices

''' <summary>
''' Class containing methods to retrieve specific file system paths.
''' </summary>
Public Module KnownFolders
    Private _knownFolderGuids As String() = New String() {"{56784854-C6CB-462B-8169-88E350ACB882}", "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", "{FDD39AD0-238F-46AF-ADB4-6C85480369C7}", "{374DE290-123F-4565-9164-39C4925E467B}", "{1777F761-68AD-4D8A-87BD-30B759FA33DD}", "{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}", "{4BD8D571-6D19-48D3-BE97-422220080E43}", "{33E28130-4E1E-4676-835A-98395C3BC3BB}", "{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}", "{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}", "{18989B1D-99B5-455B-841C-AB7C74E4DDFC}"} ' Contacts
    ' Desktop
    ' Documents
    ' Downloads
    ' Favorites
    ' Links
    ' Music
    ' Pictures
    ' SavedGames
    ' SavedSearches
    ' Videos

    Public Function GetPath(ByVal knownFolder As KnownFolder) As String
        Return GetPath(knownFolder, False)
    End Function

    Public Function GetPath(ByVal knownFolder As KnownFolder, ByVal defaultUser As Boolean) As String
        Return GetPath(knownFolder, KnownFolderFlags.DontVerify, defaultUser)
    End Function

    Private Function GetPath(ByVal knownFolder As KnownFolder, ByVal flags As KnownFolderFlags, ByVal defaultUser As Boolean) As String
        Dim outPath As IntPtr = Nothing
        Dim result As Integer = SHGetKnownFolderPath(New Guid(_knownFolderGuids(knownFolder)), flags, New IntPtr(If(defaultUser, -1, 0)), outPath)

        If result >= 0 Then
            Dim path As String = Marshal.PtrToStringUni(outPath)
            Marshal.FreeCoTaskMem(outPath)
            Return path
        Else
            Throw New ExternalException("Unable to retrieve the known folder path. It may not " & "be available on this system.", result)
        End If
    End Function

    <DllImport("Shell32.dll")>
    Private Function SHGetKnownFolderPath(
    <MarshalAs(UnmanagedType.LPStruct)> ByVal rfid As Guid, ByVal dwFlags As UInteger, ByVal hToken As IntPtr, <Out> ByRef ppszPath As IntPtr) As Integer
    End Function

    <Flags>
    Private Enum KnownFolderFlags As UInteger
        SimpleIDList = &H100
        NotParentRelative = &H200
        DefaultPath = &H400
        Init = &H800
        NoAlias = &H1000
        DontUnexpand = &H2000
        DontVerify = &H4000
        Create = &H8000
        NoAppcontainerRedirection = &H10000
        AliasOnly = &H80000000UI
    End Enum
End Module


''' <summary>
''' Standard folders registered with the system. These folders are installed with Windows Vista
''' and later operating systems, and a computer will have only folders appropriate to it
''' installed.
''' </summary>
Public Enum KnownFolder
    Contacts
    Desktop
    Documents
    Downloads
    Favorites
    Links
    Music
    Pictures
    SavedGames
    SavedSearches
    Videos
End Enum
