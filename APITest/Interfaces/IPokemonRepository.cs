using APITest.Models;

namespace APITest.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();

    }
}
