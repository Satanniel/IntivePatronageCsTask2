using System;
using System.Collections.Generic;
using System.Linq;

namespace IntivePatronageCsTask2.Models
{
    public class ConferenceManagement
    {
        List<ConferenceRoom> conferenceList;
        static ConferenceManagement conferenceManagement = null;
        private ConferenceManagement()
        {
            conferenceList = new List<ConferenceRoom>();
        }
        public static ConferenceManagement getInstance()
        {
            if (conferenceManagement == null)
            {
                conferenceManagement = new ConferenceManagement();
                return conferenceManagement;
            }
            else
            {
                return conferenceManagement;
            }
        }
        public void Add(ConferenceRoom room)
        {
            conferenceList.Add(room);
        }
        public String RemoveRoom(String name)
        {
            for (int i = 0; i < conferenceList.Count; i++)
            {
                ConferenceRoom checkRoom = conferenceList.ElementAt(i);
                if (checkRoom.Name.Equals(name))
                {
                    conferenceList.RemoveAt(i);
                    return "Delete successful";
                }
            }
            return "Delete not successful";
        }
        public List<ConferenceRoom> getAllRooms()
        {
            return conferenceList;
        }
        public String EditRoom(ConferenceRoom room)
        {
            for (int i = 0; i < conferenceList.Count; i++)
            {
                ConferenceRoom checkRoom = conferenceList.ElementAt(i);
                if (checkRoom.Name.Equals(room.Name))
                {
                    conferenceList[i] = room;
                    return "Update successful";
                }
            }
            return "Update not successful";
        }
    }
}
