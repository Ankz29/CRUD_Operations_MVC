using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Operations_Using_EF.Models
{
    public class Student
    {
        private int Id;
        private string Name;
        private string Email;
        private string City;

    [Required(ErrorMessage="Id is required !!")]
        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

       [Required(ErrorMessage="Name is required !!")]
        public string NAME
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        
        [Required(ErrorMessage="Email id is required !!")]
        public string EMAIL
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        
        [Required(ErrorMessage="City is needed, for better alignment.")]
        public string CITY
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
           
    }
}