using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

// C:\Users\CATALOG\source\repos\WebApplication1\WebApplication1\App_Start\RouteConfig.cs

namespace WebApplication1
{
    public class RouteConfig
    {
        // se a controller e espinha dorsal
        // a controller não seria nada sem as rotas
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //*** ATENÇÃO ESTA CONFIGURAÇÃO DE ROTA ABAIXO NÃO E RECOMENDADA
            //** ESTAMOS APLICANDO COMO UM DIMANICA DIDATICA

            // para o mvc não confundir removemo o parametro id
            //  https:/ /localhost:44377/institucional/home
            routes.MapRoute(
                name: "Institucional",
                url: "institucional/{controller}/{action}",
                defaults: new { controller = "Home", action = "Index"}
            );



            // NÃO E RECOMENDADO
            // Existe uma ordem no MVC
            // ele testa do primeiro para o ultimo
            // a rota complexa fica acima
            // rota padrão por ultimo
            // como ele funciona ele pega a primeira opçao e testa não funcionou 
            // ele testa a segunda opção e assim vai
            // FORÇA UMA ROTA

            // a url: https:/ /localhost:44377/sistema/Home/About
            routes.MapRoute(
                name: "Teste",
                url: "sistema/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
