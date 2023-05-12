using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.DAL.Repository
{
    public class SprintRepository : ISprintRepository
    {
        AppDbContext db;

        public SprintRepository(AppDbContext db)
        {
            this.db = db;
        }
        public bool InsertNewProject(Sprint sprint)
        {
            db.Sprints.Add(sprint);
            return db.SaveChanges() > 0;
        }
    }
}
