// <auto-generated/>
#pragma warning disable CS0618
using CleanAspire.Api.Client.Account.ConfirmEmail;
using CleanAspire.Api.Client.Account.Signup;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace CleanAspire.Api.Client.Account
{
    /// <summary>
    /// Builds and executes requests for operations under \account
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The confirmEmail property</summary>
        public global::CleanAspire.Api.Client.Account.ConfirmEmail.ConfirmEmailRequestBuilder ConfirmEmail
        {
            get => new global::CleanAspire.Api.Client.Account.ConfirmEmail.ConfirmEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The signup property</summary>
        public global::CleanAspire.Api.Client.Account.Signup.SignupRequestBuilder Signup
        {
            get => new global::CleanAspire.Api.Client.Account.Signup.SignupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::CleanAspire.Api.Client.Account.AccountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/account", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::CleanAspire.Api.Client.Account.AccountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/account", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
