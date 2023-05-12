using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.BLL.Service
{
    public interface IMeetingService
    {
        public bool InsertNewProject(MeetingDTO meet);
        public MeetingDTO GetMeetingById(int id);
        public string UpdateMeeting(int id, MeetingDTO meeting);
    }
}
