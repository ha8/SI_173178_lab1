using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab04.Models
{
    public class FriendModel
    {
        public int FriendModelId { get; set; }
        [Required(ErrorMessage ="ID-to e zadolzhitelno!"),Range(0,200,ErrorMessage ="ID-to mora da bide vo rangot 0-200"), Display(Name ="Friend ID")]
        public int FriendIdentification { get; set; }
        [Required(ErrorMessage ="Imeto e zadolzhitelno!"), Display(Name ="Name")]
        public string Ime { get; set; }
        [Required(ErrorMessage ="Mestoto na zhiveenje e zadolzhitelno!"), Display(Name = "Place")]
        public string MestoZiveenje { get; set; }
    }
}