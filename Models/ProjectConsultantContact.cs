﻿namespace Cosential.Integrations.Compass.Client.Models
{
    public class ProjectConsultantContact
    {
        public int? Id { get; set; }
        public Contact Contact { get; set; }
        public ContactRole ContactRole { get; set; }
        public string Comments { get; set; }
    }
}