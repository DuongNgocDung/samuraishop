using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ISlideService
    {
        Slide Add(Slide dto);

        void Update(Slide dto);

        Slide Delete(Slide dto);

        Slide GetByKey(int id);

        void SaveChanges();
    }
}