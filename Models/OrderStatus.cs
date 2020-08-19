using System.ComponentModel.DataAnnotations;

namespace MIS.Models{

    public class OrderStatus{
        [Key] 
        public int order_status_id {get;set;}
        public string order_status_name {get;set;}
        
    }//ec


}//en