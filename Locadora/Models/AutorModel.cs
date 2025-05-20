using System.Text.Json.Serialization;

namespace Locadora.Models
{
    public class AutorModel
    {
        public int Id { get; set; } 
        public string Nome { get; set; } 
        public string Sobrenome { get; set; }
        [JsonIgnore] // Não aparece a lista de livros ao criar um autor
        public ICollection<LivroModel> Livros { get; set; }
    }
}
