using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <summary>
/// Factory for creating <see cref="ContentPresentationCustomization"/> for content (document, media or members).
/// </summary>
public interface IContentPresentationCustomizationFactory<TContent>
    where TContent : IContentBase
{
    /// <summary>
    /// Generates a collection of <see cref="ContentPresentationCustomization"/> rules for rendering a content item for editing.
    /// </summary>
    /// <param name="content">The <see cref="IContent"/> item.</param>
    /// <returns></returns>
    Task<IEnumerable<ContentPresentationCustomization>> CreatePresentationCustomizationsAsync(TContent content);
}
