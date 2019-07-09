using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PastebinLike.WebApp.DTOs;
using PastebinLike.WebApp.Services;

namespace PastebinLike.WebApp.Controllers
{
    public class PastebinsController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IPastebinService _pastebinService;

        public PastebinsController(IMemoryCache memoryCache, IPastebinService pastebinService)
        {
            _memoryCache = memoryCache;
            _pastebinService = pastebinService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            if (!_memoryCache.TryGetValue(id, out var cachedPastebin))
            {
                var pastebin = _pastebinService.GetPastebin(id);

                if (pastebin == null)
                {
                    return NotFound();
                }

                cachedPastebin = pastebin;

                _memoryCache.Set(id, pastebin);
            }

            return Ok(cachedPastebin);
        }

        [HttpPost]
        public IActionResult Post([FromBody]PastebinToCreateDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var pastebin = _pastebinService.CreatePastebin(dto);

            return Created($"pastebins/{pastebin.Id}", pastebin);
        }
    }
}
