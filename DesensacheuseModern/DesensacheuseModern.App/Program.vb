Imports System
Imports System.Windows.Forms
Imports DesensacheuseModern.Services
Imports DesensacheuseModern.UI

Namespace DesensacheuseModern
    Module Program
        <STAThread>
        Sub Main()
            Application.SetHighDpiMode(HighDpiMode.SystemAware)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Dim repository As New FormuleRepository()
            Dim logger As New ProductionLogger()
            Application.Run(New ScanForm(repository, logger))
        End Sub
    End Module
End Namespace
