using IntivePatronageCsTask2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace IntivePatronageCsTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferenceManageController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<ConferenceRoom> GetAllStudents()
        {
            return ConferenceManagement.getInstance().getAllRooms();
        }

        // POST: api/<controller>
        [HttpPost]
        public ConferenceReply RoomAdd(ConferenceRoom roomAdded)
        {
            ConferenceReply conferenceReply = new ConferenceReply();
            ConferenceManagement.getInstance().Add(roomAdded);
            conferenceReply.Name = roomAdded.Name;
            conferenceReply.IsPrivate = roomAdded.IsPrivate;
            conferenceReply.Creator = roomAdded.Creator;
            conferenceReply.AddStatus = "Successful";
            return conferenceReply;
        }

        // PUT: api/<controller>
        [HttpPut]
        public JsonResult UpdateStudentRecord(ConferenceRoom stdn)
        {
            return Json(ConferenceManagement.getInstance().EditRoom(stdn));
        }

        [Route("remove/{roomName}")]
        // DELETE: api/<controller>
        [HttpDelete]
        public IActionResult DeleteStudentRecord(String roomName)
        {
            return Ok(ConferenceManagement.getInstance().RemoveRoom(roomName));
        }
    }
}
