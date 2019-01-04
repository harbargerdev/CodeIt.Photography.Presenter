using System;
using System.Collections.Generic;
using System.Text;

namespace CodeIt.Photography.Libraries.Entities
{
    public class ImageEntity
    {
        #region Properties

        public string ImageId { get; set; }
        public string ImageTitle { get; set; }
        public string ThumbnailDownloadLink { get; set; }
        public string WatermarkedDownloadLink { get; set; }
        public string Caption { get; set; }
        public string Location { get; set; }

        #endregion
    }
}
