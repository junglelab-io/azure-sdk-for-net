// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationProtectableItemsOperations.
    /// </summary>
    public static partial class ReplicationProtectableItemsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// <remarks>
            /// Lists the protectable items in a protection container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            public static IPage<ProtectableItem> ListByReplicationProtectionContainers(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName)
            {
                return operations.ListByReplicationProtectionContainersAsync(fabricName, protectionContainerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// <remarks>
            /// Lists the protectable items in a protection container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectableItem>> ListByReplicationProtectionContainersAsync(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationProtectionContainersWithHttpMessagesAsync(fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of a protectable item.
            /// </summary>
            /// <remarks>
            /// The operation to get the details of a protectable item.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='protectableItemName'>
            /// Protectable item name.
            /// </param>
            public static ProtectableItem Get(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName, string protectableItemName)
            {
                return operations.GetAsync(fabricName, protectionContainerName, protectableItemName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a protectable item.
            /// </summary>
            /// <remarks>
            /// The operation to get the details of a protectable item.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='protectionContainerName'>
            /// Protection container name.
            /// </param>
            /// <param name='protectableItemName'>
            /// Protectable item name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectableItem> GetAsync(this IReplicationProtectableItemsOperations operations, string fabricName, string protectionContainerName, string protectableItemName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, protectionContainerName, protectableItemName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// <remarks>
            /// Lists the protectable items in a protection container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProtectableItem> ListByReplicationProtectionContainersNext(this IReplicationProtectableItemsOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationProtectionContainersNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of protectable items.
            /// </summary>
            /// <remarks>
            /// Lists the protectable items in a protection container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProtectableItem>> ListByReplicationProtectionContainersNextAsync(this IReplicationProtectableItemsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationProtectionContainersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
