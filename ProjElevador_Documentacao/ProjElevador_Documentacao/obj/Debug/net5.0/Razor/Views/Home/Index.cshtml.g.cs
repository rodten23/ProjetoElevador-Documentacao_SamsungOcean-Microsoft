#pragma checksum "E:\CURSOS\SAMSUNG-OCEAN\SamsungOcean_Microsoft\ProjElevador_Documentacao\ProjElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2659054fe237d113af339f551c7884065929e6b"
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
#line 1 "E:\CURSOS\SAMSUNG-OCEAN\SamsungOcean_Microsoft\ProjElevador_Documentacao\ProjElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CURSOS\SAMSUNG-OCEAN\SamsungOcean_Microsoft\ProjElevador_Documentacao\ProjElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2659054fe237d113af339f551c7884065929e6b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6e3825202d8a4c21b2f07bb4a7be3e7347c95e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\CURSOS\SAMSUNG-OCEAN\SamsungOcean_Microsoft\ProjElevador_Documentacao\ProjElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bem-vindos ao Future Tech!</h1>
    <h1>Projeto de controle elevador em C# no padrão MVC.</h1>
    <h2>Curso: [FORMAÇÃO MS-DEV] Samsung OCEAN/Microsoft</h2>
    <h2>Ministrado pelo Prof. Lucas Aragão Feliciano</h2>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<h2>Documentação</h2>
<p>
    Nosso elevador atende do térreo até o 6º andar e tem capacidade para até 5
    pessoas. No menu você pode escolher as seguintes opções:
</p>
<p>
    - INICIALIZAR: depois de serviços de manutenção podemos reinicializar
    nosso elevador, que virá para o térreo sempre sem qualquer ocupante por
    medidas de segurança.
</p>
<p>
    - ENTRAR: você informa quantos ocupantes irão entrar, sendo limitado a 5
    pessoas e, caso digite 0 por engano, sistema voltará ao menu inicial.
    Função não acionará se elevador já estiver lotado.
</p>
<p>
    - SUBIR: nessa opção você irá i");
            WriteLiteral(@"nformar para qual andar quer subir, sendo o
    6º andar o último. Caso informe um número onde já está, poderá informar
    novo andar para subir e, caso informe número inferior, sistema voltará ao
    menu inicial para poder escolher opção Descer. Se já estiver no 6º andar,
    função não será aceita e voltará ao menu inicial.
</p>
<p>
    - DESCER: você irá informar para qual andar deseja descer, lembrando que
    não temos sub-solo, portanto se informar 0, função não será aceita e
    voltará ao menu inicial. Caso informe um número onde já está, poderá
    informar novo andar para descer e, caso informe número superior, sistema
    voltará ao menu inicial para poder escolher opção Subir.
</p>
<p>
    - SAIR: nesta opção você informa quantos ocupantes sairão do elevador. Se
    por engano digitar número maior que ocupantes, poderá informar nova
    quantidade. Mas, caso digite 0 por engano, sistema voltará ao menu
    inicial. Função não acionará se elevador já estiver vazio.
</p>
<p>
  ");
            WriteLiteral("  - MANUTENÇÃO: com esta opção elevador voltará ao térreo e todos deverão\r\n    sair, sendo programa desligado em seguida.\r\n</p>\r\n<p>\r\n    <b\r\n    >Agradecemos atenção e dúvidas/sugestões podem ser reportadas a\r\n    rodten23@gmail.com</b\r\n    >\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
