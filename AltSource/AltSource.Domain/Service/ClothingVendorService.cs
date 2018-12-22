using AltSource.Entity;
using AltSource.Entity.UnitofWork;

namespace AltSource.Domain.Service
{
    public class ClothingVendorService<Tv, Te> : GenericService<Tv, Te>
                                        where Tv : ClothingVendorViewModel
                                        where Te : ClothingVendor
    {
        public ClothingVendorService(IUnitOfWork unitOfWork)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
        }
    }
}
