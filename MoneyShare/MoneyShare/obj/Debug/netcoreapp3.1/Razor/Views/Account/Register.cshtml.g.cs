#pragma checksum "E:\petProject\MoneyShare\MoneyShare\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3ca747966d5ffc1083e8a1c20de8004bdd8d7b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ca747966d5ffc1083e8a1c20de8004bdd8d7b6", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoneyShare.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Регистрация нового пользователя</h2>
<form method=""post"" asp-controller=""Account"" asp-action=""Register"">
    <div asp-validation-summary=""ModelOnly""></div>
    <div>
        <label for=""1"" class=""form-label"">Email</label>
        <input name=""Email"" type=""text"" class=""form-control"" id=""2"">
    </div>
    <div>
        <label for=""2"" class=""form-label"">Password</label>
        <input name=""Password"" type=""text"" class=""form-control"" id=""2"">
");
            WriteLiteral(@"    </div>
    <div>
        <label for=""3"" class=""form-label"">PasswordConfirm</label>
        <input name=""PasswordConfirm"" type=""text"" class=""form-control"" id=""2"">
    </div>
    <div>
        <input type=""submit"" value=""Register"" />
    </div>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoneyShare.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591