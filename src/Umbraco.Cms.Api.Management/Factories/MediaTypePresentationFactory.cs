using Umbraco.Cms.Api.Management.ViewModels.MediaType;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

internal sealed class MediaTypePresentationFactory : IMediaTypePresentationFactory
{
    private readonly IUmbracoMapper _umbracoMapper;
    private readonly IMediaPresentationCustomizationFactory _mediaPresentationCustomizationFactory;

    public MediaTypePresentationFactory(
        IUmbracoMapper umbracoMapper,
        IMediaPresentationCustomizationFactory mediaPresentationCustomizationFactory)
    {
        _umbracoMapper = umbracoMapper;
        _mediaPresentationCustomizationFactory = mediaPresentationCustomizationFactory;
    }

    public async Task<MediaTypeResponseModel> CreateResponseModelAsync(IMediaType contentType)
    {
        MediaTypeResponseModel responseModel = _umbracoMapper.Map<MediaTypeResponseModel>(contentType)!;

        responseModel.PresentationCustomization = await _mediaPresentationCustomizationFactory.CreatePresentationCustomizationsAsync(contentType);

        return responseModel;
    }
}
