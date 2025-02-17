using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <inheritdoc />
public class DefaultMediaContentStructureCustomizationFactory : IMediaPresentationCustomizationFactory
{
    /// <inheritdoc/>
    public Task<IEnumerable<ContentPresentationCustomization>> CreatePresentationCustomizationsAsync(IMedia content)
        => Task.FromResult(Enumerable.Empty<ContentPresentationCustomization>());
}
