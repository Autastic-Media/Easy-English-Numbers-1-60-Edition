Imports System.IO
Imports System.Reflection
Imports System.Version

Namespace Security
    Public Class Globals

        'Path where the licence will be saved
        '''Public Shared LicencePath As String = Application.StartupPath
        Public Shared LicencePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), My.Application.Info.CompanyName, Assembly.GetCallingAssembly().GetName().Name)

        'Full path to the licence file
        Public Shared LicenceFile As String = Path.Combine(LicencePath, "licence.lic")

        'Computer name
        Public Shared ComputerName As String = Environment.MachineName

        'List of valid licence keys
        Public Shared LicenceKeys As New List(Of String)(
            New String() {
            "Gent",
            "cKG5-3I2-YAK3-NsWV-u0N8",
            "FMUO-F3BB-5NWD-CbIX-RPUP",
            "1C1T-I32D-WBMR-S5K0-Ms6x",
            "yI1A-1epf-C7z9-V5HE-pWcE",
            "29sV-TDP3-XY9-NClO-lKM8",
            "PpLa-Wxmx-NO1b-wWW9-WVL6",
            "5DDY-6R85-WAX4-1I69-4LV",
            "F4N0-W2v1-GT7f-ktbl-OYU6",
            "FWAP-2SKH-XAAM-L7wd-h9AR",
            "05oP-3CYT-7LAo-V43l-2YYI",
            "aLb-4No-4VW2-3TV5-8Cbj",
            "y982-JYZh-MRKM-J5oC-1RHG",
            "YB1R-6NA-p0Bt-VAaX-9mZ3",
            "O8eS-RZDi-pEAN-IWIG-OJT0",
            "5ny8-p5mM-DNGP-4NU5-hocL",
            "T4Hg-Ig11-PRsy-WeM0-zVvD",
            "5WM6-v27P-7lOU-hAnb-10x3",
            "03dx-2F8m-8eE6-Ub34-lAgg",
            "kDWT-IuJ9-O1J2-OuUH-jS55",
            "6UmL-5A7G-K6C-xaZ2-kXoR"})

    End Class
End Namespace
