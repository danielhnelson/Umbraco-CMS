using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Api.Management.Factories;
using Umbraco.Cms.Api.Management.ViewModels.DocumentType;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Services.OperationStatus;

namespace Umbraco.Cms.Api.Management.Controllers.DocumentType;

[ApiVersion("1.0")]
public class ByKeyDocumentTypeController : DocumentTypeControllerBase
{
    private readonly IContentTypeService _contentTypeService;
    private readonly IDocumentTypePresentationFactory _documentTypePresentationFactory;

    [Obsolete("Please use the constructor taking IDocumentTypePresentationFactory. This constructor will be removed in Umbraco 17.")]
    public ByKeyDocumentTypeController(IContentTypeService contentTypeService, IUmbracoMapper umbracoMapper)
        : this(
              contentTypeService,
              umbracoMapper,
              StaticServiceProvider.Instance.GetRequiredService<IDocumentTypePresentationFactory>())
    {
    }

    [ActivatorUtilitiesConstructor]
    public ByKeyDocumentTypeController(IContentTypeService contentTypeService, IUmbracoMapper umbracoMapper, IDocumentTypePresentationFactory documentTypePresentationFactory)
    {
        _contentTypeService = contentTypeService;
        _documentTypePresentationFactory = documentTypePresentationFactory;
    }

    [HttpGet("{id:guid}")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(DocumentTypeResponseModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ByKey(CancellationToken cancellationToken, Guid id)
    {
        IContentType? contentType = await _contentTypeService.GetAsync(id);
        if (contentType is null)
        {
            return OperationStatusResult(ContentTypeOperationStatus.NotFound);
        }

        DocumentTypeResponseModel model = await _documentTypePresentationFactory.CreateResponseModelAsync(contentType);

        return Ok(model);
    }
}
