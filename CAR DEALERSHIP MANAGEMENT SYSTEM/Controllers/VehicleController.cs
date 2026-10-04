using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }




        [HttpPost]
        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            _unitOfWork.Vehicles.Add(vehicle);

            _unitOfWork.Save();

            return CreatedAtAction(
                nameof(GetVehicleById),
                new { id = vehicle.Id }, vehicle);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Vehicles.Update(vehicle);
            _unitOfWork.Save();
            return NoContent();
        }



        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _unitOfWork.Vehicles.GetById(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);












            //[HttpGet]
            //public IActionResult GetAllVehicles()
            //{
            //    var vehicles = _unitOfWork.Vehicles.GetAll();
            //    return Ok(vehicles);
            //}
            //[HttpGet("{id}")]
            //public IActionResult GetVehicleById(int id)
            //{
            //    var vehicle = _unitOfWork.Vehicles.GetById(id);
            //    if (vehicle == null)
            //    {
            //        return NotFound();
            //    }
            //    return Ok(vehicle);
            //}
            //[HttpPost]
            //public IActionResult CreateVehicle(Vehicle vehicle)
            //{
            //    _unitOfWork.Vehicles.Add(vehicle);

            //    _unitOfWork.Save();

            //    return CreatedAtAction(
            //        nameof(GetVehicleById),
            //        new { id = vehicle.Id }, vehicle);
            //}
            //[HttpPut("{id}")]
            //public IActionResult UpdateVehicle(int id, Vehicle vehicle)
            //{
            //    if (id != vehicle.Id)
            //    {
            //        return BadRequest();
            //    }
            //    _unitOfWork.Vehicles.Update(vehicle);
            //    _unitOfWork.Save();
            //    return NoContent();
            //}
            //[HttpDelete("{id}")]
            //public IActionResult DeleteVehicle(int id)
            //{
            //    var vehicle = _unitOfWork.Vehicles.GetById(id);
            //    if (vehicle == null)
            //    {
            //        return NotFound();
            //    }
            //    _unitOfWork.Vehicles.Delete(vehicle);
            //    _unitOfWork.Save();
            //    return NoContent();
            //}
        }
    }
}
