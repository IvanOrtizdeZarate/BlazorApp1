using BlazorApp1.Models;
using System.Threading;

namespace BlazorApp1.Servicios
{
    public interface IAnimales
    {
        public List<Especies> Listar();
        public void AgregarAnimal(Especies especie);
    }

    public class Animales : IAnimales
    {
        private List<Especies> NuestrasEspecies=new List<Especies>();
        public Animales()
        {
            Especies Tipo = new Especies();

            Tipo.Animal = "Cochinillo";
            Tipo.Volador = true;
            Tipo.Color = "Rosadito";

            NuestrasEspecies.Add(Tipo);
        }

        public List<Especies> Listar()
        {
            return NuestrasEspecies;
        }

        public void AgregarAnimal(Especies animal)
        {
            NuestrasEspecies.Add(animal);
        }
    }
}
