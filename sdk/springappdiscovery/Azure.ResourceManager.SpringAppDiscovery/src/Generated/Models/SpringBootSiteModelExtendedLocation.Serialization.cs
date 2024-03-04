// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SpringAppDiscovery;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootSiteModelExtendedLocation : IUtf8JsonSerializable, IJsonModel<SpringBootSiteModelExtendedLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootSiteModelExtendedLocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SpringBootSiteModelExtendedLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteModelExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteModelExtendedLocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SpringbootsitesModelExtendedLocationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SpringbootsitesModelExtendedLocationType);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        SpringBootSiteModelExtendedLocation IJsonModel<SpringBootSiteModelExtendedLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteModelExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteModelExtendedLocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootSiteModelExtendedLocation(document.RootElement, options);
        }

        internal static SpringBootSiteModelExtendedLocation DeserializeSpringBootSiteModelExtendedLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SpringBootSiteModelExtendedLocation(type, name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpringBootSiteModelExtendedLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteModelExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteModelExtendedLocation)} does not support '{options.Format}' format.");
            }
        }

        SpringBootSiteModelExtendedLocation IPersistableModel<SpringBootSiteModelExtendedLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteModelExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSpringBootSiteModelExtendedLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteModelExtendedLocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootSiteModelExtendedLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
