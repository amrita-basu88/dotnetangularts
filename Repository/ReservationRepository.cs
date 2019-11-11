using dotnetangular.DataContext;
using dotnetangular.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace dotnetangular.Repository
{
    public class ReservationRepository
    {
        private readonly MyHotelDbContext _myHotelDbContext;

        public ReservationRepository(MyHotelDbContext myHotelDbContext)
        {
            _myHotelDbContext = myHotelDbContext;
        }

        //public async Task<List<T>> GetAll<T>()
        //{

        //    var detail= _myHotelDbContext
        //        .Reservations
        //        .Include(x => x.Room)
        //        .Include(x => x.Guest)
        //        .ToListAsync();
        //    return await _myHotelDbContext
        //        .Reservations
        //        .Include(x => x.Room)
        //        .Include(x => x.Guest) 
        //        .ToListAsync();
        //}

        public async Task<IEnumerable<Reservation>> GetAll()
        {
            return await _myHotelDbContext
                .Reservations
                .Include(x => x.Room)
                .Include(x => x.Guest)
                .ToListAsync();
        }
    }
}
