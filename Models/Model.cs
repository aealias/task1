using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace task1.Models
{
    public class Images
    {
        [Key]
        public int ImgId{ get; set; }
        public string ImgName { get; set; }
     
    }
   
}