using AltSource.Entity;
using AltSource.Entity.UnitofWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltSource.Domain.Service
{
    public class ClothingService<Tv, Te> : GenericService<Tv, Te>
                                        where Tv : ClothingViewModel
                                        where Te : Clothing
    {
        public ClothingService(IUnitOfWork unitOfWork)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
        }
    }
}
