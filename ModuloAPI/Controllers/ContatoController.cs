using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        // POST : /Contato -> criar um novo contato
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bool contatoExiste = _context.Contatos.Any(c => c.Nome == contato.Nome);

            if (contatoExiste)
                return Conflict("Já existe um contato com esse e-mail.");

            _context.Add(contato);
            _context.SaveChanges();
            return Ok(CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato));
        }

        // GET: /Contato/{id} -> obter contato por id
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound($"Contato com ID {id} não encontrado.");

            return Ok(contatoBanco);
        }

        // GET: /Contato/ObterPorNome -> obter contato por nome
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return BadRequest("O parâmetro 'nome' é obrigatório.");

            var contatosBanco = _context.Contatos
                .Where(c => c.Nome.Contains(nome))
                .ToList();

            if (!contatosBanco.Any())
                return NotFound($"Nenhum contato encontrado com esse nome");

            return Ok(contatosBanco);
        }

        // GET: /Contato -> exibir todos os contatos
        [HttpGet]
        public IActionResult ExibirTodosOsContatos()
        {
            var contatosBanco = _context.Contatos.ToList();
   
            return Ok(contatosBanco);
        }

        // PUT: /Contatos/{id} -> atualizar um contato existente
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound($"Contato com ID {id} não encontrado.");

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        // DELETE: /Contatos/{id} -> apagar um contato existente
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound($"Contato com ID {id} não encontrado.");

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}