﻿using ParkyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyApi.Repository.IRepository
{
    public interface INationalParkRepository
    {
        ICollection<NationalPark> GetNationalParks();
        NationalPark GetNationalPark(int nationalParkId);
        bool NationalParkExists(string name);
        bool NationalParkExists(int nationalParkId);
        bool CreateNationalPark(NationalPark nationalPark);
        bool updateNationalPark(NationalPark nationalPark);
        bool deleteNationalPark(NationalPark nationalPark);
        bool Save();
    }
}