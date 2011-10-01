using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Loose.Tests.Properties;

namespace Loose.Tests
{
    public class base_context
    {
        public static void ResetTestState()
        {            
        }

        /// <summary>
        /// Gets the resource as string. The <paramref name="relativeResourcePath"/> should be passed in using a value from <see cref="ResourceList"/>.
        /// </summary>
        /// <param name="relativeResourcePath">The relative resource path, a value from <see cref="ResourceList"/>.</param>
        /// <returns>The resource as a string</returns>
        public string GetResourceAsString(string relativeResourcePath)
        {
            return File.ReadAllText(Path.Combine(Assembly.GetExecutingAssembly().Location, relativeResourcePath));
        }
    }
}
