using System.ComponentModel.DataAnnotations;

namespace MIS.Models{

  public class Product{
      [Key]
      public int product_id {get;set;}
      public string product_name {get;set;}

      public int qty {get;set;}

      public double price {get;set;}

      //introduce selectable information from product group table
      //include the product group entity here
      public int product_group_id {get;set;} //foreign key
      public ProductGroup productGroup {get;set;}//navigational property

      public string pic {get;set;}


  }
}//ef