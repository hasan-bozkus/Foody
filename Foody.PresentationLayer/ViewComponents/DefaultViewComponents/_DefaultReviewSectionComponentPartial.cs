using AutoMapper;
using Foody.BusinnessLayer.Abstract;
using Foody.DtoLayer.Dtos.ReviewDtos;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultReviewSectionComponentPartial : ViewComponent
    {
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;

        public _DefaultReviewSectionComponentPartial(IReviewService reviewService, IMapper mapper)
        {
            _reviewService = reviewService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _mapper.Map<List<ResultReviewDto>>(_reviewService.TGetAll());
            return View(values);
        }
    }
}
