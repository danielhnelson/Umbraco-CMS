using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <inheritdoc />
public class DefaultMemberContentStructureCustomizationFactory : IMemberPresentationCustomizationFactory
{
    /// <inheritdoc/>
    public Task<IEnumerable<ContentPresentationCustomization>> CreatePresentationCustomizationsAsync(IMember content)
        => Task.FromResult(Enumerable.Empty<ContentPresentationCustomization>());
}
