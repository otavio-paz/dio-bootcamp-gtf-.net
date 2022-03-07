using Curso.API.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost] //informando q essa rota vai ter o metodo Post
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput); //devolve o status 201 de created - boa pratica
        }
    }
}
