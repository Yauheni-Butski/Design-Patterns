using System.Collections.Generic;

namespace Facade.Services
{
    public class KeywordService
    {
        //Just for test case I created data storage as field in service
        private readonly Dictionary<int, List<string>> _learningItemKeywords = new Dictionary<int, List<string>>()
        {
            { 1, new List<string>() { "addition", "calculation", "arithmetic"} },
            { 2, new List<string>() { "multiplication", "calculation", "arithmetic" } },
            { 3, new List<string>() { "poem", "19th century", "literature" } }
        };

        public List<string> GetKeywordsByLearningItemId(int learningItemId)
        {
            var keywords = _learningItemKeywords.ContainsKey(learningItemId) ?
                           _learningItemKeywords[learningItemId] :
                           new List<string>();

            return keywords;
        }
    }
}
