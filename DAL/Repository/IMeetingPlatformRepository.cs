using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.DAL.Repository
{
    public interface IMeetingPlatformRepository
    {
        public List<MeetingPlatform> GetMeetingPlatform();
        IEnumerable<MeetingPlatformDTO> GetMeetingPlatforms();
        public bool InsertNewProject(MeetingPlatform project);
    }
}
