namespace BlazorApp1.Models
{
    public class Especies
    {
        public string Animal { get; set; }
        public string Color { get; set; }
        public bool Volador { get; set; }

        public Especies()
        {
            Animal = string.Empty;
            Color = string.Empty;
            Volador = false;
        }
    }
}
