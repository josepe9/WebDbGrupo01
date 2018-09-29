namespace WebDbGrupo01.Models.MyDb
{
    using System.ComponentModel.DataAnnotations;

    public class Estudiante
    {
        public int EstudianteId { get; set; }

        [StringLength(60)]
        public string Nombre { get; set; }

        public int ProgramaId { get; set; }
        public Programa Programa { get; set; }


    }
}
