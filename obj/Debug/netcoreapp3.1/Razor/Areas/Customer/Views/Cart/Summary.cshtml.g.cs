#pragma checksum "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Customer\Views\Cart\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7543f674f648687042f2400258796dbe90fa89f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Summary), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
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
#line 1 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBookV5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBookV5.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7543f674f648687042f2400258796dbe90fa89f0", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950ad65521454702f3ebda2df3af50212212a362", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkyBookV5.Models.ViewModels.ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7543f674f648687042f2400258796dbe90fa89f03639", async() => {
                WriteLiteral(@"
    <br />
    <div class=""backgroundWhiteBorder"">
        <div class=""container"">
            <div class=""card"">
                <div class=""card-header bg-dark text-light ml-0 row container"">
                    <div class=""col-6"">
                        <i class=""fa fa-shopping-cart""></i> &nbsp;
                        Order Summary
                    </div>
                    <div class=""col-6 text-right"">
                        <a class=""btn btn-outline-info btn-sm"">Back to Cart</a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""container rounded p-2"">
                        <div class=""row"">
                            <div class=""col-12 col-lg-6 pb-4"">
                                <div class=""row"">
                                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                        <span class=""text-info"">PickUp Details:</span>
             ");
                WriteLiteral(@"                       </h4>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-3"">
                                        <label>Name</label>
                                    </div>
                                    <div class=""col-9"">
                                        <input type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-3"">
                                        <label>Phone</label>
                                    </div>
                                    <div class=""col-9"">
                                        <input type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
           ");
                WriteLiteral(@"                         <div class=""col-3"">
                                        <label>Street Address</label>
                                    </div>
                                    <div class=""col-9"">
                                        <input type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-3"">
                                        <label>City</label>
                                    </div>
                                    <div class=""col-9"">
                                        <input type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-3"">
                                        <label>State</label>
                    ");
                WriteLiteral(@"                </div>
                                    <div class=""col-9"">
                                        <input type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-3"">
                                        <label>Postal Code</label>
                                    </div>
                                    <div class=""col-9"">
                                        <input type=""text"" class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-12 col-lg-5 offset-lg-1"">
                                <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                    <span class=""text-info"">Order Summary:</span>
                                </");
                WriteLiteral(@"h4>
                                <ul class=""list-group mb-3"">
                                    <li class=""list-group-item d-flex justify-content-between"">
                                        <div>
                                            <h6 class=""my-0"">--TITLE--</h6>
                                            <small class=""text-muted"">Quantity: --COUNT--</small>
                                        </div>
                                        <span class=""text-muted"">$ --PRICE* COUNT--</span>
                                    </li>
                                    <li class=""list-group-item d-flex justify-content-between bg-light"">
                                        <small class=""text-info"">Total (USD)</small>
                                        <strong class=""text-info"">$--GRAND TOTAL--</strong>
                                    </li>
                                </ul>
                            </div>
                        </div>
                   ");
                WriteLiteral(@" </div>
                </div>
                <div class=""card-footer"">
                    <div class=""row"">
                        <div class=""col-12 col-md-8 pt-2"">
                            <p style=""color:maroon; font-size:14px;"">Estimate Arrival Date: ");
#nullable restore
#line 98 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                                       Write(DateTime.Now.AddDays(7).ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 98 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                                                                                      Write(DateTime.Now.AddDays(14).ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                        <div class=""col-12 col-md-4"">

                            <button type=""submit"" value=""Place Order"" class=""btn btn-success form-control"">Place Order</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkyBookV5.Models.ViewModels.ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
