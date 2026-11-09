
using clubdeportivo.model;
using clubdeportivo.repository;

namespace clubdeportivo.service
{
    internal class CarnetService
    {
        private CarnetRepository repository;

        public CarnetService()
        {
            repository = new CarnetRepository();
        }
        public Boolean crearCarnet(Carnet carnet)
        {
            return repository.crearCarnet(carnet);
        }

        public Boolean entregarCarnet(long socioId)
        {
            return repository.entregarCarnet(socioId);
        }
    }
}
