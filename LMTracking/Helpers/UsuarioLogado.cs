using LMTracking.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMTracking.Helpers
{
    public static class UsuarioLogado
    {
        private static string TagUsuario { get
            {
                return "UsuarioLogado";
            }
        }
        public static Usuario RetornaUsuarioLogado(this HttpContext context)
        {
            int? UsuarioID = context.Session.GetInt32(TagUsuario);

            if (UsuarioID.HasValue)
            {
                return DadosAplicacao.ListaUsuarios.Find(p => p.ID == UsuarioID.Value);
            }

            return null;
        }

        public static void NovoUsuarioLogado(this HttpContext context, Usuario usuario) => context.Session.SetInt32(TagUsuario, usuario.ID);

        public static void UsuarioLogout(this HttpContext context) => context.Session.SetInt32(TagUsuario, 0);
    }
}
