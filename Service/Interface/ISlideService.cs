using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ISlideService
    {
        void Add(Slide dto);

        void Update(Slide dto);

        void Delete(Slide dto);

        Slide GetByKey(int id);

        void SaveChanges();
    }
}