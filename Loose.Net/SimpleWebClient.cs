// -----------------------------------------------------------------------
//  <copyright file="WebClient.cs" company="Loose Coupling Limited">
//      Copyright (c) Loose Coupling. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------

using System;
using System.Net;

namespace Loose.Net
{
    public class SimpleWebClient : IWebClient
    {
        public string DownloadPage(Uri uri)
        {
            System.Net.WebClient client = new WebClient();
            
        }
    }
}