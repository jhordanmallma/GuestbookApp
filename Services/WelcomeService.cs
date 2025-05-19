using System;
using MiPrimeraAppWeb.Interfaces;

namespace MiPrimeraAppWeb.Services
{
    public class WelcomeService : IWelcomeService
    {
        private readonly DateTime _serviceCreated;
        private readonly Guid _serviceId;

        public WelcomeService()
        {
            _serviceCreated = DateTime.Now;
            _serviceId = Guid.NewGuid();                
        }

        public string GetWelcomeMessage()
        {
            return $"¡Bienvenido a MiPrimeraAppWeb! La hora actual es {_serviceCreated}. Esta instancia del servicio tiene el ID {_serviceId}.";
        }
    }
}
