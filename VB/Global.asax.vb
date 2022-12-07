Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.SessionState
Imports System.Web.UI

Namespace Q505123
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Protected Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim page As Page = TryCast(HttpContext.Current.CurrentHandler, Page)
			If page IsNot Nothing Then
				AddHandler page.PreInit, AddressOf page_PreInit
			End If
		End Sub

		Private Sub page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
			Dim page As Page = TryCast(HttpContext.Current.CurrentHandler, Page)
			If page IsNot Nothing AndAlso page.Request.Cookies("theme") IsNot Nothing Then
				DevExpress.Web.ASPxWebControl.GlobalTheme = page.Request.Cookies("theme").Value
			End If
		End Sub
	End Class
End Namespace