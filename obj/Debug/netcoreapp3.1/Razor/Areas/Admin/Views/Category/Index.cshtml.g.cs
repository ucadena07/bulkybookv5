#pragma checksum "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b17e70c69b66dcad92b6bafd7a2a5697b9be07d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\_ViewImports.cshtml"
using BulkyBookV5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\_ViewImports.cshtml"
using BulkyBookV5.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b17e70c69b66dcad92b6bafd7a2a5697b9be07d", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950ad65521454702f3ebda2df3af50212212a362", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div class=""row"">
    <div class=""col-6"">
        <h2 class=""text-primary"">Category List </h2>
    </div>
    <div class=""col-6 text-right"">
        <a class=""btn btn-primary""><i class=""fas fa-plus""></i> &nbsp; Create New Category</a>
    </div>
</div>

<br />
<div class=""p-4 border rounded"">
    <table id=""tblData"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead class=""thead-dark"">
            <tr class=""table-info"">
                <th>Name</th>
                <th></th>
            </tr>
        </thead>
    </table>
</div>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
