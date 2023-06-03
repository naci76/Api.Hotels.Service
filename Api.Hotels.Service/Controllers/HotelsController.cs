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
        private readonly IFactory factory;
        public ILogger<HotelsController> logger;
        public HotelsController(IMapper _mapper, IHotelRepository _hotelRepository, ILogger<HotelsController> _logger, IFactory _factory)
        {
            mapper = _mapper;
            hotelRepository = _hotelRepository;
            logger = _logger;
            factory = _factory;
        }
        [HttpPost]
        [Route("hotel-add")]
        public async Task<IActionResult> Add(HotelModel model)
        {
            logger.LogError("Otel eklendi");
            hotelRepository.Add(mapper.Map<Hotel>(model));
            await factory.SaveChange();
            return Ok("Success");
        }
        [HttpPost]
        [Route("hotel-update")]
        public async  Task<IActionResult> Update(HotelModel model)
        {
            logger.LogError("Otel güncellendi");
            hotelRepository.Update(mapper.Map<Hotel>(model));
           await factory.SaveChange();
            return Ok("Success");
        }
        [HttpPost]
        [Route("hotel-delete")]
        public async Task<IActionResult> Delete(HotelModel model)
        {
            logger.LogError("Otel silindi");
            hotelRepository.Delete(mapper.Map<Hotel>(model));
           await factory.SaveChange();
            return Ok("Success");
        }
        [HttpGet]
        [Route("hotel-getall")]
        public async Task<IActionResult> GetAll()
        {
            logger.LogError("Oteller listelendi");
            return Ok(mapper.Map<List<HotelModel>>(await hotelRepository.GetAll()));
        }
        [HttpGet]
        [Route("hotel-get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            logger.LogError("Otel listelendi");
            return Ok(mapper.Map<HotelModel>(await hotelRepository.Get(id)));
        }
        [HttpPost]
        [Route("hotel-contact-add")]
        public async Task<IActionResult> AddHotelContact(HotelContactModel model)
        {
            logger.LogError("Otel iletişim eklendi");
            hotelRepository.AddHotelContact(mapper.Map<HotelContact>(model));
            await factory.SaveChange();
            return Ok("Success");
        }
        [HttpPost]
        [Route("hotel-contact-update")]
        public async Task<IActionResult> UpdateHotelContact(HotelContactModel model)
        {
            logger.LogError("Otel iletişim güncellendi");
            hotelRepository.UpdateHotelContact(mapper.Map<HotelContact>(model));
            await factory.SaveChange();
            return Ok("Success");
        }
        [HttpPost]
        [Route("hotel-contact-delete")]
        public async Task<IActionResult> DeleteHotelContact(HotelContactModel model)
        {
            logger.LogError("Otel iletişim silindi");
            hotelRepository.DeleteHotelContact(mapper.Map<HotelContact>(model));
            await factory.SaveChange();
            return Ok("Success");
        }
        [HttpGet]
        [Route("hotel-contact-getall/{hotelId}")]
        public async Task<IActionResult> GetAllHotelContact(int hotelId)
        {
            logger.LogError("Otel iletişimleri listelendi");
            return Ok(mapper.Map<List<HotelContactModel>>(await hotelRepository.GetAllHotelContact(hotelId)));
        }
        [HttpGet]
        [Route("hotel-contact-get/{id}")]
        public async Task<IActionResult> GetHotelContact(int id)
        {
            logger.LogError("Otel iletişim listelendi");
            return Ok(mapper.Map<HotelContactModel>(await hotelRepository.GetHotelContact(id)));
        }
    }
}
