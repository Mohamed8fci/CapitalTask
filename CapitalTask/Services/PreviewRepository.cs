using CapitalTask.DTO;
using CapitalTask.IRepository;
using CapitalTask.IServices;
using CapitalTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalTask.Services
{
    public class PreviewService : IPreviewService
    {
        private readonly IPreviewRepository _previewRepository;

        public PreviewService(IPreviewRepository previewRepository)
        {
            _previewRepository = previewRepository;
        }

        public async Task<List<PreviewDto>> GetAllPreviews()
        {
            var previews = await _previewRepository.GetAllPreviews();
            return MapToDtoList(previews);
        }

        public async Task<PreviewDto> GetPreviewById(int id)
        {
            var preview = await _previewRepository.GetPreviewById(id);
            return MapToDto(preview);
        }


        private PreviewDto MapToDto(Preview preview)
        {
            return new PreviewDto
            {
                Id = preview.Id,
                Title = preview.Title,
            };
        }

        private List<PreviewDto> MapToDtoList(List<Preview> previews)
        {
            var previewDtos = new List<PreviewDto>();
            foreach (var preview in previews)
            {
                previewDtos.Add(MapToDto(preview));
            }
            return previewDtos;
        }
    }


}

