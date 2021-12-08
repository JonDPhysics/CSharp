using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Display(Name = "Your Name: ")]
        public string Name {get; set;}
        [Display(Name = "Dojo Location: ")]
        public string Location {get; set;}
        [Display(Name = "Favorite Language: ")]
        public string FaveLang {get; set;}
        [Display(Name = "Comment (optional): ")]
        public string Comment {get; set;}
        public Survey(string name, string location, string faveLang, string comment)
        {
            Name = name;
            Location = location;
            FaveLang = faveLang;
            Comment = comment;
        }
    }
}