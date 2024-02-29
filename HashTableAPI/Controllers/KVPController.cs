using HashTableAPI.Contracts.HashTable;
using HashTableAPI.Models;
using HashTableAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HashTableAPI.Controllers
{
    [ApiController]
    [Route("hashtable")]
    public class KVPController : ControllerBase
    {
        private readonly IKVPService _KVPService;

        public KVPController(IKVPService KVPService)
        {
            _KVPService = KVPService;
        }

        [HttpPost]
        public IActionResult AddKVP(CreateKVPRequest request)
        {
            var kvp = new KVP(
                request.Key,
                request.Value);

            _KVPService.AddKVP(kvp);

            var response = new KVPResponse(
                kvp.Key,
                kvp.Value);

            return CreatedAtAction(
                actionName: nameof(GetKVP),
                routeValues: new { key = kvp.Key },
                response);
        }

        [HttpGet("{key}")]
        public IActionResult GetKVP(int key)
        {
            KVP kvp = _KVPService.GetKVP(key);

            var response = new KVPResponse(
                kvp.Key,
                kvp.Value);

            return Ok(response);
        }

        [HttpPut("{key}")]
        public IActionResult UpdateKVP(int key, UpdateKVPRequest request)
        {
            var kvp = new KVP(
                key,
                request.Value);

            _KVPService.UpdateKVP(kvp);

            // TODO: return  201 if a new kvp created

            return NoContent();
        }

        [HttpDelete("{key}")]
        public IActionResult DeleteKVP(int key)
        {
            _KVPService.DeleteKVP(key);
            return NoContent();
        }
    }
}
