// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UserArtifactSource : IUtf8JsonSerializable, IJsonModel<UserArtifactSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserArtifactSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UserArtifactSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserArtifactSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("mediaLink"u8);
            writer.WriteStringValue(MediaLink);
            if (Optional.IsDefined(DefaultConfigurationLink))
            {
                writer.WritePropertyName("defaultConfigurationLink"u8);
                writer.WriteStringValue(DefaultConfigurationLink);
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

        UserArtifactSource IJsonModel<UserArtifactSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserArtifactSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserArtifactSource(document.RootElement, options);
        }

        internal static UserArtifactSource DeserializeUserArtifactSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mediaLink = default;
            string defaultConfigurationLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaLink"u8))
                {
                    mediaLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultConfigurationLink"u8))
                {
                    defaultConfigurationLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UserArtifactSource(mediaLink, defaultConfigurationLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserArtifactSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserArtifactSource)} does not support '{options.Format}' format.");
            }
        }

        UserArtifactSource IPersistableModel<UserArtifactSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserArtifactSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserArtifactSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserArtifactSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserArtifactSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
