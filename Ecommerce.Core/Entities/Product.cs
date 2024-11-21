namespace Ecommerce.Core.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }=string.Empty;
    public string PictureUrl { get; set; } = string.Empty;

    public ProductType ProductType { get; set; }
    public int  ProductTypeId {  get; set; }

    public ProductBrand productBrand { get; set; }
    public int ProductBrandId { get; set; }



}
