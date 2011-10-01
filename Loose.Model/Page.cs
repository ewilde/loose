// -----------------------------------------------------------------------
//  <copyright file="Page.cs" company="Loose Coupling Limited">
//      Copyright (c) Loose Coupling. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------

using System;
using Loose.Net;

namespace Loose.Model
{
    /// <summary>
    /// Represents a page on the internet.
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Page"/> class.
        /// </summary>
        /// <param name="webClient">The web client.</param>
        public Page(IWebClient webClient)
        {
            WebClient = webClient;
        }

        /// <summary>
        /// Gets or sets the web client.
        /// </summary>
        /// <value>
        /// The web client.
        /// </value>
        public IWebClient WebClient { get; set; }

        /// <summary>
        /// Gets or sets the HTML after a refresh method has been called.
        /// </summary>
        /// <value>
        /// The HTML.
        /// </value>
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets the URI of the page.
        /// </summary>
        /// <value>
        /// The URI of the page.
        /// </value>
        public Uri Uri { get; set; }

        /// <summary>
        /// Refreshes this page, downloading the <see cref="Html"/> for the given <see cref="Uri"/>.
        /// </summary>
        public void Refresh()
        {
            this.Html = this.WebClient.DownloadPage(this.Uri);
        }
    }
}