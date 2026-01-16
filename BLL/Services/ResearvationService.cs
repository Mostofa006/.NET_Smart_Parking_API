using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ResearvationService
    {
        public static List<ReservationDTO> Get()
        {
            var data = DataAccessFactory.ReservationData().Read();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReservationDTO>>(data);
            return mapped;

        }
        public static ReservationDTO Get(int id)
        {
            var data = DataAccessFactory.ReservationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReservationDTO>(data);
            return mapped;
        }
    }
}
