using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetrievingData.Model;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ConnectionDBClass _db;

        public IndexModel(ConnectionDBClass db)
        {
            _db = db;
        }

        public IEnumerable<EmpClass> getrecords { get; set; }
        public async Task OnGet()
        {
            getrecords = await _db.DimEmployee.ToListAsync();
        }
    }
}
