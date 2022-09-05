using System.Collections.Generic;

namespace Conference
{
    /// <summary>
    /// A conference model.
    /// </summary>
    class Conference
    {
        /// <summary>
        /// The name of the conference.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The conference's website.
        /// </summary>
        public string Website { get; private set; }

        /// <summary>
        /// The conference location.
        /// </summary>
        public string Location { get; private set; }

        /// <summary>
        /// The list of people attending the confernce.
        /// </summary>
        public List<ConferenceDelegate> Attendees { get; private set; }

        /// <summary>
        /// A confernce model.
        /// </summary>
        /// <param name="name">The name of the conference.</param>
        /// <param name="website">The conference's website.</param>
        /// <param name="location">The conference location.</param>
        public Conference(string name, string website, string location)
        {
            this.Name = name;
            this.Website = website;
            this.Location = location;
            this.Attendees = new List<ConferenceDelegate>();
        }

        /// <summary>
        /// Adds an attendee to the conferece.
        /// </summary>
        /// <param name="name">The attendee's name.</param>
        /// <param name="email">The attendee's email.</param>
        /// <param name="shirtSize">The attendee's shirt size.</param>
        /// <param name="shirtColour">The attendee's shirt colour.</param>
        public void AddAttendee(string name, string email, int shirtSize, string shirtColour)
        {
            ConferenceDelegate conferenceDelegate = new ConferenceDelegate(name, email, shirtSize, shirtColour);
            Attendees.Add(conferenceDelegate);
        }

        /// <summary>
        /// Prints the attendees.
        /// </summary>
        /// <returns>A string representing the attendees.</returns>
        public string PrintAttendees()
        {
            string attendees = "";

            foreach(ConferenceDelegate c in Attendees)
            {
                attendees += c.Name + ",";
            }
            attendees = attendees.TrimEnd(',');
            return attendees;
        }

    }
}
