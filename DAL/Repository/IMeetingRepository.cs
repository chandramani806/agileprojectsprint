using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.DAL.Repository
{
    public interface IMeetingRepository
    {
        public bool InsertNewProject(Meeting meet);

        public Meeting GetMeetingById(int id);

        public string UpdateMeeting(int id, Meeting meeting);
    }
}
