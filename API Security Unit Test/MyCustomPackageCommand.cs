using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NuGet;
using NuGetPackageExplorer.Types;

namespace API_Security_Unit_Test 
{
    // TODO: replace 'My custom command' with your menu label
    [PackageCommandMetadata("My custom command")]
    internal class MyCustomPackageCommand : IPackageCommand 
    {
        public void Execute(IPackage package, string packagePath) 
        {
            throw new NotImplementedException();
        }
    }
}