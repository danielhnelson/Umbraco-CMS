using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <inheritdoc />
public class DefaultMediaContentStructureCustomizationFactory : IMediaPresentationCustomizationFactory
{
    /// <inheritdoc/>
    public Task<IEnumerable<ContentPresentationCustomization>> CreatePresentationCustomizationsAsync(IMediaType contentType)
        => Task.FromResult(Enumerable.Empty<ContentPresentationCustomization>());
}
