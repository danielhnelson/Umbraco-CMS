using Umbraco.Cms.Api.Management.ViewModels.MediaType;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

public interface IMediaTypePresentationFactory
{
    Task<MediaTypeResponseModel> CreateResponseModelAsync(IMediaType mediaType);
}
