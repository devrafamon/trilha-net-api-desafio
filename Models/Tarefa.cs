using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
    /// <summary>
    /// Modelo de dados para representar uma tarefa, contendo propriedades como Id, Titulo, Descricao, Data e Status. O status da tarefa é representado por um enum EnumStatusTarefa, que pode ser Pendente ou Finalizado.
    /// </summary>
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}