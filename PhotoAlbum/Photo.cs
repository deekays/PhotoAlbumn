using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class Photo
    {
        public string Description;
        private string photoPath;
        public string PhotoPath
        {
            get => photoPath;
        }
        private string photoCreated;
        public string PhotoCreated
        {
            get => photoCreated;
        }

        public Photo ()
        {
            //initializer
        }

        /// <summary>
        /// Initializer for when they create an album for the first time.
        /// </summary>
        /// <param name="photoPath"></param>
        /// <param name="photoCreated"></param>
        public Photo (string photoPath, string photoCreated)
        {
            this.photoPath = photoPath;
            this.photoCreated = photoCreated;
        }

        /// <summary>
        /// Initializer for when they open a file and have descriptions. I probably could have used this for both, but I liked the clean-ness of the other call.
        /// </summary>
        /// <param name="photoPath"></param>
        /// <param name="photoCreated"></param>
        /// <param name="description"></param>
        public Photo (string photoPath, string photoCreated, string description)
        {
            this.photoPath = photoPath;
            this.photoCreated = photoCreated;
            Description = description;
        }
    }
}
