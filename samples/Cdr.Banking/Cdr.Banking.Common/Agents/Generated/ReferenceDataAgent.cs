/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Beef.RefData;
using Beef.WebApi;
using Cdr.Banking.Common.Agents.ServiceAgents;
using Cdr.Banking.Common.Entities;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Agents
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> Web API service agent.
    /// </summary>
    public partial class ReferenceDataAgent : WebApiAgentBase, IReferenceDataServiceAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDataAgent"/> class.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> (where overridding the default value).</param>
        /// <param name="beforeRequest">The <see cref="Action{HttpRequestMessage}"/> to invoke before the <see cref="HttpRequestMessage">Http Request</see> is made (see <see cref="WebApiServiceAgentBase.BeforeRequest"/>).</param>
        public ReferenceDataAgent(HttpClient? httpClient = null, Action<HttpRequestMessage>? beforeRequest = null)
        {
            ServiceAgent = Beef.Factory.Create<IReferenceDataServiceAgent>(httpClient, beforeRequest);
        }
        
        /// <summary>
        /// Gets the underlyng <see cref="IReferenceDataServiceAgent"/> instance.
        /// </summary>
        public IReferenceDataServiceAgent ServiceAgent { get; private set; }

        /// <summary>
        /// Gets all of the <see cref="OpenStatus"/> objects that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.OpenStatusCollection>> OpenStatusGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) => ServiceAgent.OpenStatusGetAllAsync(args, requestOptions);      

        /// <summary>
        /// Gets all of the <see cref="ProductCategory"/> objects that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.ProductCategoryCollection>> ProductCategoryGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) => ServiceAgent.ProductCategoryGetAllAsync(args, requestOptions);      

        /// <summary>
        /// Gets all of the <see cref="AccountUType"/> objects that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.AccountUTypeCollection>> AccountUTypeGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) => ServiceAgent.AccountUTypeGetAllAsync(args, requestOptions);      

        /// <summary>
        /// Gets all of the <see cref="MaturityInstructions"/> objects that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.MaturityInstructionsCollection>> MaturityInstructionsGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) => ServiceAgent.MaturityInstructionsGetAllAsync(args, requestOptions);      

        /// <summary>
        /// Gets all of the <see cref="TransactionType"/> objects that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.TransactionTypeCollection>> TransactionTypeGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) => ServiceAgent.TransactionTypeGetAllAsync(args, requestOptions);      

        /// <summary>
        /// Gets all of the <see cref="TransactionStatus"/> objects that match the filter arguments.
        /// </summary>
        /// <param name="args">The optional <see cref="ReferenceDataFilter"/> arguments.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RefDataNamespace.TransactionStatusCollection>> TransactionStatusGetAllAsync(ReferenceDataFilter? args = null, WebApiRequestOptions? requestOptions = null) => ServiceAgent.TransactionStatusGetAllAsync(args, requestOptions);      

        /// <summary>
        /// Gets the reference data entries for the specified entities and codes from the query string; e.g: api/v1/ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
        /// </summary>
        /// <param name="names">The optional list of reference data names.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        /// <remarks>The reference data objects will need to be manually extracted from the corresponding response content.</remarks>
        public Task<WebApiAgentResult> GetNamedAsync(string[] names, WebApiRequestOptions? requestOptions = null) => ServiceAgent.GetNamedAsync(names, requestOptions);
        
        /// <summary>
        /// Gets the reference data entries for the specified entities and codes from the query string; e.g: api/v1/ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
        /// </summary>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        /// <remarks>The reference data objects will need to be manually extracted from the corresponding response content.</remarks>
        public Task<WebApiAgentResult> GetNamedAsync(WebApiRequestOptions? requestOptions = null) => ServiceAgent.GetNamedAsync(Array.Empty<string>(), requestOptions);
    }
}

#nullable restore