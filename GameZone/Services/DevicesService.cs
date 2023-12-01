using Microsoft.EntityFrameworkCore;

namespace GameZone.Services
{
    public class DevicesService : IDevicesService
    {
        private readonly AppDbContext _context;

        public DevicesService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetDevices()
        {
            return _context.Devices.Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).OrderBy(c => c.Text).AsNoTracking();
        }
    }
}
