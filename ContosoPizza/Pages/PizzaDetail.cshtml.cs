using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoPizza.Services;

namespace ContosoPizza.Pages
{
    public class PizzaDetail  : PageModel
    {
        // private readonly ILogger<PizzaDetail > _logger;
        private readonly PizzaService _service;

        public PizzaDetail (PizzaService service) //ILogger<PizzaDetail > logger
        {
            // _logger = logger;
            _service = service;
        }

        public void OnGet()
        {
        }

        public DateTime get_date()
        {
            return DateTime.Now;
        }

        public int get_count()
        {
            return _service.CountPizzas();
        }
    }
}