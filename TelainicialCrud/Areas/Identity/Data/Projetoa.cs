using System.ComponentModel.DataAnnotations;

namespace TelainicialCrud.Areas.Identity.Data
{
    public class Projetoa
    {
        [Key]
        public int IdProjetoa { get; set; }
        public string ProjetoaName { get; set; }

        public string Descricao { get; set; }

        public int valor { get; set; }

        public int DataInicio { get; set; }
        public int DataFinal { get; set; }

        public int QuantPessoas { get; set; }   


    }
}
