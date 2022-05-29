using Library.Business;
using Library.Data.Domain;
using System.Linq;

namespace Library.Presentation.Bussiness
{
    public class Languages
    {
        public static Language GetLanguageByCaption(string languageCaption)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var language = _unitOfWork.LanguageRepository.Get(l => l.Caption == languageCaption).FirstOrDefault();
            return language;
        }
    }
}
