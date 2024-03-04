// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class IngressConfig : IUtf8JsonSerializable, IJsonModel<IngressConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IngressConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IngressConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngressConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IngressConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReadTimeoutInSeconds))
            {
                writer.WritePropertyName("readTimeoutInSeconds"u8);
                writer.WriteNumberValue(ReadTimeoutInSeconds.Value);
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

        IngressConfig IJsonModel<IngressConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngressConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IngressConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIngressConfig(document.RootElement, options);
        }

        internal static IngressConfig DeserializeIngressConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? readTimeoutInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IngressConfig(readTimeoutInSeconds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IngressConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngressConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IngressConfig)} does not support '{options.Format}' format.");
            }
        }

        IngressConfig IPersistableModel<IngressConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngressConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIngressConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IngressConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IngressConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
