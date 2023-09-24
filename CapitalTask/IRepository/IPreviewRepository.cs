using CapitalTask.Models;

namespace CapitalTask.IRepository
{
    public interface IPreviewRepository
    {
        Task<List<Preview>> GetAllPreviews();
        Task<Preview> GetPreviewById(int id);
    }
}
