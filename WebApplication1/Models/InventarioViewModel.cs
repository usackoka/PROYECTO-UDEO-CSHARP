namespace WebApplication1.Models
{
    public class InventarioViewModel
    {
        public List<ProductoViewModel> productos { get; set; }
        public InventarioViewModel()
        {
            productos = new List<ProductoViewModel>();
            productos.Add(new ProductoViewModel
            {
                id = 0,
                name = "Jabón FIDO 100g",
                oldPrice = 30,
                price = 15.5,
                image = "https://walmartgt.vtexassets.com/arquivos/ids/181222/Jabon-Fido-Para-Perro-100gr-1-28722.jpg?v=637607869570700000",
                video = "https://www.youtube.com/embed/QU-UHULWeFk",
                stock = 100,
                expiration = "Sin expiración",
                currency = "Q",
            });
            productos.Add(new ProductoViewModel
            {
                id = 1,
                name = "Dog Chow",
                oldPrice = 150,
                price = 100,
                image =
                  "https://lamascotita.pe/wp-content/uploads/2019/12/Dog-chow-cachorro-razas-mini-y-peque%C3%B1os.jpg",
                video = "https://www.youtube.com/embed/tm9WCBMtLPI",
                stars = 5,
                stock = 54,
                expiration = "3 de Enero de 2025",
                currency = "Q",
            });
            productos.Add(new ProductoViewModel
            {
                id = 2,
                name = "Cama para mascota",
                nuevo = true,
                price = 120,
                image =
                  "https://i.ebayimg.com/00/s/ODUyWDEyMDA=/z/74UAAOSwUuFW0vO3/$_32.JPG",
                video = "https://www.youtube.com/embed/R3OIdYqyZN0",
                stars = 4,
                stock = 11,
                expiration = "Sin expiración",
                currency = "Q",
            });
        }
    }
}
