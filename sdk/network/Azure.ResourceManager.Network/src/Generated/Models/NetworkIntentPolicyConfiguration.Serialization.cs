// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkIntentPolicyConfiguration : IUtf8JsonSerializable, IJsonModel<NetworkIntentPolicyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkIntentPolicyConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkIntentPolicyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkIntentPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkIntentPolicyConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkIntentPolicyName))
            {
                writer.WritePropertyName("networkIntentPolicyName"u8);
                writer.WriteStringValue(NetworkIntentPolicyName);
            }
            if (Optional.IsDefined(SourceNetworkIntentPolicy))
            {
                writer.WritePropertyName("sourceNetworkIntentPolicy"u8);
                writer.WriteObjectValue(SourceNetworkIntentPolicy);
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

        NetworkIntentPolicyConfiguration IJsonModel<NetworkIntentPolicyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkIntentPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkIntentPolicyConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkIntentPolicyConfiguration(document.RootElement, options);
        }

        internal static NetworkIntentPolicyConfiguration DeserializeNetworkIntentPolicyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string networkIntentPolicyName = default;
            NetworkIntentPolicy sourceNetworkIntentPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkIntentPolicyName"u8))
                {
                    networkIntentPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceNetworkIntentPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceNetworkIntentPolicy = NetworkIntentPolicy.DeserializeNetworkIntentPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkIntentPolicyConfiguration(networkIntentPolicyName, sourceNetworkIntentPolicy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkIntentPolicyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkIntentPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkIntentPolicyConfiguration)} does not support '{options.Format}' format.");
            }
        }

        NetworkIntentPolicyConfiguration IPersistableModel<NetworkIntentPolicyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkIntentPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkIntentPolicyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkIntentPolicyConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkIntentPolicyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
