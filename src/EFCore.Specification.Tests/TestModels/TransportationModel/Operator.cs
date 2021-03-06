// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.TestModels.TransportationModel
{
    public class Operator
    {
        public string VehicleName { get; set; }
        public string Name { get; set; }
        public Vehicle Vehicle { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Operator other
                   && VehicleName == other.VehicleName
                   && Name == other.Name;
        }

        public override int GetHashCode() => VehicleName.GetHashCode();
    }
}
