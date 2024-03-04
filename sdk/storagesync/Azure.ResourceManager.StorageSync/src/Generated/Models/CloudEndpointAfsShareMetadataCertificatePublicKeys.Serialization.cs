// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudEndpointAfsShareMetadataCertificatePublicKeys : IUtf8JsonSerializable, IJsonModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointAfsShareMetadataCertificatePublicKeys)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FirstKey))
            {
                writer.WritePropertyName("firstKey"u8);
                writer.WriteStringValue(FirstKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondKey))
            {
                writer.WritePropertyName("secondKey"u8);
                writer.WriteStringValue(SecondKey);
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

        CloudEndpointAfsShareMetadataCertificatePublicKeys IJsonModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudEndpointAfsShareMetadataCertificatePublicKeys)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointAfsShareMetadataCertificatePublicKeys(document.RootElement, options);
        }

        internal static CloudEndpointAfsShareMetadataCertificatePublicKeys DeserializeCloudEndpointAfsShareMetadataCertificatePublicKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firstKey = default;
            string secondKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstKey"u8))
                {
                    firstKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondKey"u8))
                {
                    secondKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudEndpointAfsShareMetadataCertificatePublicKeys(firstKey, secondKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointAfsShareMetadataCertificatePublicKeys)} does not support '{options.Format}' format.");
            }
        }

        CloudEndpointAfsShareMetadataCertificatePublicKeys IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudEndpointAfsShareMetadataCertificatePublicKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudEndpointAfsShareMetadataCertificatePublicKeys)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudEndpointAfsShareMetadataCertificatePublicKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
