using System.ComponentModel.DataAnnotations;

namespace MIS.Models{

  public class ProductGroup {
      [Key]
      public int product_group_id {get;set;}
      public string product_group_name {get;set;}
     /// public string product_sub_group_name {get;set;}
  }
}//ef

