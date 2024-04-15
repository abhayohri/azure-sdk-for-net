// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventImpact
    {
        internal static ResourceHealthEventImpact DeserializeResourceHealthEventImpact(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> impactedService = default;
            Optional<string> impactedServiceGuid = default;
            Optional<IReadOnlyList<ResourceHealthEventImpactedServiceRegion>> impactedRegions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("impactedService"u8))
                {
                    impactedService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("impactedServiceGuid"u8))
                {
                    impactedServiceGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("impactedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceHealthEventImpactedServiceRegion> array = new List<ResourceHealthEventImpactedServiceRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceHealthEventImpactedServiceRegion.DeserializeResourceHealthEventImpactedServiceRegion(item));
                    }
                    impactedRegions = array;
                    continue;
                }
            }
            return new ResourceHealthEventImpact(impactedService.Value, impactedServiceGuid.Value, Optional.ToList(impactedRegions));
        }
    }
}
