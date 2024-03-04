// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class DataStoreUtilizationDetails : IUtf8JsonSerializable, IJsonModel<DataStoreUtilizationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataStoreUtilizationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataStoreUtilizationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreUtilizationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataStoreUtilizationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TotalSnapshotsSupported))
            {
                writer.WritePropertyName("totalSnapshotsSupported"u8);
                writer.WriteNumberValue(TotalSnapshotsSupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalSnapshotsCreated))
            {
                writer.WritePropertyName("totalSnapshotsCreated"u8);
                writer.WriteNumberValue(TotalSnapshotsCreated.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DataStoreName))
            {
                writer.WritePropertyName("dataStoreName"u8);
                writer.WriteStringValue(DataStoreName);
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

        DataStoreUtilizationDetails IJsonModel<DataStoreUtilizationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreUtilizationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataStoreUtilizationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataStoreUtilizationDetails(document.RootElement, options);
        }

        internal static DataStoreUtilizationDetails DeserializeDataStoreUtilizationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? totalSnapshotsSupported = default;
            long? totalSnapshotsCreated = default;
            string dataStoreName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalSnapshotsSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSnapshotsSupported = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalSnapshotsCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSnapshotsCreated = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataStoreName"u8))
                {
                    dataStoreName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataStoreUtilizationDetails(totalSnapshotsSupported, totalSnapshotsCreated, dataStoreName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataStoreUtilizationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreUtilizationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataStoreUtilizationDetails)} does not support '{options.Format}' format.");
            }
        }

        DataStoreUtilizationDetails IPersistableModel<DataStoreUtilizationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataStoreUtilizationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataStoreUtilizationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataStoreUtilizationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataStoreUtilizationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
