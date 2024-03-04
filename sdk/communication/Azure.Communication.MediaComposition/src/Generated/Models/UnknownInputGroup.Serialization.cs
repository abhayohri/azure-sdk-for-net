// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    internal partial class UnknownInputGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Position))
            {
                writer.WritePropertyName("position"u8);
                writer.WriteObjectValue(Position);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteStringValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteStringValue(Height);
            }
            if (Optional.IsDefined(Layer))
            {
                writer.WritePropertyName("layer"u8);
                writer.WriteStringValue(Layer);
            }
            if (Optional.IsDefined(ScalingMode))
            {
                writer.WritePropertyName("scalingMode"u8);
                writer.WriteStringValue(ScalingMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static UnknownInputGroup DeserializeUnknownInputGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InputGroupType kind = "Unknown";
            InputPosition position = default;
            string width = default;
            string height = default;
            string layer = default;
            ScalingMode? scalingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new InputGroupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = InputPosition.DeserializeInputPosition(property.Value);
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layer"u8))
                {
                    layer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scalingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingMode = new ScalingMode(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownInputGroup(
                kind,
                position,
                width,
                height,
                layer,
                scalingMode);
        }
    }
}
