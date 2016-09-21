using Facade.Services;
using Facade.Utils;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test system without using Facade
            var learningItemService = new LearningItemService();
            var keywordService = new KeywordService();
            var standardService = new StandardService();
            var cartridgeGenerator = new CartridgeGenerator();
            var dataCompressor = new DataCompressor();

            var selectedLearningItemId = 1;
            var learningItem = learningItemService.GetLearningItemById(selectedLearningItemId);
            var keywords = keywordService.GetKeywordsByLearningItemId(selectedLearningItemId);
            var standards = standardService.GetStandardsByLearningItemId(selectedLearningItemId);

            var cartridgeDocument = cartridgeGenerator.GenerateCartridge(learningItem, keywords, standards);
            
            //And finally, create needed file
            dataCompressor.Archive(cartridgeDocument, "cartridge.ccd");

            //Test system using Facade
            var commonCartridgeFacade = new CommonCartridgeFacade(learningItemService, keywordService, standardService, cartridgeGenerator, dataCompressor);
            commonCartridgeFacade.ExportLearningItemIntoCartridge(selectedLearningItemId, "cartridgeFacade.ccd");

        }
    }
}
