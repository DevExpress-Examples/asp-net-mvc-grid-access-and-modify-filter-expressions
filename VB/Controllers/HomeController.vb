Imports System.Web.Mvc

Namespace GridViewCustomFiltersMvc
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(NorthwindDataProvider.GetProducts())
		End Function

		Public Function GridViewCustomActionPartial(ByVal filterExpression As String) As ActionResult
			ViewData("filterExpression") = filterExpression
			Return PartialView("GridViewPartial", NorthwindDataProvider.GetProducts())
		End Function
	End Class
End Namespace