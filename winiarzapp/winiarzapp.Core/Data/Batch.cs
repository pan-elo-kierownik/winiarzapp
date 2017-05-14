using System;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Obiekt opisujący zapisany nastaw.
    /// </summary>
    [Serializable]
    public class Batch
    {
        public Recipe recipe;
        public DateTime createdAt;
        public string Description;
    }
}
