// -----------------------------------------------------------------------
//  <copyright file="ModelRegistry.cs" company="Loose Coupling Limited">
//      Copyright (c) Loose Coupling. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loose.Net;
using StructureMap;

namespace Loose.Model.Configuration
{
    public class ModelRegistry : StructureMap.Configuration.DSL.Registry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistry"/> class.
        /// </summary>
        public ModelRegistry()
        {
            this.Eject();
            this.Add();
        }

        private void Eject()
        {
            ObjectFactory.EjectAllInstancesOf<IWebClient>();
        }

        private void Add()
        {
            this.For<IWebClient>().Use<WebClient>();
        }
    }
}
