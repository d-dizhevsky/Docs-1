#pragma checksum "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f55ba94f247b3112d1b347d3abc642c438caed36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Document), @"mvc.1.0.view", @"/Views/Home/Document.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Document.cshtml", typeof(AspNetCore.Views_Home_Document))]
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
#line 1 "E:\Other\nure\GL\Docs\Docs\Views\_ViewImports.cshtml"
using Docs;

#line default
#line hidden
#line 2 "E:\Other\nure\GL\Docs\Docs\Views\_ViewImports.cshtml"
using Docs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55ba94f247b3112d1b347d3abc642c438caed36", @"/Views/Home/Document.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd24a0a0e7c2bcfc86ebec632088364a8aa3512", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Document : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Docs.Models.ViewModels.DocumentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Members", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Document.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DocumentEdit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
  
    ViewData["Title"] = "Document";

    bool owner = Model.Member == null;
    bool canEdit = owner || Model.Member.Role.Edit;

#line default
#line hidden
            BeginContext(190, 83, true);
            WriteLiteral("\r\n<div class=\"docListPartName\" style=\"margin: 5px 0 10px\">\r\n    <span id=\"docName\">");
            EndContext();
            BeginContext(274, 19, false);
#line 11 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                  Write(Model.Document.Name);

#line default
#line hidden
            EndContext();
            BeginContext(293, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 12 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
     if (canEdit)
    {

#line default
#line hidden
            BeginContext(326, 74, true);
            WriteLiteral("<span class=\"glyphicon glyphicon-pencil\" onclick=\"docNameChange()\"></span>");
            EndContext();
#line 13 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                                                               }

#line default
#line hidden
            BeginContext(403, 65, true);
            WriteLiteral("</div>\r\n\r\n<ul id=\"navBar\">\r\n    <li class=\"navBarElem\">\r\n        ");
            EndContext();
            BeginContext(468, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6af59768d9454e9c7eb1b423a9bef0", async() => {
                BeginContext(535, 8, true);
                WriteLiteral("Download");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                           WriteLiteral(Model.Document.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(547, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 20 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
     if (owner)
    {

#line default
#line hidden
            BeginContext(584, 45, true);
            WriteLiteral("        <li class=\"navBarElem\">\r\n            ");
            EndContext();
            BeginContext(629, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b82f8210b1f42c596e0db1a818c04ea", async() => {
                BeginContext(687, 7, true);
                WriteLiteral("Members");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                      WriteLiteral(Model.Document.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(698, 62, true);
            WriteLiteral("\r\n        </li>\r\n        <li class=\"navBarElem\">\r\n            ");
            EndContext();
            BeginContext(760, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0e22a802447434186bd4107b4f40091", async() => {
                BeginContext(825, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                             WriteLiteral(Model.Document.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(835, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 28 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
    }

#line default
#line hidden
            BeginContext(859, 263, true);
            WriteLiteral(@"</ul>
<div style=""visibility: hidden"" id=""changesSavedText"">Changes saved.</div>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-8"">
            <textarea id=""textArea""
                      name=""text""
                      ");
            EndContext();
#line 36 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                       if (!canEdit) { 

#line default
#line hidden
            BeginContext(1145, 10, true);
            WriteLiteral(" disabled ");
            EndContext();
#line 36 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                                               }

#line default
#line hidden
            BeginContext(1164, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1166, 22, false);
#line 36 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                                            Write(Model.Document.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 310, true);
            WriteLiteral(@"</textarea>
        </div>
        <div class=""col-md-4"" style=""border-left: 2px solid gray;"">
            <span style=""font-size: 20px"">Online members:</span>
            <div id=""onlineUsersList"" style=""max-height: 320px; min-height: 320px; overflow: auto;""></div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1515, 36, true);
                WriteLiteral("\r\n    <script>\r\n        let docId = ");
                EndContext();
                BeginContext(1552, 17, false);
#line 47 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
               Write(Model.Document.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1569, 36, true);
                WriteLiteral(";\r\n        let documentChangeUrl = \"");
                EndContext();
                BeginContext(1606, 36, false);
#line 48 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                            Write(Url.Action("DocumentChange", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1642, 41, true);
                WriteLiteral("\";\r\n        let documentNameChangeUrl = \"");
                EndContext();
                BeginContext(1684, 40, false);
#line 49 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                Write(Url.Action("DocumentNameChange", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1724, 4, true);
                WriteLiteral("\";\r\n");
                EndContext();
#line 50 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
          
            string curUserName = Model.Member != null ? Model.Member.User.UserName : Model.Document.User.UserName;
        

#line default
#line hidden
                BeginContext(1867, 27, true);
                WriteLiteral("        let curUserName = \"");
                EndContext();
                BeginContext(1895, 11, false);
#line 53 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                      Write(curUserName);

#line default
#line hidden
                EndContext();
                BeginContext(1906, 65, true);
                WriteLiteral("\";\r\n\r\n        let textarea = $(\"#textArea\");\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(1971, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea1c253237045d7afdbf44dc41ce76e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2011, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
     if (canEdit)
    {
        

#line default
#line hidden
                BeginContext(2053, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2067, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5927c7ad63544039b35d848c9ef435fb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2111, 106, true);
                WriteLiteral("\r\n            <script>\r\n                textarea.on(\"input\", textChange);\r\n            </script>\r\n        ");
                EndContext();
#line 65 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
               
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Docs.Models.ViewModels.DocumentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
