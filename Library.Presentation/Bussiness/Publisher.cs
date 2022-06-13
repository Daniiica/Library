using Library.Business;
using Library.Data.Domain;
using System.Linq;

namespace Library.Presentation.Bussiness
{
    public class Publisher
    {
        public static int GetPublisherIDByName(string publisherName)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var publisher = _unitOfWork.PublishingHouseRepository.Get(p => p.Name == publisherName).FirstOrDefault();
            return publisher.PublishingHouseId;
        }
    }
}
