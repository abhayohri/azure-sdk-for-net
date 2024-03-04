// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class SparkProfile : IUtf8JsonSerializable, IJsonModel<SparkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SparkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultStorageUriString))
            {
                writer.WritePropertyName("defaultStorageUrl"u8);
                writer.WriteStringValue(DefaultStorageUriString);
            }
            if (Optional.IsDefined(MetastoreSpec))
            {
                writer.WritePropertyName("metastoreSpec"u8);
                writer.WriteObjectValue(MetastoreSpec);
            }
            if (Optional.IsDefined(UserPluginsSpec))
            {
                writer.WritePropertyName("userPluginsSpec"u8);
                writer.WriteObjectValue(UserPluginsSpec);
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

        SparkProfile IJsonModel<SparkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkProfile(document.RootElement, options);
        }

        internal static SparkProfile DeserializeSparkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string defaultStorageUrl = default;
            SparkMetastoreSpec metastoreSpec = default;
            SparkUserPluginListResult userPluginsSpec = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultStorageUrl"u8))
                {
                    defaultStorageUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metastoreSpec = SparkMetastoreSpec.DeserializeSparkMetastoreSpec(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userPluginsSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userPluginsSpec = SparkUserPluginListResult.DeserializeSparkUserPluginListResult(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkProfile(defaultStorageUrl, metastoreSpec, userPluginsSpec, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SparkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SparkProfile)} does not support '{options.Format}' format.");
            }
        }

        SparkProfile IPersistableModel<SparkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSparkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SparkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SparkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
