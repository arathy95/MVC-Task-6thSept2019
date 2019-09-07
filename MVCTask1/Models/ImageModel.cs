using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCTask1.Models
{
    public class ImageModel
    {
        public ImageModel(){ }
        public ImageModel(int id,string name,string email,string pass,string mobile,string image,string gender,int sid)
        {
            this.UserId = id;
            this.UserName = name;
            this.EmailId = email;
            this.UserImageURL = image;
            this.Password = pass;
            this.MobileNo = mobile;
            this.Gender = gender;
            this.StateId = new StateModel() { StateId = sid };

        }
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Enter user name.")]
        [Display(Name ="User Name*")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter EmailId.")]
        [Display(Name = "EmailId*")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }


        [Required(ErrorMessage = "Enter Password.")]
        [Display(Name = "Password*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password.")]
        [Display(Name = "Confirm Password*")]
        [Compare("Password",ErrorMessage ="Please Enter the correct Password.")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmPassword  { get; set; }
        public string MobileNo { get; set; }
        public string UserImageURL { get; set; }
        public string Gender { get; set; }
        public StateModel StateId { get; set; }

        public List<StateModel> GetStates
        {
            get
            {
                return new List<StateModel>()
                {
                    new StateModel()
                    {
                        StateId=1,
                        StateName="Gujarat",
                    },

                    new StateModel()
                    {
                        StateId=2,
                        StateName="Maharashtra",
                    },
                };
            }
        }
    }
}