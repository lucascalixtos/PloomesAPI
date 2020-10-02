using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPloomes.Data;
using ApiPloomes.Models;

namespace ApiPloomes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApiPloomesContext _context;

        public UsuariosController(ApiPloomesContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public IEnumerable<Usuario> GetUsuario()
        {
            return _context.Usuario;
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpGet("GetByName/{nome}")]
        public async Task<IActionResult> GetUsuarioByName([FromRoute] string nome) {
            
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var usuario = await _context.Usuario.Where(x => x.Nome == nome).ToListAsync();

            if (usuario == null) {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpGet("login")]
        public async Task<IActionResult> Login([FromBody] Usuario usuario) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var resultado = await _context.Usuario.Where(x => (x.Email == usuario.Email) && (x.Senha == usuario.Senha)).ToListAsync();

            if (resultado == null) {

            }

            var retorno = new { status = "Login realizado com sucesso" };

            return Ok(retorno);
        }

        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario([FromRoute] int id, [FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        [HttpPost]
        public async Task<IActionResult> PostUsuario([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return Ok(usuario);
        }
        
        [HttpGet("PaginacaoUsuario")]
        public async Task<IActionResult> PaginacaoUsuario([FromQuery] int pagina, [FromQuery] int quantidadeRegistros) {

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            int totalPaginas = (int)Math.Ceiling(await _context.Usuario.CountAsync() / Convert.ToDecimal(quantidadeRegistros));
            var usuario = _context.Usuario.OrderBy(m => m.Id).Skip(quantidadeRegistros * (pagina - 1)).Take(quantidadeRegistros);

            if (usuario == null) {
                return NotFound();
            }

            return Ok(usuario);
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }
    }
}