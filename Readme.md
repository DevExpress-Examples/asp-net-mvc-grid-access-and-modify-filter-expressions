<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [NorthwindDataProvider.cs](./CS/Models/NorthwindDataProvider.cs) (VB: [NorthwindDataProvider.vb](./VB/Models/NorthwindDataProvider.vb))
* [Product.cs](./CS/Models/Product.cs) (VB: [Product.vb](./VB/Models/Product.vb))
* **[GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - Access/modify FilterExpression on the controller and save/load custom filters
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t361413/)**
<!-- run online end -->


This example illustrates how to pass the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_FilterExpressiontopic">ASPxGridView.FilterExpression</a> property value between the Controller, View and client-side parts of an application. In particular, we can store custom filters in a separate <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9022">ListBox</a> extension.<br><br>The main implementation details are

* Pass the current <strong>FilterExpression</strong> value to the client side by handling the <strong>GridViewSettings.CustomJSProperties</strong> event (you can find a similar technique in the <a href="https://www.devexpress.com/Support/Center/p/E5121">E5121 - GridView - How to implement data editing with hidden column</a> code example).
* Pass the required <strong>FilterExpression</strong> value to the server side by calling the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMVCScriptsMVCxClientGridView_PerformCallbacktopic(2wupCg)">MVCxClientGridView.PerformCallback(Object)</a> method. Alternatively, you can use the approach from the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9941">Passing Values to a Controller Action through Callbacks</a> help section (e.g., see <a href="https://www.devexpress.com/Support/Center/p/T146962">T146962 - GridView - How to track ClientLayout with a separate ListBox</a>).
* Put the passed value to the <strong>ViewData</strong> dictionary to be able to intercept it in the View context and apply filter to GridView by handling the <strong>DataBound</strong> event.

<br/>


