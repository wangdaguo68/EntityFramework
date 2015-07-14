// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.ChangeTracking.Internal
{
    public class RelationshipsSnapshotFactory : IRelationshipsSnapshotFactory
    {
        public virtual Sidecar Create(InternalEntityEntry entry) => new RelationshipsSnapshot(entry);
    }
}