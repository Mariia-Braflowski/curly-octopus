#pragma checksum "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6d33c6b2088f9a36e5bc9923b74107ea2b89e65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Editing), @"mvc.1.0.view", @"/Views/Category/Editing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d33c6b2088f9a36e5bc9923b74107ea2b89e65", @"/Views/Category/Editing.cshtml")]
    public class Views_Category_Editing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoneyShare.Core.BLL.DTO.CategoryDTO>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml"
  
    Layout = null;
    //ViewBag.CategoryID = Model.CategoryId;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6d33c6b2088f9a36e5bc9923b74107ea2b89e652965", async() => {
                WriteLiteral(@"
    <title>EDITING</title>
    <!-- Кодировка веб-страницы -->
    <meta charset=""utf-8"">
    <!-- Настройка viewport -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Bootstrap CSS (jsDelivr CDN) -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0"" crossorigin=""anonymous"">
    <!-- Bootstrap Bundle JS (jsDelivr CDN) -->
    <script defer src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6d33c6b2088f9a36e5bc9923b74107ea2b89e654678", async() => {
                WriteLiteral("\r\n    <form method=\"post\"  action=\"/Category/EditCategory\">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 984, "\"", 1009, 1);
#nullable restore
#line 22 "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml"
WriteAttributeValue("", 992, Model.CategoryId, 992, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"CategoryId\"/>\r\n        <div class=\"mb-3\">\r\n            <label for=\"1\" class=\"form-label\">Title</label>\r\n            <input name=\"Title\" type=\"text\" class=\"form-control\" id=\"1\" aria-describedby=\"emailHelp\"");
                BeginWriteAttribute("value", " value=\"", 1221, "\"", 1241, 1);
#nullable restore
#line 25 "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml"
WriteAttributeValue("", 1229, Model.Title, 1229, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"2\" class=\"form-label\">Color</label>\r\n            <input name=\"Color\" type=\"text\" class=\"form-control\" id=\"2\"");
                BeginWriteAttribute("value", " value=\"", 1421, "\"", 1441, 1);
#nullable restore
#line 29 "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml"
WriteAttributeValue("", 1429, Model.Color, 1429, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label class=\"form-label\" for=\"3\">Icon</label>\r\n            <input name=\"Icon\" type=\"text\" class=\"form-control\" id=\"3\"");
                BeginWriteAttribute("value", " value=\"", 1619, "\"", 1638, 1);
#nullable restore
#line 33 "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml"
WriteAttributeValue("", 1627, Model.Icon, 1627, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label class=\"form-check-label\" for=\"4\">Category type</label>\r\n            <input name=\"CategoryType\" type=\"text\" class=\"form-control\" id=\"4\"");
                BeginWriteAttribute("value", " value=\"", 1839, "\"", 1866, 1);
#nullable restore
#line 37 "E:\petProject\MoneyShare\MoneyShare\Views\Category\Editing.cshtml"
WriteAttributeValue("", 1847, Model.CategoryType, 1847, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    </form>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoneyShare.Core.BLL.DTO.CategoryDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
