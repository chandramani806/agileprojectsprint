using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;
using agileprojectsprint.DAL.Repository;

namespace agileprojectsprint.BLL.Service
{
    public class MeetingPlatformService : IMeetingPlatformService
    {

        public readonly IMeetingPlatformRepository MeetingPlatformRepository;
        public MeetingPlatformService(IMeetingPlatformRepository MeetingPlatformRepository)
        {
            this.MeetingPlatformRepository = MeetingPlatformRepository;
        }
        public List<MeetingPlatform> GetMeetingPlatforms()
        {
            return MeetingPlatformRepository.GetMeetingPlatforms().Select(x => (MeetingPlatformDTO)x).ToList();
            
        }
    }
}
