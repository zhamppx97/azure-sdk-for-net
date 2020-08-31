// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CertificatesOperations.
    /// </summary>
    public static partial class CertificatesOperationsExtensions
    {
            /// <summary>
            /// Get the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static CertificateResource Get(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> GetAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            public static CertificateResource CreateOrUpdate(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CertificateResource certificateResource)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, certificateName, certificateResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> CreateOrUpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CertificateResource certificateResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, certificateResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static void Delete(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all the certificates of one user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static IPage<CertificateResource> List(this ICertificatesOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.ListAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the certificates of one user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateResource>> ListAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            public static CertificateResource BeginCreateOrUpdate(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CertificateResource certificateResource)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, certificateName, certificateResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> BeginCreateOrUpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CertificateResource certificateResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, certificateResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static void BeginDelete(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all the certificates of one user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CertificateResource> ListNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the certificates of one user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateResource>> ListNextAsync(this ICertificatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}