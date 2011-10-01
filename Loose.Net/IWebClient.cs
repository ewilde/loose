// -----------------------------------------------------------------------
//  <copyright file="IWebClient.cs" company="Loose Coupling Limited">
//      Copyright (c) Loose Coupling. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------

using System;

namespace Loose.Net
{
    public interface IWebClient
    {
        string DownloadPage(Uri uri);
    }
}