Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System
Imports System.Windows.Input
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Charts

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_QueryChartCursor(ByVal sender As Object, ByVal e As QueryChartCursorEventArgs)
			e.Cursor = Cursors.None
			e.CursorImage = New BitmapImage(New Uri("/SilverlightApplication1;component/mycursor.png", UriKind.Relative))
		End Sub

	End Class
End Namespace
