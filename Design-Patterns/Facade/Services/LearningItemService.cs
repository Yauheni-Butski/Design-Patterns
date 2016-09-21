using System.Collections.Generic;

using Facade.Models;

namespace Facade.Services
{
    public class LearningItemService
    {
        //Just for test case I created data storage as field in service
        private readonly List<LearningItem> _learningItems = new List<LearningItem>()
        {
            new LearningItem(1, "Magic Numbers", "Learn how to add numbers with Pr. Zero", "EN", 1),
            new LearningItem(2, "Huge Numbers", "Learn how to multiplicate with Pr. Star", "EN", 1),
            new LearningItem(3, "Honey for the ears", "Learn great russian poems from 19th century", "EN", 1)
        };

        public LearningItem GetLearningItemById(int learningItemId)
        {
            var learningItem = _learningItems.Find(li => li.Id == learningItemId);
            return learningItem;
        }
    }
}
