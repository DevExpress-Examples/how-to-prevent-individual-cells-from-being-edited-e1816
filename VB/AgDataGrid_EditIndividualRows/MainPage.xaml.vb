Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace AgDataGrid_EditIndividualRows
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = ProductList.GetData()
		End Sub

		Private Sub grid_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			If grid.FocusedColumn.FieldName <> "UnitPrice" Then
				Return
			End If
			e.Cancel = CInt(Fix(grid.GetFocusedRowCellValue("Quantity"))) = 0
		End Sub
	End Class
End Namespace
