// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallLogSettings : IUtf8JsonSerializable, IJsonModel<FirewallLogSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallLogSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallLogSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallLogSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LogType))
            {
                writer.WritePropertyName("logType"u8);
                writer.WriteStringValue(LogType.Value.ToString());
            }
            if (Optional.IsDefined(LogOption))
            {
                writer.WritePropertyName("logOption"u8);
                writer.WriteStringValue(LogOption.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights"u8);
                writer.WriteObjectValue(ApplicationInsights);
            }
            if (Optional.IsDefined(CommonDestination))
            {
                writer.WritePropertyName("commonDestination"u8);
                writer.WriteObjectValue(CommonDestination);
            }
            if (Optional.IsDefined(TrafficLogDestination))
            {
                writer.WritePropertyName("trafficLogDestination"u8);
                writer.WriteObjectValue(TrafficLogDestination);
            }
            if (Optional.IsDefined(ThreatLogDestination))
            {
                writer.WritePropertyName("threatLogDestination"u8);
                writer.WriteObjectValue(ThreatLogDestination);
            }
            if (Optional.IsDefined(DecryptLogDestination))
            {
                writer.WritePropertyName("decryptLogDestination"u8);
                writer.WriteObjectValue(DecryptLogDestination);
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

        FirewallLogSettings IJsonModel<FirewallLogSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallLogSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallLogSettings(document.RootElement, options);
        }

        internal static FirewallLogSettings DeserializeFirewallLogSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FirewallLogType? logType = default;
            FirewallLogOption? logOption = default;
            FirewallApplicationInsights applicationInsights = default;
            FirewallLogDestination commonDestination = default;
            FirewallLogDestination trafficLogDestination = default;
            FirewallLogDestination threatLogDestination = default;
            FirewallLogDestination decryptLogDestination = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logType = new FirewallLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logOption = new FirewallLogOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationInsights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationInsights = FirewallApplicationInsights.DeserializeFirewallApplicationInsights(property.Value, options);
                    continue;
                }
                if (property.NameEquals("commonDestination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commonDestination = FirewallLogDestination.DeserializeFirewallLogDestination(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trafficLogDestination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficLogDestination = FirewallLogDestination.DeserializeFirewallLogDestination(property.Value, options);
                    continue;
                }
                if (property.NameEquals("threatLogDestination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threatLogDestination = FirewallLogDestination.DeserializeFirewallLogDestination(property.Value, options);
                    continue;
                }
                if (property.NameEquals("decryptLogDestination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    decryptLogDestination = FirewallLogDestination.DeserializeFirewallLogDestination(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallLogSettings(
                logType,
                logOption,
                applicationInsights,
                commonDestination,
                trafficLogDestination,
                threatLogDestination,
                decryptLogDestination,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallLogSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallLogSettings)} does not support '{options.Format}' format.");
            }
        }

        FirewallLogSettings IPersistableModel<FirewallLogSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallLogSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallLogSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallLogSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallLogSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
