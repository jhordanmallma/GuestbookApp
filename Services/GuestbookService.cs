using System;
using System.Collections.Generic;
using System.Linq;
using MiPrimeraAppWeb.Interfaces;
using MiPrimeraAppWeb.Models;    // ← IMPORTANTE: aquí también

namespace MiPrimeraAppWeb.Services
{
    public class GuestbookService : IGuestbookService
    {
        private readonly List<GuestEntry> _entries = new();

        public void AddEntry(GuestEntry entry)
        {
            entry.Date = DateTime.Now;
            _entries.Add(entry);
        }

        public IEnumerable<GuestEntry> GetAll() =>
            _entries.OrderByDescending(e => e.Date);
    }
}
