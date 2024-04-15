// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceHealth.Tests
{
    public class ResourceHealthManagementTestBase : ManagementRecordedTestBase<ResourceHealthManagementTestEnvironment>
    {
        public SubscriptionResource Subscription { get; set; }
        protected ArmClient Client { get; private set; }

        public ResourceGroupResource ResourceGroup { get; private set; }

        public List<GenericResource> Resources { get; private set; }

        protected ResourceHealthManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected ResourceHealthManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClientAsync()
        {
            Client = GetArmClient();
            Subscription = await Client.GetDefaultSubscriptionAsync();
            Console.WriteLine($"Subscription: {Subscription.Data.SubscriptionId}");
            var resourceGroupCollection = Subscription.GetResourceGroups();
            ResourceGroup = await resourceGroupCollection.GetAsync(ResourceHealthManagementTestEnvironment.Instance.ResourceGroup);
            Console.WriteLine($"ResourceGroup: {ResourceGroup.Data.Name}");
            foreach ( GenericResource res in ResourceGroup.GetGenericResources())
            {
                Resources.Add(res);
                Console.WriteLine($"Resources: {res.Id}");
            }
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }
    }
}
