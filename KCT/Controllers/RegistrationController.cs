using KCT.Data;
using KCT.Interfaces;
using KCT.Models;
using KCT.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCT.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationController(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        // GET: /Registration
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var registrations = await _registrationRepository.GetAllAsync();
            return Ok(registrations);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var registration = await _registrationRepository.GetByIdAsync(id);
            if (registration == null) return NotFound();
            return Ok(registration);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Registration registration)
        {
            await _registrationRepository.AddAsync(registration);

            // Return a simple JSON message for AJAX front-end
            return Ok(new { message = "Registration Successful!", registration });
        }

        // PUT: /Registration/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [FromBody] Registration registration)
        {
            var existing = await _registrationRepository.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.Name = registration.Name;
            existing.Description = registration.Description;
            existing.Address = registration.Address;
            existing.City = registration.City;
            existing.Phone = registration.Phone;

            await _registrationRepository.UpdateAsync(existing); // UpdateAsync expects object

            return Ok(new { message = "Registration Updated!", registration = existing });
        }


        // DELETE: /Registration/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _registrationRepository.GetByIdAsync(id);
            if (existing == null) return NotFound();

            await _registrationRepository.DeleteAsync(id); // ✅ pass id, not object

            return Ok(new { message = "Registration Deleted!" });
        }

    }


}
