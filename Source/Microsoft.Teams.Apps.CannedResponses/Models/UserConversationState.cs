// <copyright file="UserConversationState.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.CannedResponses.Models
{
    /// <summary>
    /// User conversation state model class.
    /// </summary>
    public class UserConversationState
    {
        /// <summary>
        /// Gets or sets a value indicating whether welcome card sent to user.
        /// </summary>
        /// <remark>Value is null when bot is installed for first time.</remark>
        public bool? IsWelcomeCardSent { get; set; }
    }
}
