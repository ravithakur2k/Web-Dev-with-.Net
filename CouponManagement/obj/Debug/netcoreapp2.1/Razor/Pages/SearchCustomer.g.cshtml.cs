#pragma checksum "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97720beb9cac00582722bb1b111df08b29ae3671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CouponManagement.Pages.Pages_SearchCustomer), @"mvc.1.0.razor-page", @"/Pages/SearchCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SearchCustomer.cshtml", typeof(CouponManagement.Pages.Pages_SearchCustomer), null)]
namespace CouponManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\GitHub\IS7012\CouponManagement\Pages\_ViewImports.cshtml"
using CouponManagement;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97720beb9cac00582722bb1b111df08b29ae3671", @"/Pages/SearchCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34dc94f2dfea7d0cc18925876bc8f5ec3ad9f96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SearchCustomer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 368, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5daca8ac0414c88f15171cce3708f", async() => {
                BeginContext(100, 305, true);
                WriteLiteral(@"
  <div class=""form-group"">
    <label class=""control-label"" for=""search"">Search Customer Name</label>
    <input type=""text"" class=""form-control"" name=""search"" id=""search"" />
  </div>
  <div class=""form-group"">
    <input type=""submit"" value=""Search Customer"" class=""btn btn-default"" />
  </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(412, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 17 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
 if(Model.SearchCompleted) {

#line default
#line hidden
            BeginContext(448, 251, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Address</th>\r\n                <th>Email</th>\r\n                <th>PhoneNumber</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 28 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
             if(Model.SearchResults.Count > 0) {
                

#line default
#line hidden
#line 29 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                 foreach(var cust in Model.SearchResults) {

#line default
#line hidden
            BeginContext(810, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(865, 9, false);
#line 31 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                       Write(cust.Name);

#line default
#line hidden
            EndContext();
            BeginContext(874, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(910, 12, false);
#line 32 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                       Write(cust.Address);

#line default
#line hidden
            EndContext();
            BeginContext(922, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(958, 10, false);
#line 33 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                       Write(cust.Email);

#line default
#line hidden
            EndContext();
            BeginContext(968, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1004, 16, false);
#line 34 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                       Write(cust.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 36 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                }

#line default
#line hidden
#line 36 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                 
            } else {

#line default
#line hidden
            BeginContext(1095, 146, true);
            WriteLiteral("                <tr class=\"danger\">\r\n                    <td colspan=\"4\" class=\"text-center\">\r\n                        No results found for term \"");
            EndContext();
            BeginContext(1242, 12, false);
#line 40 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
                                              Write(Model.Search);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 53, true);
            WriteLiteral("\"\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
            }

#line default
#line hidden
            BeginContext(1322, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 46 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
} else if(!Model.FirstLoad){

#line default
#line hidden
            BeginContext(1384, 172, true);
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <p>\r\n            Enter the search terms into the box and click <strong>Search Customer Name</strong>\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 52 "C:\GitHub\IS7012\CouponManagement\Pages\SearchCustomer.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchCustomerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchCustomerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchCustomerModel>)PageContext?.ViewData;
        public SearchCustomerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591