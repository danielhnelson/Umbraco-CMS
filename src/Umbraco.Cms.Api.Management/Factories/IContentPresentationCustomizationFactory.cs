using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <summary>
/// Factory for creating <see cref="ContentPresentationCustomization"/> collections for content types.
/// </summary>
public interface IContentPresentationCustomizationFactory<TContentType>
    where TContentType: IContentTypeComposition
{
    /// <summary>
    /// Generates a collection of <see cref="ContentPresentationCustomization"/> rules for rendering a content item for editing.
    /// </summary>
    /// <param name="contentType">The content type.</param>
    /// <returns></returns>
    Task<IEnumerable<ContentPresentationCustomization>> CreatePresentationCustomizationsAsync(TContentType contentType);
}
