#pragma checksum "C:\GitHub\IS8012\InventoryStore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe7c3c96b9b58fc9db68a9cb04825f345acea64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InventoryStore.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(InventoryStore.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe7c3c96b9b58fc9db68a9cb04825f345acea64", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea203afadcfccee496c0ef3416ac82e423a2516", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createInventoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("indeximg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\GitHub\IS8012\InventoryStore\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8188d65ede642a1a68df83755be4efa", async() => {
                BeginContext(77, 402, true);
                WriteLiteral(@"
    <style>
        #indeximg{
    background-image:linear-gradient(rgba(0,0,0,0.5),rgba(0,0,0,0.5)),url(../images/inventory.jpg);
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
            BeginContext(486, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(488, 1262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a976400202d4c88883c1b5335f08aef", async() => {
                BeginContext(508, 141, true);
                WriteLiteral("\r\n    <div>\r\n        <h2>Inventory List</h2>\r\n        <ul id=\"inventorylist\">\r\n        </ul>\r\n    </div>\r\n    <div>\r\n        <hr />\r\n        ");
                EndContext();
                BeginContext(649, 1080, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d933b09d6d014ec581ac3ad5737854f0", async() => {
                    BeginContext(693, 1029, true);
                    WriteLiteral(@"
            <h4>Add new Inventory</h4>
            <div class=""form-group col-"">
                <label for=""inventory"">Inventory</label>
                <input type=""text"" class=""form-control"" id=""inventory"" placeholder=""Inventory Name"" required/>
            </div>                
            <div class=""form-group"">
                <label for=""quantity"">Quantity</label>
                <input type=""text"" class=""form-control"" id=""quantity"" placeholder=""Quantity"" required />
            </div>
            <div class=""form-group"">
                <label for=""product"">Product ID</label>
                <input type=""text"" class=""form-control"" id=""product"" placeholder=""Product ID"" required/>
            </div>
            <div class=""form-group"">
                <label for=""store"">Store ID</label>
                <input type=""text"" class=""form-control"" id=""store"" placeholder=""Store ID"" required />
            </div>
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
   ");
                    WriteLiteral("     ");
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
                BeginContext(1729, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
            BeginContext(1750, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1770, 3418, true);
                WriteLiteral(@"
    <script>
        

        $(function() {
            loadData();
            $(""#createInventoryForm"").submit(function() {
                createInventory();
                return false;
            });
        });
        
        function loadData() {
            $.ajax({
                url: ""/api/inventories"",
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET'
            }).done(function(responseJSON,status,xhr) {
                // process the response when status code is 200-299
                buildInventoryList(responseJSON);
            }).fail(function(xhr,status,error) {
                // deal with error from server (status code 400-599)
                alert(""There was an error retrieving the data"");
            });
        }
        
        function buildInventoryList(inventories) {
            $(""#inventorylist"").empty();
            $.each(inventories, function (index, item) {
                v");
                WriteLiteral(@"ar li = $('<li inventory-id=""' + item.id + '""></li>');
                $(li).text('Inv id:'+item.id+' - '+item.inventoryName + ' - ' + item.quantity + ' - ' + item.productID + ' - ' + item.storeID);
                
                $(li).append('<a href=""#"" class=""btn-primary pull-right inventory-delete"">Delete</a>')
                $(""#inventorylist"").append(li);    
            });
        }


            $(""#inventorylist"").on('click', 'a.inventory-delete', function() {
                var id = $(this).parents(""li"").attr('inventory-id');
                // call the delete method
                deleteInventory(id);
                return false;
            });

        function createInventory() {
            var requestData = {
                inventoryName: $(""#inventory"").val(), // GET THE Inventory VALUE
                quantity: $(""#quantity"").val(), // GET THE Quantity VALUE
                productID: $(""#product"").val(), // GET THE Product ID VALUE
                storeID: $(""#s");
                WriteLiteral(@"tore"").val() // GET THE Store ID VALUE
            };
            $.ajax({
                url: 'http://localhost:5000/api/inventories',
                dataType: 'json',
                contentType: 'application/json',
                method: 'POST',
                data: JSON.stringify(requestData)
            }).done(function(responseData, status, xhr) {
                loadData(); // RELOAD THE INVENTORY DATA
                $(""#inventory"").val(""""); //CLEAR INVENTORY
                $(""#quantity"").val(""""); //CLEAR QUANTITY
                $(""#product"").val(""""); //CLEAR Product ID
                $(""#store"").val(""""); //CLEAR Store ID
            }).fail(function(xhr, status, error) {
                alert(""There was an error saving your Inventory"");
            });
        }

        
        function deleteInventory(id) {
            $.ajax({
                url: 'http://localhost:5000/api/inventories/' + id,
                dataType: 'json',
                contentType: 'applicati");
                WriteLiteral(@"on/json',
                method: 'DELETE',
            }).done(function(responseData, status, xhr) {
                loadData(); // RELOAD THE Inventory DATA                
            }).fail(function(xhr, status, error) {
                alert(""There was an error deleting your Inventory"");
            });
        }

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
