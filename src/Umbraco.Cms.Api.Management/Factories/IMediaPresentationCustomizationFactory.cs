using Umbraco.Cms.Api.Management.ViewModels.Content;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Api.Management.Factories;

/// <summary>
/// Factory for creating <see cref="ContentPresentationCustomization"/> collections for media types.
/// </summary>
public interface IMediaPresentationCustomizationFactory : IContentPresentationCustomizationFactory<IMediaType>
{
}
