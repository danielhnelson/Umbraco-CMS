using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Api.Management.Factories;
using Umbraco.Cms.Api.Management.ViewModels.MediaType;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Services.OperationStatus;

namespace Umbraco.Cms.Api.Management.Controllers.MediaType;

[ApiVersion("1.0")]
public class ByKeyMediaTypeController : MediaTypeControllerBase
{
    private readonly IMediaTypeService _mediaTypeService;
    private readonly IMediaTypePresentationFactory _mediaTypePresentationFactory;

    [Obsolete("Please use the constructor taking IMediaTypePresentationFactory. This constructor will be removed in Umbraco 17.")]
    public ByKeyMediaTypeController(IMediaTypeService mediaTypeService, IUmbracoMapper umbracoMapper)
        : this(
              mediaTypeService,
              umbracoMapper,
              StaticServiceProvider.Instance.GetRequiredService<IMediaTypePresentationFactory>())
    {
    }

    [ActivatorUtilitiesConstructor]
    public ByKeyMediaTypeController(IMediaTypeService mediaTypeService, IUmbracoMapper umbracoMapper, IMediaTypePresentationFactory mediaTypePresentationFactory)
    {
        _mediaTypeService = mediaTypeService;
        _mediaTypePresentationFactory = mediaTypePresentationFactory;
    }

    [HttpGet("{id:guid}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(MediaTypeResponseModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ByKey(CancellationToken cancellationToken, Guid id)
    {
        IMediaType? mediaType = await _mediaTypeService.GetAsync(id);
        if (mediaType == null)
        {
            return OperationStatusResult(ContentTypeOperationStatus.NotFound);
        }

        MediaTypeResponseModel model = await _mediaTypePresentationFactory.CreateResponseModelAsync(mediaType);

        return await Task.FromResult(Ok(model));
    }
}
