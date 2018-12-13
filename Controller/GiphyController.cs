using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giphy.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiphyController.Controllers
{
    public class GiphyController: Controller{

        private readonly IGiphyService _giphyService;

        public GiphyController(IGiphyService giphyService)
        {
            _giphyService = giphyService;
        }

        public async Task<IActionResult> GetRandomGif(string searchCritera){

            var result = await _giphyService.GetRandomGifBasedOnSearchCritera(searchCritera);

            return Ok(result);

        }


    }

    
}