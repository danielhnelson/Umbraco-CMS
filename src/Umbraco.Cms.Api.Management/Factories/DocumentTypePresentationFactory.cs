using Umbraco.Cms.Api.Management.ViewModels.DocumentType;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

internal sealed class DocumentTypePresentationFactory : IDocumentTypePresentationFactory
{
    private readonly IUmbracoMapper _umbracoMapper;
    private readonly IDocumentPresentationCustomizationFactory _documentPresentationCustomizationFactory;

    public DocumentTypePresentationFactory(
        IUmbracoMapper umbracoMapper,
        IDocumentPresentationCustomizationFactory documentPresentationCustomizationFactory)
    {
        _umbracoMapper = umbracoMapper;
        _documentPresentationCustomizationFactory = documentPresentationCustomizationFactory;
    }

    public async Task<DocumentTypeResponseModel> CreateResponseModelAsync(IContentType contentType)
    {
        DocumentTypeResponseModel responseModel = _umbracoMapper.Map<DocumentTypeResponseModel>(contentType)!;

        responseModel.PresentationCustomization = await _documentPresentationCustomizationFactory.CreatePresentationCustomizationsAsync(contentType);

        return responseModel;
    }
}
