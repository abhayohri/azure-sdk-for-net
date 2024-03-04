// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Datadog;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class DatadogHostMetadata : IUtf8JsonSerializable, IJsonModel<DatadogHostMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatadogHostMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatadogHostMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHostMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogHostMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(InstallMethod))
            {
                writer.WritePropertyName("installMethod"u8);
                writer.WriteObjectValue(InstallMethod);
            }
            if (Optional.IsDefined(LogsAgent))
            {
                writer.WritePropertyName("logsAgent"u8);
                writer.WriteObjectValue(LogsAgent);
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

        DatadogHostMetadata IJsonModel<DatadogHostMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHostMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogHostMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatadogHostMetadata(document.RootElement, options);
        }

        internal static DatadogHostMetadata DeserializeDatadogHostMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string agentVersion = default;
            DatadogInstallMethod installMethod = default;
            DatadogLogsAgent logsAgent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installMethod = DatadogInstallMethod.DeserializeDatadogInstallMethod(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logsAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logsAgent = DatadogLogsAgent.DeserializeDatadogLogsAgent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatadogHostMetadata(agentVersion, installMethod, logsAgent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatadogHostMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHostMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatadogHostMetadata)} does not support '{options.Format}' format.");
            }
        }

        DatadogHostMetadata IPersistableModel<DatadogHostMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHostMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatadogHostMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatadogHostMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatadogHostMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
