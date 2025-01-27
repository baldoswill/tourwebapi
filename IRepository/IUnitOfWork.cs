﻿using System;
using System.Threading.Tasks;
using TourWebApi.Data;

namespace TourWebApi.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }

        Task Save();
    }
}