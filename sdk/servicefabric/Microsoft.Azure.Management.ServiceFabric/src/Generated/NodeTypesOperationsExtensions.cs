// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NodeTypesOperations.
    /// </summary>
    public static partial class NodeTypesOperationsExtensions
    {
            /// <summary>
            /// Gets the list of Node types of the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets all Node types of the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            public static IPage<NodeType> ListByManagedClusters(this INodeTypesOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListByManagedClustersAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Node types of the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets all Node types of the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeType>> ListByManagedClustersAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagedClustersWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Restarts one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a restart on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for restart action.
            /// </param>
            public static void Restart(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters)
            {
                operations.RestartAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Restarts one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a restart on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for restart action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestartAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestartWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Reimages one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Reimages one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a reimage on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for reimage action.
            /// </param>
            public static void Reimage(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters)
            {
                operations.ReimageAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reimages one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Reimages one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a reimage on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for reimage action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReimageAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ReimageWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Deletes one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a delete on the VMs and removes the state from the cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for delete action.
            /// </param>
            public static void DeleteNode(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters)
            {
                operations.DeleteNodeAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Deletes one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a delete on the VMs and removes the state from the cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for delete action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteNodeAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteNodeWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            public static NodeType Get(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName)
            {
                return operations.GetAsync(resourceGroupName, clusterName, nodeTypeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Get a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeType> GetAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The node type resource.
            /// </param>
            public static NodeType CreateOrUpdate(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeType parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The node type resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeType> CreateOrUpdateAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeType parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the configuration of a node type of a given managed cluster.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update the node type configuration.
            /// </param>
            public static NodeType Update(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the configuration of a node type of a given managed cluster.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update the node type configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeType> UpdateAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            public static void Delete(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, nodeTypeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Restarts one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Restarts one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a restart on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for restart action.
            /// </param>
            public static void BeginRestart(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters)
            {
                operations.BeginRestartAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Restarts one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a restart on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for restart action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestartAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Reimages one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Reimages one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a reimage on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for reimage action.
            /// </param>
            public static void BeginReimage(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters)
            {
                operations.BeginReimageAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reimages one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Reimages one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a reimage on the VMs and activate the nodes back again.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for reimage action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginReimageAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginReimageWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Deletes one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a delete on the VMs and removes the state from the cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for delete action.
            /// </param>
            public static void BeginDeleteNode(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters)
            {
                operations.BeginDeleteNodeAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes one or more nodes on the node type.
            /// </summary>
            /// <remarks>
            /// Deletes one or more nodes on the node type. It will disable the fabric
            /// nodes, trigger a delete on the VMs and removes the state from the cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// parameters for delete action.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteNodeAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeActionParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteNodeWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The node type resource.
            /// </param>
            public static NodeType BeginCreateOrUpdate(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeType parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Create or update a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The node type resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeType> BeginCreateOrUpdateAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeType parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the configuration of a node type of a given managed cluster.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update the node type configuration.
            /// </param>
            public static NodeType BeginUpdate(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeUpdateParameters parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, nodeTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the configuration of a node type of a given managed cluster.
            /// </summary>
            /// <remarks>
            /// Update the configuration of a node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update the node type configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeType> BeginUpdateAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, NodeTypeUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            public static void BeginDelete(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, nodeTypeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Service Fabric node type.
            /// </summary>
            /// <remarks>
            /// Delete a Service Fabric node type of a given managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource.
            /// </param>
            /// <param name='nodeTypeName'>
            /// The name of the node type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INodeTypesOperations operations, string resourceGroupName, string clusterName, string nodeTypeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, nodeTypeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of Node types of the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets all Node types of the specified managed cluster.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NodeType> ListByManagedClustersNext(this INodeTypesOperations operations, string nextPageLink)
            {
                return operations.ListByManagedClustersNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Node types of the specified managed cluster.
            /// </summary>
            /// <remarks>
            /// Gets all Node types of the specified managed cluster.
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
            public static async Task<IPage<NodeType>> ListByManagedClustersNextAsync(this INodeTypesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagedClustersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}