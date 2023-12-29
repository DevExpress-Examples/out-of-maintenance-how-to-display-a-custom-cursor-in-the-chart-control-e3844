<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/SilverlightApplication1/MainPage.xaml) (VB: [MainPage.xaml](./VB/SilverlightApplication1/MainPage.xaml))
* [MainPage.xaml.cs](./CS/SilverlightApplication1/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/SilverlightApplication1/MainPage.xaml.vb))
<!-- default file list end -->
# How to display a custom cursor in the chart control


<p>This example shows how to display a custom cursor when the mouse pointer is hovering over the chart control. </p><br />



<h3>Description</h3>

<p>To accomplish this task, handle the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfChartsChartControl_QueryChartCursortopic"><u>ChartControl.QueryChartCursor</u></a>  event and assign your custom image (e.g., a <strong>BitmapImage </strong>object loaded from application resources) to the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfChartsQueryChartCursorEventArgs_CursorImagetopic"><u>QueryChartCursorEventArgs.CursorImage</u></a>   property.</p><p>Note that you need to include your image in the project and set the  <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfChartsQueryChartCursorEventArgs_Cursortopic"><u>QueryChartCursorEventArgs.Cursor</u></a>  property to <strong>None </strong>to see the custom image in the chart control. </p><br />


<br/>


