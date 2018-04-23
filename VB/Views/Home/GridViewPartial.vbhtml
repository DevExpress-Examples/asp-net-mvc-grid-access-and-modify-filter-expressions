@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "ProductID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.CustomActionRouteValues = New With {.Controller = "Home", .Action = "GridViewCustomActionPartial"}
            settings.Columns.Add(Sub(column)
                                         column.FieldName = "ProductID"
                                         column.ReadOnly = True
                                         column.EditFormSettings.Visible = DefaultBoolean.False
                                 End Sub)

            settings.Columns.Add("ProductName")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("UnitsOnOrder")
            settings.Settings.ShowFilterRow = True
            settings.CustomJSProperties = Sub(s, e) e.Properties.Add("cpFilterExpression", CType(s, ASPxGridView).FilterExpression)

            settings.DataBound = Sub(s, e)
                                         If (ViewData("filterExpression") IsNot Nothing) Then
                                             CType(s, ASPxGridView).FilterExpression = ViewData("filterExpression").ToString()
                                         End If
                                 End Sub
            
    End Sub).Bind(Model).GetHtml()