using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.DAL.Repository
{
    public interface ISprintRepository
    {
        public bool InsertNewProject(Sprint sprint);
    }
}
