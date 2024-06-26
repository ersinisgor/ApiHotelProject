﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
  public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
  {
    public EfAppUserDal(Context context) : base(context)
    {
    }

    public int GetAppUserCount()
    {
      var context = new Context();
      return context.Users.Count();
    }

    public List<AppUser> UserListWithWorkLocation()
    {
      var context = new Context();
      return context.Users.Include(x => x.WorkLocation).Select(y => new AppUser
      {
        Name = y.Name,
        Surname = y.Surname,
        WorkLocationID = y.WorkLocationID,
        WorkLocation = y.WorkLocation

      }).ToList();
    }
  }
}
