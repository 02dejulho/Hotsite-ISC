#pragma checksum "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1bd8e4cfe031255a4409dd3a2863a286c0f54f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1bd8e4cfe031255a4409dd3a2863a286c0f54f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interesse>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("nome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mensagem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formCad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "ISC";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
  <div class=""row"">
        <div class=""col-md-6"">
            <h1>Iniciativa Saúde da Cidade</h1>
            <p>
                Texto sobre vida saudável: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
            </p>
            
            <p>
                Texto sobre vida iniciativa: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
            </p>

            <p>
                Texto sobre vida iniciativa: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
            </p>
        </div>

");
            WriteLiteral(@"
        <div class=""col-md-6"">
            <figure class=""figure"">
                <figcaption class=""figure-caption text-center"">
                   <img src=""/img/a.jpg"" class=""figure-img img-fluid rounded"" alt=""Empresas Apoiadoras"">
                </figcaption>
            </figure>
        </div>
    </div>
</div>

<br>

");
            WriteLiteral("\r\n");
            WriteLiteral(@"    
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"" id=""form"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h2>Entre em contato:</h2>
                    <p>Envie-nos uma mensagem e fique por dentro de nossos eventos</p>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1bd8e4cfe031255a4409dd3a2863a286c0f54f8742", async() => {
                WriteLiteral("\r\n                         <div class=\"form-group\">\r\n                            <label>Nome:</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd1bd8e4cfe031255a4409dd3a2863a286c0f54f9135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 56 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n        \r\n                        <div class=\"form-group\">\r\n                            <label>Email:</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd1bd8e4cfe031255a4409dd3a2863a286c0f54f11031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 61 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label>Mensagem (opcional):</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1bd8e4cfe031255a4409dd3a2863a286c0f54f13151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 66 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            <input type=\"submit\" value=\"Enviar\" id=\"btnEnvio\" />\r\n\r\n                            <!--<p id=\"pMensagem\" class=\"text-success\">");
#nullable restore
#line 71 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml"
                                                                  Write(ViewBag.Sucesso);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>-->\r\n                            <!--<p id=\"pMensagem2\" class=\"text-danger\">");
#nullable restore
#line 72 "C:\Users\lucia\Desktop\SENAC-TII\MODULO B\UC06 - Publicar e testar aplicações web\lucianasilva-uc06-atv1\Hotsite\Views\Home\Index.cshtml"
                                                                  Write(ViewBag.Falha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>-->\r\n                            \r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("        \r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n\r\n");
            WriteLiteral(@"
                <div class=""col-md-4"">
                    <figure class=""figure"">
                        <figcaption class=""figure-caption text-center"">
                            <a href=""#"" data-toggle=""modal"" data-target=""#AgendadeEventos""><img src=""/img/agenda.jpg"" class=""figure-img img-fluid rounded"" alt=""Agenda de Eventos"">Agenda de Eventos</a>
                        </figcaption>
                    </figure>
                    
");
            WriteLiteral(@"                    
                    <div class=""modal fade"" id=""AgendadeEventos"" tabindex=""-1"" aria-labelledby=""AgendadeEventos"" aria-hidden=""true"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""AgendadeEventos"">Agenda de Eventos</h5>
                                </div>
                                <div class=""modal-body"">
                                    <div>
                                        <p>25/09/2023 - 10h00 - Evento 1</p>
                                        <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix.</p>
                                    </div>

                                    <div>
                                        <p>26/09/2023 - 10h00 - Evento 2</p>
                                        <p>Lorem ipsum dolor sit amet et");
            WriteLiteral(@" delectus accommodare his consul copiosae legendos at vix.</p>
                                    </div>

                                    <div>
                                        <p>27/09/2023 - 10h00 - Evento 3</p>
                                        <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix.</p>
                                    </div>
                                </div>
      
                            </div>
                        </div>
                    </div>
                </div>

");
            WriteLiteral(@"
                <div class=""col-md-4"">
                    <figure class=""figure"">
                        <figcaption class=""figure-caption text-center"">
                            <a href=""#"" data-toggle=""modal"" data-target=""#Dicas""><img src=""/img/dicas1.jpg"" class=""figure-img img-fluid rounded"" alt=""Vida Saudável"">Dicas de Vida Saudável</a>
                        </figcaption>
                    </figure>

");
            WriteLiteral(@"
                    <div class=""modal fade"" id=""Dicas"" tabindex=""-1"" aria-labelledby=""Dicas"" aria-hidden=""true"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""Dicas"">Dicas de Vida Saudável</h5>
                                </div>
                                <div class=""modal-body"">
                                    <div>                                       
                                        <div>                            
                                            <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.</p>
                                        </div>

                                        <div>                            
                              ");
            WriteLiteral(@"              <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.</p>
                                        </div>

                                        <div>                            
                                            <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.</p>
                                        </div>
                                    </div>
                                </div>
      
                            </div>
                        </div>
                    </div>
                </div>

");
            WriteLiteral(@"
                <div class=""col-md-4"">
                    <figure class=""figure"">
                        <figcaption class=""figure-caption text-center"">
                            <a href=""#"" data-toggle=""modal"" data-target=""#Apoiadores""><img src=""/img/apoiadores.jpg"" class=""figure-img img-fluid rounded"" alt=""Empresas Apoiadoras"">Apoiadores</a>
                        </figcaption>
                    </figure>

");
            WriteLiteral(@"
                    <div class=""modal fade"" id=""Apoiadores"" tabindex=""-1"" aria-labelledby=""Apoiadores"" aria-hidden=""true"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""Apoiadores"">Apoiadores</h5>
                                </div>
                                <div class=""modal-body"">

");
            WriteLiteral(@"                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <img src=""/img/senac.png"" width=""120px""><br>
                                        </div>
                                        <div class=""col-md-9"">
                                            <div> 
                                                <h5>Senac</h5>                            
                                                <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix.</p>
                                            </div>
                                        </div>
                                    </div>

");
            WriteLiteral(@"                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <img src=""/img/des.png"" width=""150px""><br>
                                        </div>
                                        <div class=""col-md-9"">
                                            <div>  
                                                <h5>Desinchá</h5>                          
                                                <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix.</p>
                                            </div>
                                        </div>
                                    </div>
                                    
");
            WriteLiteral(@"                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <img src=""/img/smf.jpg"" width=""120px""><br>
                                        </div>
                                        <div class=""col-md-9"">
                                            <div>    
                                                <h5>Smart Fit</h5>                         
                                                <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix.</p>
                                            </div>
                                        </div>
                                    </div>
                                    
");
            WriteLiteral(@"                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <img src=""/img/amil.png"" width=""120px""><br>
                                        </div>
                                        <div class=""col-md-9"">
                                            <div>       
                                                <h5>Amil</h5>                      
                                                <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix.</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
      
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
           ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interesse> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591