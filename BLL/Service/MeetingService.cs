using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;
using agileprojectsprint.DAL.Repository;

namespace agileprojectsprint.BLL.Service
{
    public class MeetingService : IMeetingService
    {
        public readonly IMeetingRepository MeetingRepository;
        public MeetingService(IMeetingRepository MeetingRepository)
        {
            this.MeetingRepository = MeetingRepository;
        }

        public MeetingDTO GetMeetingById(int id)
        {
            return MeetingRepository.GetMeetingById(id);
        }

        public bool InsertNewProject(MeetingDTO meet)
        {
           return  MeetingRepository.InsertNewProject((Meeting)meet);
        }

    

        public string UpdateMeeting(int id, MeetingDTO meeting)
        {
            return MeetingRepository.UpdateMeeting(id, (Meeting)meeting);
        }
    }
}
