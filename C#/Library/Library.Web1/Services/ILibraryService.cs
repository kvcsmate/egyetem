﻿using Library.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Services
{
    public interface ILibraryService
    {
        public enum SortOrder { FAME_DESC, FAME_ASC, NAME_DESC, NAME_ASC }
        public List<Book> GetBooks(String name = null,SortOrder sortOrder=SortOrder.FAME_DESC);
        public Book GetBookByID(int id);
        public List<Volume> GetVolumesByBookId(int id);
        public Book GetBookDetails(int id);
        public Volume GetVolume(int id);
        public Reservation GetReservation(int id);
        public List<Reservation> GetReservationsByVolumeId(int id);
        public bool CreateReservation(Reservation reservation);
        public Volume GetVolumeDetails(int id);
       




    }
}
