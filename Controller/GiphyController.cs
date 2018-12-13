using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiphyController.Controllers
{
    public class GiphyController: Controller{

        private readonly IGiphyService _giphyServices;
        
        public async Task<IActionResult> GetRandomGif(string searchCritera){

            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(seearchCritera);

            return Ok(result);

        }
    }


}