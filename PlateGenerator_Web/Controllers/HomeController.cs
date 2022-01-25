using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlateGenerator_Model;
using PlateGenerator_Repository.Repository;
using PlateGenerator_Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PlateGenerator_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private PlateRepository _plateRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_plateRepository = plateRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<bool> GetAll()
        {
			IEnumerable<Plate> plates = null;

			try
            {
                _logger.LogInformation("Getting plates has started...");

                //plates = _plateRepository.GetAll();

                _logger.LogInformation("Getting plates has finished!");
            }
            catch (Exception e)
            {
                _logger.LogError("Errod during getting plates", e.InnerException);
            }

			return plates.Any();
		}

        [HttpGet]
        public async Task<bool> Get(int id)
        {
            var plate = new Plate();

            try
            {
                _logger.LogInformation($"Getting {id} plate has started...");
                
                //plate = _plateRepository.GetById(id);
                
                _logger.LogInformation("Getting plate has finished!");
            }
            catch (Exception e)
            {
                _logger.LogError($"Errod during getting {id} plate", e.InnerException);
            }

            return plate.Number.Any() && plate.Chars.Any();
        }

        [HttpPost]
        public async Task<bool> Create(Plate plate)
        {
            try
            {
                _logger.LogInformation($"Getting {plate.Id} plate has started...");

                //_plateRepository.Insert(plate);
                //_plateRepository.Save();

                _logger.LogInformation("Getting plate has finished!");
            }
            catch (Exception e)
            {
                _logger.LogError($"Errod during getting {plate.Id} plate", e.InnerException);
            }

            return true;
        }

        [HttpPut]
        public async Task<bool> Update(Plate plate)
        {
            try
            {
                _logger.LogInformation($"Updating {plate.Id} plate has started...");

                //_plateRepository.Update(plate);
                //_plateRepository.Save();

                _logger.LogInformation("Updating plate has finished!");
            }
            catch (Exception e)
            {
                _logger.LogError($"Errod during updating {plate.Id} plate", e.InnerException);
            }

            return true;
        }

        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            try
            {
                _logger.LogInformation($"Deleting {id} plate has started...");

                //var plateToDelete = _plateRepository.GetById(id);

                //_plateRepository.Delete(plateToDelete);
                //_plateRepository.Save();

                _logger.LogInformation("Deleting plate has finished!");
            }
            catch (Exception e)
            {
                _logger.LogError($"Errod during deleting {id} plate", e.InnerException);
            }

            return true;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
