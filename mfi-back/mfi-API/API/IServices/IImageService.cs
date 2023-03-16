using Entities;

namespace API.IServices
{
    public interface IImageService
    {
        int InsertImage(ImageItem imagetItem);

        void DeleteImage(int Id);

        void UpdateImage(ImageItem imagetItem);

        List<ImageItem> GetImageByCriteria(string Category);
        List<ImageItem> GetAll();
      
    }
}
