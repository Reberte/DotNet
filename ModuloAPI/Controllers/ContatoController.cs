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

//Criando um ENDPOINT controle que cria um registro no Banco de Dados pela API - FAZ UM INSERT NA TABELA
        [HttpPost]
        public IActionResult Create(Contato contato) 
        {
            _context.Add(contato);
            _context.SaveChanges();
            //return Ok(contato);
            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
        }

//Criando um ENDPOINT controle que consulta  um registro no Banco de Dados pela API pelo ID -- FAZ UM SELECT NO BANCO - SELECIONA 
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null){
                return NotFound();
            }
            return Ok(contato);

        }



        //Criando um ENDPOINT controle que Altera um registro no Banco de Dados pela API -- FAZ UM UPDATE NO BANCO - ALTERAR 

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
            return NotFound();

            //var contatoBancoAntigo = contatoBanco;

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            //return Ok($"Dados antigos: {contatoBancoAntigo} \n Dados alterados: {contatoBanco}");

            return Ok(contatoBanco);
        }



        //Criando um ENDPOINT controle que Deleta um registro no Banco de Dados pela API -- FAZ UM DELETE NO BANCO - DELETAR
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
            return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return NoContent();
        }


        
        //Criando um ENDPOINT controle que consulta  um registro no Banco de Dados pela API todos contatos-- FAZ UM SELECT NO BANCO - SELECIONA 
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));

             return Ok(contatos);

        }


    }
}