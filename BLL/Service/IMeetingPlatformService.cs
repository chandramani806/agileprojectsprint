using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.BLL.Service
{
    public interface IMeetingPlatformService
    {
        public List<MeetingPlatform> GetMeetingPlatforms();
    }
}
