#pragma checksum "C:\GitHub\IS8012\InventoryStore\Pages\product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f7ade70c6a1687b17e36c2ca322c55c8308039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InventoryStore.Pages.Pages_product), @"mvc.1.0.razor-page", @"/Pages/product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/product.cshtml", typeof(InventoryStore.Pages.Pages_product), null)]
namespace InventoryStore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\GitHub\IS8012\InventoryStore\Pages\_ViewImports.cshtml"
using InventoryStore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f7ade70c6a1687b17e36c2ca322c55c8308039", @"/Pages/product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea203afadcfccee496c0ef3416ac82e423a2516", @"/Pages/_ViewImports.cshtml")]
    public class Pages_product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("productimg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\GitHub\IS8012\InventoryStore\Pages\product.cshtml"
  
    ViewData["Title"] = "Product page";

#line default
#line hidden
            BeginContext(76, 411, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "881d9aac28da4a118d1d31f83cd51fa3", async() => {
                BeginContext(82, 398, true);
                WriteLiteral(@"
    <style>
        #productimg{
    background-image:linear-gradient(rgba(0,0,0,0.5),rgba(0,0,0,0.5)),url(../images/product.jpg);
    background-size: cover;
        }
       h4,h2,label{
            color: whitesmoke;
        }
        li{
            color: gold;
            font-weight: bold; 
        }
    </style>
<link rel=""stylesheet"" type=""text/css"" href=""/css/Mob.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(487, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(489, 902, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db33130ffa42faa343ad3c85a061f9", async() => {
                BeginContext(511, 105, true);
                WriteLiteral("\r\n<div>\r\n    <h2>Product List</h2>\r\n    <ul id=\"productlist\">\r\n    </ul>\r\n</div>\r\n<div>\r\n    <hr />\r\n    ");
                EndContext();
                BeginContext(616, 758, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64e1cedd810a4de1ad0cbe22dfb31322", async() => {
                    BeginContext(658, 709, true);
                    WriteLiteral(@"
        <h4>Add New Product</h4>
        <div class=""form-group"">
            <label for=""name"">Product Name</label>
            <input type=""text"" class=""form-control"" id=""name"" placeholder=""Product Name"" required/>
        </div>                
        <div class=""form-group"">
            <label for=""size"">Size</label>
            <input type=""text"" class=""form-control"" id=""size"" placeholder=""Size"" required />
        </div>
        <div class=""form-group"">
            <label for=""price"">Price</label>
            <input type=""text"" class=""form-control"" id=""price"" placeholder=""Price"" required/>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Submit</button>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1374, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1391, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1411, 3130, true);
                WriteLiteral(@"
    <script>

    $(function() {
            loadData();
            $(""#createProductForm"").submit(function() {
                createProduct();
                return false;
            });
        });

    function loadData() {
            $.ajax({
                url: ""/api/products"",
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET'
            }).done(function(responseJSON,status,xhr) {
                // process the response when status code is 200-299
                buildProductList(responseJSON);
            }).fail(function(xhr,status,error) {
                // deal with error from server (status code 400-599)
                alert(""There was an error retrieving the data"");
            });
        }
    
     function buildProductList(products) {
            $(""#productlist"").empty();
            $.each(products, function (index, item) {
                var li = $('<li product-id=""' + item.id + '""></li>');");
                WriteLiteral(@"
                $(li).text('Prod id:'+item.id+' - '+item.name + ' - ' + item.size + ' - ' + item.price);
                
                $(li).append('<a href=""#"" class=""btn-primary pull-right product-delete"">Delete</a>')
                $(""#productlist"").append(li);    
            });
        }

         $(""#productlist"").on('click', 'a.product-delete', function() {
                var id = $(this).parents(""li"").attr('product-id');
                // call the delete method
                deleteProduct(id);
                return false;
            });
        

    function createProduct() {
            var requestData = {
                name: $(""#name"").val(), // GET THE Product VALUE
                size: $(""#size"").val(), // GET THE Size VALUE
                price: $(""#price"").val(), // GET THE Price VALUE
               
            };
            $.ajax({
                url: 'http://localhost:5000/api/products',
                dataType: 'json',
                contentTy");
                WriteLiteral(@"pe: 'application/json',
                method: 'POST',
                data: JSON.stringify(requestData)
            }).done(function(responseData, status, xhr) {
                loadData(); // RELOAD THE Product DATA
                $(""#name"").val(""""); //CLEAR INVENTORY
                $(""#size"").val(""""); //CLEAR QUANTITY
                $(""#price"").val(""""); //CLEAR Product ID
            }).fail(function(xhr, status, error) {
                alert(""There was an error saving your Product"");
            });
        }
    
    function deleteProduct(id) {
            $.ajax({
                url: 'http://localhost:5000/api/products/' + id,
                dataType: 'json',
                contentType: 'application/json',
                method: 'DELETE',
            }).done(function(responseData, status, xhr) {
                loadData(); // RELOAD THE Product DATA                
            }).fail(function(xhr, status, error) {
                alert(""There was an error deleting your I");
                WriteLiteral("nventory\");\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<productModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<productModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<productModel>)PageContext?.ViewData;
        public productModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
