using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;

namespace agileprojectsprint.BLL.Service
{
    public interface ISprintService
    {
        public bool InsertNewProject(SprintDTO sprint);
    }
}
