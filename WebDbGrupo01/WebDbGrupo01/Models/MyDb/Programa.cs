namespace WebDbGrupo01.Models.MyDb
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Programa
    {
        public int ProgramaId { get; set; }

        [StringLength(40)]
        public string Nombre { get; set; }
        public int Niveles { get; set; }

        public ICollection<Estudiante> Estudiantes { get; set; }
    }
}
