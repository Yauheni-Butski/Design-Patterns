namespace Facade.Models
{
    public class LearningItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LanguageCode { get; set; }
        public int VersionNumber { get; set; }

        public LearningItem(int id, string title, string description, string languageCode, int versionNumber)
        {
            Id = id;
            Title = title;
            Description = description;
            LanguageCode = languageCode;
            VersionNumber = versionNumber;
        }

        public LearningItem()
        {
            
        }
    }
}
