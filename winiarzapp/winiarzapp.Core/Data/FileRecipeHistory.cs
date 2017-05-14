using System;
using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    [Serializable]
    public class FileRecipeHistory : IRecipeHistory
    {
        public IEnumerable<Batch> Batches { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddBatch(Batch batch)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RemoveBatch(Batch batch)
        {
            throw new NotImplementedException();
        }
    }
}
