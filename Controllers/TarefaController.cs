using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;
using Microsoft.EntityFrameworkCore;

namespace TrilhaApiDesafio.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar as tarefas, permitindo criar, ler, atualizar e deletar tarefas.
    /// </summary>
    /// <param name="context"></param>
    [ApiController]
    [Route("[controller]")]
    public class TarefaController(OrganizadorContext context) : ControllerBase
    {
        private readonly OrganizadorContext _context = context;

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null)
                return NotFound();
            return Ok(tarefa);
        }

        /// <summary>
        /// Obtem todas as tarefas.
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> ObterTodasAsTarefas()
        {
            var tarefa = await _context.Tarefas.ToListAsync();
            if (!tarefa.Any())
                return NotFound();
            return Ok(tarefa);
        }

        /// <summary>
        /// Obtem as tarefas por título, utilizando o operador Contains para permitir buscas parciais.
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns>Lista de tarefas contendo no título a substring definida em titulo</returns>
        [HttpGet("[action]/{titulo}")]
        public async Task<IActionResult> ObterTarefaPorTitulo(string titulo)
        {
            var tarefa = await _context.Tarefas.Where(tarefa => tarefa.Titulo.Contains(titulo)).ToListAsync();
            if (!tarefa.Any())
                return NotFound();
            return Ok(tarefa);
        }


        /// <summary>
        /// Obtem as tarefas por data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Lista de tarefas com a data definida em data</returns>
        [HttpGet("[action]/{data}")]
        public async Task<IActionResult> ObterTarefaPorData(DateTime data)
        {
            var tarefa = await _context.Tarefas.Where(x => x.Data.Date == data.Date).ToListAsync();
            if (!tarefa.Any())
                return NotFound();
            return Ok(tarefa);
        }

        /// <summary>
        /// Obtem as tarefas por status.
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet("[action]/{status}")]
        public async Task<IActionResult> ObterTarefaPorStatus(EnumStatusTarefa status)
        {
            var tarefa = await _context.Tarefas.Where(x => x.Status == status).ToListAsync();
            if (!tarefa.Any())
                return NotFound();
            return Ok(tarefa);
        }

        /// <summary>
        /// Cria uma nova tarefa. A data da tarefa não pode ser vazia (DateTime.MinValue).
        /// </summary>
        /// <param name="tarefa"></param>
        /// <returns></returns>
        [HttpPost("[action]/{titulo}")]
        public async Task<IActionResult> CriarTarefa(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        /// <summary>
        /// Atualiza uma tarefa existente. A data da tarefa não pode ser vazia (DateTime.MinValue).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tarefa"></param>
        /// <returns></returns>
        [HttpPut("[action]/{titulo}")]
        public async Task<IActionResult> AtualizarTarefa(int id, Tarefa tarefa)
        {
            var tarefaBanco = await _context.Tarefas.FindAsync(id);

            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            await _context.SaveChangesAsync();
            return Ok(tarefaBanco);
        }

        /// <summary>
        /// Deleta uma tarefa existente.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var tarefaBanco = await _context.Tarefas.FindAsync(id);

            if (tarefaBanco == null)
                return NotFound();
            _context.Tarefas.Remove(tarefaBanco);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
