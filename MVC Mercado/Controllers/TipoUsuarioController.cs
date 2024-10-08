using MVC_Mercado.Context;
using MVC_Mercado.Models;
using Microsoft.AspNetCore;

namespace MVC_Mercado.Controllers
{
    public class TipoUsuarioController : Controller
    {
        private readonly SCContext _context;
        public TipoUsuarioController(SCContext context)
        {
            _context = context;
        }



    }
}
