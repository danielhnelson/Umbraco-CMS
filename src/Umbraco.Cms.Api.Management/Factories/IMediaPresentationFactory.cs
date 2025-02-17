using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Api.Management.ViewModels.Media;
using Umbraco.Cms.Api.Management.ViewModels.Media.Item;
using Umbraco.Cms.Api.Management.ViewModels.MediaType;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Entities;

namespace Umbraco.Cms.Api.Management.Factories;

public interface IMediaPresentationFactory
{
    [Obsolete("Use CreateResponseModelAsync instead. This method will be removed in Umbraco 17.")]
    MediaResponseModel CreateResponseModel(IMedia media);

    Task<MediaResponseModel> CreateResponseModelAsync(IMedia media)
#pragma warning disable CS0618 // Type or member is obsolete
        => Task.FromResult(CreateResponseModel(media));
#pragma warning restore CS0618 // Type or member is obsolete

    MediaItemResponseModel CreateItemResponseModel(IMediaEntitySlim entity);

    IEnumerable<VariantItemResponseModel> CreateVariantsItemResponseModels(IMediaEntitySlim entity);

    MediaTypeReferenceResponseModel CreateMediaTypeReferenceResponseModel(IMediaEntitySlim entity);
}
