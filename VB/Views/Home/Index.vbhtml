<script type="text/javascript">
    function OnClick(s, e) {
        if (GridView.cpFilterExpression)
            lbFilters.AddItem(GridView.cpFilterExpression);
    }
    function OnSelectedIndexChanged(s, e) {
        GridView.PerformCallback({ filterExpression: lbFilters.GetSelectedItem().text });
    }
</script>

@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "btnSave"
            settings.Text = "Save Current Filter"
            settings.ClientSideEvents.Click = "OnClick"
    End Sub).GetHtml()

@Html.DevExpress().ListBox( _
    Sub(settings)
            settings.Name = "lbFilters"
            settings.Width = Unit.Pixel(500)
            settings.Properties.EnableClientSideAPI = True
            settings.Properties.ClientSideEvents.SelectedIndexChanged = "OnSelectedIndexChanged"
    End Sub).GetHtml()

@Html.Action("GridViewPartial")