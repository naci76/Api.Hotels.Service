using Api.Hotels.Entity;
using Api.Hotels.Models;
using Api.Hotels.Repositories.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Hotels.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IHotelRepository hotelRepository;
        public ILogger<HotelsController> logger;
        public HotelsController(IMapper _mapper, IHotelRepository _hotelRepository, ILogger<HotelsController> _logger)
        {
            mapper = _mapper;
            hotelRepository = _hotelRepository;
            logger = _logger;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(HotelModel hotelModel)
        {
            logger.LogError("Otel eklendi");
            hotelRepository.Add(mapper.Map<Hotel>(hotelModel));
            return Ok("Success");
        }
        [HttpPost]
        [Route("update")]
        public IActionResult Update(HotelModel hotelModel)
        {
            logger.LogError("Otel güncellendi");
            hotelRepository.Update(mapper.Map<Hotel>(hotelModel));
            return Ok("Success");
        }
        [HttpPost]
        [Route("delete")]
        public IActionResult Delete(HotelModel hotelModel)
        {
            logger.LogError("Otel silindi");
            hotelRepository.Delete(mapper.Map<Hotel>(hotelModel));
            return Ok("Success");
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            logger.LogError("Oteller listelendi");
            var otelList = mapper.Map<List<HotelModel>>(await hotelRepository.GetAll());
            return Ok(otelList);
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            logger.LogError("Otel listelendi");
            var otel = mapper.Map<HotelModel>(await hotelRepository.Get(id));
            return Ok(otel);
        }
    }
}
