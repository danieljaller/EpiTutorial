using EPiServer.Core;

namespace EpiTutorial.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
