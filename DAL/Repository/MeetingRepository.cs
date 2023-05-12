using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.DAL.Repository
{
    public class MeetingRepository : IMeetingRepository

    {
        AppDbContext db;

        public MeetingRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Meeting GetMeetingById(int id)
        {
            return db.Meetings.SingleOrDefault(x => x.Id == id);
        }

        public bool InsertNewProject(Meeting meet)
        {
            db.Meetings.Add(meet);
            return db.SaveChanges() > 0;
        }

        public string UpdateMeeting(int id, Meeting meeting)
        {
            Meeting meet = db.Meetings.SingleOrDefault(m => m.Id == id);
            if(meet == null)  return null;

            meet = meeting;
            db.SaveChanges();

            string st = Meetings.Status;
            return st;

        }
    }
}
