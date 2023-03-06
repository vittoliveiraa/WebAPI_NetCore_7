namespace AwesomeDevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string TalkName { get; set; }
        public string TalkDescription { get; set; }
        public string LinkedInProfile { get; set; }
    }
}