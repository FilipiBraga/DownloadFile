namespace ReturnFileWebApi.Interface
{
    public interface IFileService
    {
        Stream GetImage();
        byte[] GetImage(bool asByte);
    }
}
