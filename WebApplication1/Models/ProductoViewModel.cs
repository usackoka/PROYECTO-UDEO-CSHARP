namespace WebApplication1.Models
{
    /**
     * Esquema de un producto
     * id: identificador único, puede ser usado como identificador en un futuro
     * name: nombre del producto
     * description: alguna descripción del producto
     * oldPrice: precio antiguo del producto, se usa para mostrar ofertas, puede no incluirse y no se muestra la oferta
     * price: precio del producto
     * image: imagen de internet o local del producto
     * video: ruta del video del producto
     * stock: cantidad del producto en bodega
     * expiration: cuando expira el producto (caducidad)
     * stars: cantidad de estrellas del producto, si se deja a 0 o simplemente no se incluye esta propiedad, no se cargan las estrellas
     * currency: texto del tipo de moneda (Q, $, L, etc...)
     * new: Etiqueta de producto nuevo, para mostrar novedades en la página
     */

    public class ProductoViewModel
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public double? price { get; set; }
        public double? oldPrice { get; set; }
        public string? image { get; set; }
        public string? video { get; set; }
        public int? stock { get; set; }
        public int? stars { get; set; }
        public string? expiration { get; set; }
        public string? currency { get; set; }
        public bool nuevo { get; set; }
    }
}
