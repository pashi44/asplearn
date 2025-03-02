using System.ComponentModel.DataAnnotations;

namespace firstone.Models

{
public class ManModelOne{


private  int id ;
private string?  name;


        //while woriking with coreentity to  bring the primary keys  from a sql db and bind to  this
        //id we  say  data annotations  like we do below 
        [Key]
        [Required]

        public int Id{
get{return id;}
set {id=value;}
}


        public string? Name
        {
            get { return name; }
            set { name = value; }
        }


    }




}