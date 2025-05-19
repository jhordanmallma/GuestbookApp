using System.Collections.Generic;
using MiPrimeraAppWeb.Models;    // ← IMPORTANTE: aquí el namespace de tu modelo

namespace MiPrimeraAppWeb.Interfaces
{
    public interface IGuestbookService
    {
        void AddEntry(GuestEntry entry);
        IEnumerable<GuestEntry> GetAll();
    }
}
