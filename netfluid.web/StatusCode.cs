// ********************************************************************************************************
// <copyright company="NetFluid">
//     Copyright (c) 2013 Matteo Fabbri. All rights reserved.
// </copyright>
// ********************************************************************************************************
// The contents of this file are subject to the GNU AGPL v3.0 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http://www.fsf.org/licensing/licenses/agpl-3.0.html 
// 
// Commercial licenses are also available from http://netfluid.org/, including free evaluation licenses.
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specific language governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this file is Matteo Fabbri.
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using System;

namespace Netfluid
{
    /// <summary>
    /// HTTP protocol status codes
    /// </summary>
    public static class StatusCode
    {
        public const int Continue = 100;
        public const int SwitchingProtocols = 101;
        public const int Processing = 102;
        public const int Ok = 200;
        public const int Created = 201;
        public const int Accepted = 202;
        public const int NonAuthoritativeInformation = 203;
        public const int NoContent = 204;
        public const int ResetContent = 205;
        public const int PartialContent = 206;
        public const int MultiStatus = 207;
        public const int MultipleChoices = 300;
        public const int MovedPermanently = 301;
        public const int Found = 302;
        public const int SeeOther = 303;
        public const int NotModified = 304;
        public const int UseProxy = 305;
        public const int SwitchProxy = 306;
        public const int TemporaryRedirect = 307;
        public const int BadRequest = 400;
        public const int AuthorizationRequired = 401;
        public const int PaymentRequired = 402;
        public const int Forbidden = 403;
        public const int NotFound = 404;
        public const int MethodNotAllowed = 405;
        public const int NotAcceptable = 406;
        public const int ProxyAuthenticationRequired = 407;
        public const int RequestTimeout = 408;
        public const int Conflict = 409;
        public const int Gone = 410;
        public const int LengthRequired = 411;
        public const int PreconditionFailed = 412;
        public const int RequestEntityTooLarge = 413;
        public const int RequestURITooLong = 414;
        public const int UnsupportedMediaType = 415;
        public const int RequestedRangeNotSatisfiable = 416;
        public const int ExpectationFailed = 417;
        public const int ImTeapot = 418;
        public const int TooManyConnectionsFromYourIP = 421;
        public const int UnprocessableEntity = 422;
        public const int Locked = 423;
        public const int FailedDependency = 424;
        public const int UnorderedCollection = 425;
        public const int UpgradeRequired = 426;
        public const int RetryWith = 449;
        public const int BlockedbyWindowsParentalControls = 450;
        public const int InternalServerError = 500;
        public const int NotImplemented = 501;
        public const int BadGateway = 502;
        public const int ServiceUnavailable = 503;
        public const int GatewayTimeout = 504;
        public const int HTTPVersionNotSupported = 505;
        public const int VariantAlsoNegotiates = 506;
        public const int InsufficientStorage = 507;
        public const int BandwidthLimitExceeded = 509;
        public const int NotExtended = 510;
        public const int UserAccessDenied = 530;
    }
}