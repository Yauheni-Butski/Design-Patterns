using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using Facade.Models;

namespace Facade.Utils
{
    public class CartridgeGenerator
    {
        public XDocument GenerateCartridge(LearningItem learningItem, List<string> keywords, List<string> standards)
        {
            var xCartridgeDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement(
                    "manifest",
                    new XAttribute("identifier", learningItem.Id),
                    this.GenerateLearningItemElement(learningItem),
                    new XElement("keywords", this.GenerateKeywordElements(keywords)),
                    new XElement("standards", this.GenerateStandardElements(standards))));

            return xCartridgeDoc;
        }

        private XElement GenerateLearningItemElement(LearningItem learningItem)
        {
            return new XElement("metadata",
                new XElement(
                "general",
                new XElement("identifier", learningItem.Id),
                learningItem.Title == null ? null : new XElement("title", learningItem.Title),
                learningItem.Description == null ? null : new XElement("description", learningItem.Description),
                learningItem.LanguageCode == null ? null : new XElement("language", learningItem.LanguageCode),
                new XElement("versionNumber", learningItem.VersionNumber)));
        }

        private List<XElement> GenerateKeywordElements(List<string> keywords)
        {
            var keywordElements = keywords.Select(kw =>
                new XElement("keyword", kw)).ToList();
            return keywordElements;
        }

        private List<XElement> GenerateStandardElements(List<string> standards)
        {
            var standardElements = standards.Select(s =>
                new XElement("standard", s)).ToList();
            return standardElements;
        }
    }
}
