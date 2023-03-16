using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ImageItem
    {
        public ImageItem()
        {
            IsActive = true;

        }

        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageSource { get; set; }
        public string Category { get; set; }
        public Guid IdWeb { get; set; }
        public DateTime InsertDate { get; set; }
        public bool IsActive { get; private set; }

    }
}
