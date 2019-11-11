using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetangular.Entities;
using dotnetangular.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetangular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ReservationController : Controller
    {
        private readonly ReservationRepository _reservationRepository;

        public ReservationController(ReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        [HttpGet("[action]")]
        public async Task<List<Reservation>> List()
        {
            return await _reservationRepository.GetAll<Reservation>();
        }
    }
}
