using System;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Obiekt opisujący zapisany nastaw.
    /// </summary>
    [Serializable]
    public class Batch
    {
        public Recipe recipe { get; set; }
        public DateTime createdAt { get; set; }
        public string Description { get; set; }
        public double LitersOfProduct { get; set; }
    }
}
