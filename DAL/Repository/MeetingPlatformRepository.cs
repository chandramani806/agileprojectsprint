using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.DAL.Repository
{
    public class MeetingPlatformRepository : IMeetingPlatformRepository

    {
        AppDbContext db;

        public MeetingPlatformRepository(AppDbContext db)
        {
            this.db = db;
        }

       

        public List<MeetingPlatform> GetMeetingPlatforms()
        {
            return db.MeetingPlatforms.ToList();
        }

        public bool InsertNewProject(MeetingPlatform project)
        {
            db.MeetingPlatforms.Add(project);
            return db.SaveChanges() > 0;
        }
    }
}
