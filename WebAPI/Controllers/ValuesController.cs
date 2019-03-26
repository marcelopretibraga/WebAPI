using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            var pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa() { PessoaId = 1, Nome = "marcelo 1", Cpf = "45454544" });
            pessoas.Add(new Pessoa() { PessoaId = 2, Nome = "marcelo 2", Rg = "2454454" });
            pessoas.Add(new Pessoa() { PessoaId = 3, Nome = "marcelo 3", DataNascimento = DateTime.Now});
            pessoas.Add(new Pessoa() { PessoaId = 4, Nome = "marcelo 4", Rg = "4545487", Telefone = "45458" });
            pessoas.Add(new Pessoa() { PessoaId = 5, Nome = "marcelo 5", Cpf = "1215457" });
            return pessoas;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Pessoa pessoa)
        {
            var salvarPessoa = pessoa;
            //Aqui pra frente irá fazer depois
            //_context.Pessoas.add(pessoa);
            //_context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
