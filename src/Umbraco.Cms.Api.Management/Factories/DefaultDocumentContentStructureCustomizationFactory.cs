using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <inheritdoc />
public class DefaultDocumentContentStructureCustomizationFactory : IDocumentPresentationCustomizationFactory
{
    /// <inheritdoc/>
    public Task<IEnumerable<ContentPresentationCustomization>> CreatePresentationCustomizationsAsync(IContent content)
        => Task.FromResult(Enumerable.Empty<ContentPresentationCustomization>());
}
