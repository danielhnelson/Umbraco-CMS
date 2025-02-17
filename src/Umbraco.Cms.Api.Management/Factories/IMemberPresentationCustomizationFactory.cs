using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <summary>
/// Factory for creating a collection of <see cref="ContentPresentationCustomization"/> rules for rendering a member for editing.
/// </summary>
public interface IMemberPresentationCustomizationFactory : IContentPresentationCustomizationFactory<IMember>
{
}
