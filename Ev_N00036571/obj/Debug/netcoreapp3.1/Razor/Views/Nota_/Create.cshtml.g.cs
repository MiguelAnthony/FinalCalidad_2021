#pragma checksum "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7953d51edc8e28d579b98197ab52f750e1468782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota__Create), @"mvc.1.0.view", @"/Views/Nota_/Create.cshtml")]
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
#line 1 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\_ViewImports.cshtml"
using Ev_N00036571;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\_ViewImports.cshtml"
using Ev_N00036571.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7953d51edc8e28d579b98197ab52f750e1468782", @"/Views/Nota_/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b35a7e206a9edd40b4779c0aa8b98729f9280d", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota__Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createNota"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("guardar(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Nota_/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
   Layout = null;    var nota = (Nota)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7953d51edc8e28d579b98197ab52f750e14687825180", async() => {
                WriteLiteral("\r\r    <div class=\"form-group\">\r        <label>Titulo</label>\r        <input type=\"text\" class=\"form-control\" name=\"Titulo\" placeholder=\"Titulo\"");
                BeginWriteAttribute("value", " value=\"", 306, "\"", 327, 1);
#nullable restore
#line 8 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
WriteAttributeValue("", 314, Model.Titulo, 314, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r        ");
#nullable restore
#line 9 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
   Write(Html.ValidationMessage("Titulo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r    </div>\r\r    <div class=\"form-group\">\r        <label>Contenido</label>\r        <textarea id=\"text\" name=\"Contenido\"></textarea>\r        ");
#nullable restore
#line 15 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
   Write(Html.ValidationMessage("Cuerpo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r    </div>\r\r    <div class=\"form-group\">\r        <label>Etiquetas</label>\r");
#nullable restore
#line 20 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
         foreach (var item in ViewBag.Etiquetas)        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"form-check form-check\">\r    <input name=\"etiqueta\" class=\"form-check-input\" type=\"checkbox\" id=\"inlineCheckbox1\"");
                BeginWriteAttribute("value", " value=\"", 804, "\"", 820, 1);
#nullable restore
#line 23 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
WriteAttributeValue("", 812, item.Id, 812, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r    <label class=\"form-check-label\" for=\"inlineCheckbox1\">");
#nullable restore
#line 24 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
                                                     Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r</div>");
#nullable restore
#line 25 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
#nullable restore
#line 26 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Nota_\Create.cshtml"
   Write(Html.ValidationMessage("etiqueta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r    </div>\r");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<script type='text/javascript'>    var simplemde = new SimpleMDE({        autofocus: true,        toolbar: [""bold"", ""italic"", ""heading"", ""|"", ""quote""],        blockStyles: {            bold: ""__"",            italic: ""_""        },        element: document.getElementById(""text""),        forceSync: true,        hideIcons: [""guide"", ""heading""],        indentWithTabs: false,        placeholder: ""Escriba algo..."",        insertTexts: {            horizontalRule: ["""", ""\n\n-----\n\n""],            image: [""![](http://"", "")""],            link: [""["", ""](http://)""],            table: ["""", ""\n\n| Column 1 | Column 2 | Column 3 |\n| -------- | -------- | -------- |\n| Text     | Text      | Text     |\n\n""],        },        lineWrapping: false,        parsingConfig: {            allowAtxHeaderWithoutSpace: true,            strikethrough: false,            underscoresBreakWords: true,        },        placeholder: ""Escriba algo..."",        previewRender: function (plainText) {            retur");
            WriteLiteral(@"n customMarkdownParser(plainText);         },        previewRender: function (plainText, preview) {             setTimeout(function () {                preview.innerHTML = customMarkdownParser(plainText);            }, 250);            return ""Loading..."";        },        promptURLs: true,        renderingConfig: {            singleLineBreaks: false,            codeSyntaxHighlighting: true,        },        shortcuts: {            drawTable: ""Cmd-Alt-T""        },        showIcons: [""code"", ""table""],        spellChecker: false,        status: false,        status: [""autosave"", ""lines"", ""words"", ""cursor""],         status: [""autosave"", ""lines"", ""words"", ""cursor"", {            className: ""keystrokes"",            defaultValue: function (el) {                this.keystrokes = 0;                el.innerHTML = ""0 Keystrokes"";            },            onUpdate: function (el) {                el.innerHTML = ++this.keystrokes + "" Keystrokes"";            }        }],         styleSelectedT");
            WriteLiteral("ext: false,\r        tabSize: 4,\r        toolbarTips: false,\r    });\r</script>");
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
