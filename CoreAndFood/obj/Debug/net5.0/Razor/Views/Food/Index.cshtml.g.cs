#pragma checksum "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "548803ee131ed430850539784d5fdc9ab0fe3f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548803ee131ed430850539784d5fdc9ab0fe3f3e", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Leyout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Food List</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>Id</th>
        <th>Food Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>CategoryName</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
    </tr>

");
#nullable restore
#line 24 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 27 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.FoodId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 702, 2);
            WriteAttributeValue("", 676, "/Food/DeleteFood/", 676, 17, true);
#nullable restore
#line 32 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 693, x.FoodId, 693, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 754, "\"", 784, 2);
            WriteAttributeValue("", 761, "/Food/FoodGet/", 761, 14, true);
#nullable restore
#line 33 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 775, x.FoodId, 775, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n    <td><a href=\"#\" class=\"btn btn-info\" >Details</a></td>\r\n</tr>\r\n");
#nullable restore
#line 36 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 40 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Food/AddFood/\" class=\"btn btn-primary\">New Food</a>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591