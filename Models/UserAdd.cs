//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations;

//namespace Lab_21.Models
//{
    //public class UserAdd
    //{
        //public UserAdd() //default constuctor
        //{
            //FirstName = "";   // default values 
           //LastName = "";
            //Email = "";
            //PhoneNumber = "";
            //Password = "";
            //Birthdate = "";

       // }
        //Properties

       // [Required] // attributes
        //[RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        //public string FirstName { set; get; }

       // [Required]
        //[RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
        //public string LastName { set; get; }

       // [Required] // attributes
       // [RegularExpression(@"^([A-z0-9]{5,30})@([A-z]{3,10}).([a-z]{2,3})$")]
       // public string Email { set; get; }

       // [Required] // attributes
       // [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
       // public string PhoneNumber { set; get; }

      //  [Required] // attributes
       // [RegularExpression(@"^[A-Z]+[A-z]{1,30}$")]
       // public string Password { set; get; }

       // [Required] // attributes
       // [RegularExpression(@"^(0[1-9]|1[012])[/](0[1-9]|[12][0-9]|3[01])[/](19|20)\d\d$")]
       // public string Birthdate { set; get; }

        // Constructor what a UserAdd should look like
       // public UserAdd(string firstname, string lastname, string email, string phonenumber, string password, string birthdate)
       // {
        //    FirstName = firstname;
          //  LastName = lastname;
          //  Email = email;
          //  PhoneNumber = phonenumber;
          //  Password = password;
          //  Birthdate = birthdate;

      // }


  //  }
//}