using CapitalTask.DTO;

namespace CapitalTask.IServices
{
    public interface IPreviewService
    {
        Task<List<PreviewDto>> GetAllPreviews();
        Task<PreviewDto> GetPreviewById(int id);
    }
}
