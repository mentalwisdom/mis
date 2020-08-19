using System.ComponentModel.DataAnnotations;

namespace MIS.Models{

    public class ProductOrder{
        [Key]
        public int product_order_id {get;set;}

        //foriegn key the connection key to the product table/entity
        public int product_id {get;set;}
        public Product product{get;set;}

        public int qty {get;set;}
        public string firstname {get;set;}
        public string lastname {get;set;}
        public string email {get;set;}

        public int order_status_id {get;set;}
        public OrderStatus orderStaus{get;set;} //navigation property

    }//ec


}//en