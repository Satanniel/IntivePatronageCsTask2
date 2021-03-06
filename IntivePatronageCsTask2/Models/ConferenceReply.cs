﻿using System;

namespace IntivePatronageCsTask2.Models
{
    public class ConferenceReply
    {
        String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        bool isPrivate;
        public Boolean IsPrivate
        {
            get { return isPrivate; }
            set { isPrivate = value; }
        }
        String creator;
        public String Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        String registrationStatus;
        public String AddStatus
        {
            get { return registrationStatus; }
            set { registrationStatus = value; }
        }
    }
}