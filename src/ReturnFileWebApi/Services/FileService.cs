using ReturnFileWebApi.Interface;

namespace ReturnFileWebApi.Services
{
    public class FileService : IFileService
    {
        private const string _imagePath = "Assets\\teste.jpg";

        public Stream GetImage()
        {
            var stream = File.Open(_imagePath, FileMode.Open);
            
            return stream;
        }

        public byte[] GetImage(bool asByte)
        {
            using var stream = File.Open(_imagePath, FileMode.Open);

            using var ms = new MemoryStream();
            stream.CopyTo(ms);

            return ms.ToArray();
        }
    }
}
