using System;
using System.Collections.Generic;
using System.Text;

namespace CodeIt.Photography.Libraries.Entities
{
    [Serializable]
    public class BlogPostEntity
    {
        #region Properties

        public string PostId { get; set; }
        public string PostTitle { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public List<ImageEntity> Images { get; set; }

        #endregion
    }
}
