// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense;
using Azure.ResourceManager.IotFirmwareDefense.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Samples
{
    public partial class Sample_FirmwareAnalysisSummaryResource
    {
        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareAnalysisSummaryResource created on azure
            // for more information of creating FirmwareAnalysisSummaryResource, please refer to the document of FirmwareAnalysisSummaryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            ResourceIdentifier firmwareAnalysisSummaryResourceId = FirmwareAnalysisSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId, summaryName);
            FirmwareAnalysisSummaryResource firmwareAnalysisSummary = client.GetFirmwareAnalysisSummaryResource(firmwareAnalysisSummaryResourceId);

            // invoke the operation
            FirmwareAnalysisSummaryResource result = await firmwareAnalysisSummary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareAnalysisSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareAnalysisSummaryResource created on azure
            // for more information of creating FirmwareAnalysisSummaryResource, please refer to the document of FirmwareAnalysisSummaryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            ResourceIdentifier firmwareAnalysisSummaryResourceId = FirmwareAnalysisSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId, summaryName);
            FirmwareAnalysisSummaryResource firmwareAnalysisSummary = client.GetFirmwareAnalysisSummaryResource(firmwareAnalysisSummaryResourceId);

            // invoke the operation
            FirmwareAnalysisSummaryResource result = await firmwareAnalysisSummary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareAnalysisSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
