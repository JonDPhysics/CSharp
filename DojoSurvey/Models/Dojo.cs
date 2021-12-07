namespace DojoSurvey.Models
{
    public class Survey
    {
        public string Name;
        public string Location;
        public string FaveLang;
        public string Comment;
        public Survey(string name, string location, string faveLang, string comment)
        {
            Name = name;
            Location = location;
            FaveLang = faveLang;
            Comment = comment;
        }
    }
}