using System.IO;

namespace UnravelerCS.Data
{
    class PageInfo
    {
        public string Filename { get; set; }

        public override string ToString()
        {
            return Path.GetFileName(Filename);
        }
    }
}
