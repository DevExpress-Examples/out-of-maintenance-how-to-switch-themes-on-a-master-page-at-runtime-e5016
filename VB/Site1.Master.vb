Imports Microsoft.VisualBasic
Imports DevExpress.Web.Internal
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Q505123
	Partial Public Class Site1
		Inherits System.Web.UI.MasterPage
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxComboBox1.DataSource = ThemesProvider.GetThemes()
			ASPxComboBox1.DataBind()
		End Sub

		Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
			' This event is not raised for the Master Page
		End Sub
	End Class
End Namespace