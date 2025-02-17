namespace Umbraco.Cms.Api.Management.ViewModels.Content;

/// <summary>
/// Defines an individual record for content presentation customization.
/// </summary>
public class ContentPresentationCustomization
{
    private ContentPresentationCustomization()
    {
    }

    /// <summary>
    /// Gets or sets the type of content structure for customization.
    /// </summary>
    public ContentPresentationCustomizationType Type { get; private set; }

    /// <summary>
    /// Gets or sets the culture. Null value indicates all or for invariant content.
    /// </summary>
    public string? Culture { get; private set; }

    /// <summary>
    /// Gets or sets the segment.
    /// </summary>
    public string? Segment { get; private set; }

    /// <summary>
    /// Gets or sets the Id of the content structure item.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Gets or sets a value indicating whether the content structure item is read-only.
    /// </summary>
    public bool ReadOnly { get; private set; }

    /// <summary>
    /// Gets or sets a value indicating whether the content structure item is hidden.
    /// </summary>
    public bool Hidden { get; private set; }

    /// <summary>
    /// Gets or sets a default value for the property (only available
    /// when <see cref="Type"/> is <see cref="ContentPresentationCustomizationType.Property"/>).
    /// </summary>
    public object? DefaultValue { get; private set; }

    /// <summary>
    /// Creates a <see cref="ContentPresentationCustomization"/> based on a property container (tab or group).
    /// </summary>
    /// <param name="id">The property type Id.</param>
    /// <param name="culture">The culture. Null value indicates all or for invariant content.</param>
    /// <param name="segment">The segment.</param>
    /// <param name="readOnly">Whether all properties within the tab should be read-only.</param>
    /// <param name="hidden">Whether all properties within the tab should be hidden.</param>
    /// <returns></returns>
    public static ContentPresentationCustomization CreatePropertyContainerCustomization(
        Guid id,
        string? culture = null,
        string? segment = null,
        bool? readOnly = false,
        bool? hidden = false)
        => new()
        {
            Type = ContentPresentationCustomizationType.Container,
            Culture = culture,
            Segment = segment,
            Id = id,
            ReadOnly = readOnly ?? false,
            Hidden = hidden ?? false,
        };

    /// <summary>
    /// Creates a <see cref="ContentPresentationCustomization"/> based on a property.
    /// </summary>
    /// <param name="id">The property Id.</param>
    /// <param name="culture">The culture. Null value indicates all or for invariant content.</param>
    /// <param name="segment">The segment.</param>
    /// <param name="readOnly">Whether the property should be read-only.</param>
    /// <param name="hidden">Whether the property should be hidden.</param>
    /// <param name="defaultValue">THe default value for the property.</param>
    /// <returns></returns>
    public static ContentPresentationCustomization CreatePropertyCustomization(
        Guid id,
        string? culture = null,
        string? segment = null,
        bool? readOnly = false,
        bool? hidden = false,
        object? defaultValue = null)
        => new()
        {
            Type = ContentPresentationCustomizationType.Property,
            Culture = culture,
            Segment = segment,
            Id = id,
            ReadOnly = readOnly ?? false,
            Hidden = hidden ?? false,
            DefaultValue = defaultValue,
        };
}
