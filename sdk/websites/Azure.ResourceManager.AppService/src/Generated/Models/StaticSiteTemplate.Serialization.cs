// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteTemplate : IUtf8JsonSerializable, IJsonModel<StaticSiteTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StaticSiteTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateRepositoryUri))
            {
                writer.WritePropertyName("templateRepositoryUrl"u8);
                writer.WriteStringValue(TemplateRepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(RepositoryName))
            {
                writer.WritePropertyName("repositoryName"u8);
                writer.WriteStringValue(RepositoryName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IsPrivate))
            {
                writer.WritePropertyName("isPrivate"u8);
                writer.WriteBooleanValue(IsPrivate.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StaticSiteTemplate IJsonModel<StaticSiteTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteTemplate(document.RootElement, options);
        }

        internal static StaticSiteTemplate DeserializeStaticSiteTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri templateRepositoryUrl = default;
            string owner = default;
            string repositoryName = default;
            string description = default;
            bool? isPrivate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateRepositoryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateRepositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrivate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrivate = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StaticSiteTemplate(
                templateRepositoryUrl,
                owner,
                repositoryName,
                description,
                isPrivate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StaticSiteTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{options.Format}' format.");
            }
        }

        StaticSiteTemplate IPersistableModel<StaticSiteTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticSiteTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSiteTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
