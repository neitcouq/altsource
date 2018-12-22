using AltSource.Entity;
using AltSource.Entity.UnitofWork;

namespace AltSource.Domain.Service
{
    public class VendorService<Tv, Te> : GenericService<Tv, Te>
                                        where Tv : VendorViewModel
                                        where Te : Vendor
    {
        public VendorService(IUnitOfWork unitOfWork)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
        }
    }
}
