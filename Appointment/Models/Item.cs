using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Models
{
    public class Item
    {
        [Key]    //to tell the db that this is the pk 
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }

        //Data Anotation to allow me give this item name(internal name in my db) a name I want to display on UI
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
    }
}
