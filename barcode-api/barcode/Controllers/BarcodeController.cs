using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using barcode.Services;

namespace barcode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        private readonly BarcodeService _modelService;
        public BarcodeController(BarcodeService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet]
        public ActionResult<List<barcode>> Get() =>
            _modelService.Get();
        [HttpGet("{id}", Name = "GetModel")]
        public ActionResult<barcode> Get(string id)
        {
            var model = _modelService.Get(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPost]
        public ActionResult<barcode> Create(barcode model)
        {
            _modelService.Create(model);

            return CreatedAtRoute("GetModel", new { id = model._id.ToString() }, model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, barcode modelIn)
        {
            var model = _modelService.Get(id);

            if (model == null)
            {
                return NotFound();
            }

            _modelService.Update(id, modelIn);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string _id)
        {
            var model = _modelService.Get(_id);

            if (model == null)
            {
                return NotFound();
            }

            _modelService.Remove(model._id);

            return NoContent();
        }
        
    }
}