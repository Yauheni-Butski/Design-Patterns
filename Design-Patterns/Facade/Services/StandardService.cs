using System.Collections.Generic;

namespace Facade.Services
{
    public class StandardService
    {
        //Just for test case I created data storage as field in service
        private readonly Dictionary<int, List<string>> _learningItemStandards = new Dictionary<int, List<string>>()
        {
            { 1, new List<string>() { "1. Students will demonstrate concepts of number sense by using one-to-one correspondence, counting in sequence by ones from 1 to 20, counting backward from 10, recognizing numerals 0-9, and comparing sets of objects up to 10 by using vocabulary terms including more than, less than, most, or least.",
                                      "2. Number and Operations: Students will recognize that a whole object can be divided into parts.",
                                      "3. Dividing a whole object into equal parts." } },
            { 2, new List<string>() { "1. Algebra: Students will replicate patterns using concrete objects.",
                                      "2. Geometry: Students will create combinations of rectangles, squares, circles, and triangles using shapes or drawings.",
                                      "3. Determining the value of a number that is 10 more or 10 less than a given number." } },
            { 3, new List<string>() {"1. Use words that describe and represent real-life objects and actions.",
                                     "2. Demonstrate letter-sound association, including matching letters to corresponding spoken sounds and blending letter sounds into one-syllable words, using printed materials.",
                                     "3. Exhibit phonemic awareness, including identifying and categorizing phonemes, orally blending phonemes into one-syllable words, segmenting one-syllable words into phonemes, and rhyming." } }
        };

        public List<string> GetStandardsByLearningItemId(int learningItemId)
        {
            var standards = _learningItemStandards.ContainsKey(learningItemId) ?
               _learningItemStandards[learningItemId] :
               new List<string>();

            return standards;
        }
    }
}
