#pragma checksum "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867f19cc51af931925d93e43dc5596da4d1a60e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Details.cshtml")]
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
#nullable restore
#line 2 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\Order\Details.cshtml"
using BulkyBookV5.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867f19cc51af931925d93e43dc5596da4d1a60e7", @"/Areas/Admin/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950ad65521454702f3ebda2df3af50212212a362", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkyBookV5.Models.ViewModels.OrderDetailsVM>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867f19cc51af931925d93e43dc5596da4d1a60e73986", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "867f19cc51af931925d93e43dc5596da4d1a60e74248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 6 "C:\Users\ucade\Documents\MVC\Tutorial\BulkyBookV5\Areas\Admin\Views\Order\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <br />
    <div class=""backgroundWhite container"">
        <div class=""card"">
            <div class=""card-header bg-dark text-light ml-0 row container"">
                <div class=""col-12 d-none d-md-block col-md-6 pb-1"">
                    <i class=""fas fa-shopping-cart""></i> &nbsp; Order Summary
                </div>
                <div class=""col-12 col-md-4 offset-md-2 text-right"">
                    <a class=""btn btn-outline-info form-control btn-sm"">Back to Orders</a>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""container rounded p-2"">
                    <div class=""row"">
                        <div class=""col-12 col-lg-6 pb-4"">
                            <div class=""row"">
                                <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                    <span class=""text-primary"">PickUp Details:</span>
                                </h4>
                  ");
                WriteLiteral(@"          </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Name</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Phone</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Address</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
   ");
                WriteLiteral(@"                         <div class=""row my-1"">
                                <div class=""col-3"">City</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">State</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Zip Code</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
                       ");
                WriteLiteral(@"     <div class=""row my-1"">
                                <div class=""col-3"">Email</div>
                                <div class=""col-9"">
                                    <input id=""txtName"" readonly type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Order Date</div>
                                <div class=""col-9"">
                                    <input type=""text"" readonly class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Carrier</div>
                                <div class=""col-9"">
                                    <input type=""text"" readonly class=""form-control"" />
                                </div>
                            </div>
                         ");
                WriteLiteral(@"   <div class=""row my-1"">
                                <div class=""col-3"">Tracking</div>
                                <div class=""col-9"">
                                    <input type=""text"" readonly class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Shipping Date</div>
                                <div class=""col-9"">
                                    <input id=""shippingDate"" type=""text"" readonly class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Transaction ID</div>
                                <div class=""col-9"">
                                    <input type=""text"" readonly class=""form-control"" />
                                </div>
                            </div>
         ");
                WriteLiteral(@"                   <div class=""row my-1"">
                                <div class=""col-3"">Payment Due Date</div>
                                <div class=""col-9"">
                                    <input readonly type=""text"" class=""form-control"" />
                                </div>
                                <div class=""col-3"">Payment Date</div>
                                <div class=""col-9"">
                                    <input readonly id=""paymentDate"" type=""text"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""row my-1"">
                                <div class=""col-3"">Payment Status</div>
                                <div class=""col-9"">
                                    <input type=""text"" readonly class=""form-control"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 ");
                WriteLiteral(@"col-lg-5 offset-lg-1"">
                            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                <span class=""text-primary"">Order Summary</span>
                            </h4>
                            <ul class=""list-group mb-3"">
                                <li class=""list-group-item d-flex justify-content-between"">
                                    <div class=""row container"">
                                        <div class=""col-8"">
                                            <h6 class=""my-0"">--Product.Title--</h6>
                                            <small class=""text-muted"">Price : --Price--</small>
                                            <small class=""text-muted"">Quantity : --Count--</small>
                                        </div>
                                        <div class=""col-4"">
                                            <h5 class=""text-success"">--price*count--</h5>
                            ");
                WriteLiteral(@"            </div>
                                    </div>
                                </li>
                                <li class=""list-group-item bg-info"">
                                    <div class=""row container"">
                                        <div class=""col-6"">
                                            <h5 class=""text-white"">TOTAL </h5>
                                        </div>
                                        <div class=""col-6 text-right"">
                                            <h5 class=""text-white"">--GRAND TOTAL-</h5>
                                        </div>
                                    </div>
                                </li>
                            </ul>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkyBookV5.Models.ViewModels.OrderDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
