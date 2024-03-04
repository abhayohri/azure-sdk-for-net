// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    internal partial class DedicatedCapacityAdministrators : IUtf8JsonSerializable, IJsonModel<DedicatedCapacityAdministrators>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedCapacityAdministrators>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DedicatedCapacityAdministrators>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedCapacityAdministrators>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedCapacityAdministrators)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Members))
            {
                writer.WritePropertyName("members"u8);
                writer.WriteStartArray();
                foreach (var item in Members)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        DedicatedCapacityAdministrators IJsonModel<DedicatedCapacityAdministrators>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedCapacityAdministrators>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedCapacityAdministrators)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedCapacityAdministrators(document.RootElement, options);
        }

        internal static DedicatedCapacityAdministrators DeserializeDedicatedCapacityAdministrators(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> members = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("members"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    members = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DedicatedCapacityAdministrators(members ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DedicatedCapacityAdministrators>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedCapacityAdministrators>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedCapacityAdministrators)} does not support '{options.Format}' format.");
            }
        }

        DedicatedCapacityAdministrators IPersistableModel<DedicatedCapacityAdministrators>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedCapacityAdministrators>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDedicatedCapacityAdministrators(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedCapacityAdministrators)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedCapacityAdministrators>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
