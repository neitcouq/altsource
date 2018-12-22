using AltSource.Entity;
using AltSource.Entity.UnitofWork;

namespace AltSource.Domain.Service
{
    public class ClothingRetailService<Tv, Te> : GenericService<Tv, Te>
                                        where Tv : ClothingRetailViewModel
                                        where Te : ClothingRetail
    {
        public ClothingRetailService(IUnitOfWork unitOfWork)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
        }
    }
}
