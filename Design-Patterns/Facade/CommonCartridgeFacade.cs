using Facade.Services;
using Facade.Utils;

namespace Facade
{
    public class CommonCartridgeFacade
    {
        private readonly LearningItemService _learningItemService;
        private readonly KeywordService _keywordService;
        private readonly StandardService _standardService;

        private readonly CartridgeGenerator _cartridgeGenerator;
        private readonly DataCompressor _dataCompressor;

        public CommonCartridgeFacade(LearningItemService learningItemService,
                                     KeywordService keywordService,
                                     StandardService standardService,
                                     CartridgeGenerator cartridgeGenerator,
                                     DataCompressor dataCompressor)
        {
            _learningItemService = learningItemService;
            _keywordService = keywordService;
            _standardService = standardService;
            _cartridgeGenerator = cartridgeGenerator;
            _dataCompressor = dataCompressor;
        }

        public void ExportLearningItemIntoCartridge(int learningItemId, string cartridgeFileName)
        {
            var learningItem = _learningItemService.GetLearningItemById(learningItemId);
            var keywords = _keywordService.GetKeywordsByLearningItemId(learningItemId);
            var standards = _standardService.GetStandardsByLearningItemId(learningItemId);

            var cartridgeDocument = _cartridgeGenerator.GenerateCartridge(learningItem, keywords, standards);

            _dataCompressor.Archive(cartridgeDocument, cartridgeFileName);
        }
    }
}
