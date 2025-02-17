using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <summary>
/// Factory for creating <see cref="ContentPresentationCustomization"/> collections for member types.
/// </summary>
public interface IMemberPresentationCustomizationFactory : IContentPresentationCustomizationFactory<IMemberType>
{
}
