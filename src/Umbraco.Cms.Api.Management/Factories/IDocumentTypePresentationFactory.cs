using Umbraco.Cms.Api.Management.ViewModels.DocumentType;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

public interface IDocumentTypePresentationFactory
{
    Task<DocumentTypeResponseModel> CreateResponseModelAsync(IContentType contentType);
}
