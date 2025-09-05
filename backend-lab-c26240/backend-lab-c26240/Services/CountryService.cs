using backend_lab_c26240.Models;
using backend_lab_c26240.Repositories;

namespace backend_lab_c26240.Services
{
    public class CountryService
    {
        private readonly CountryRepository countryRepository;

        public CountryService()
        {
            countryRepository = new CountryRepository();
        }

        public List<CountryModel> GetCountries()
        {
            return countryRepository.GetCountries();
        }
    }
}
