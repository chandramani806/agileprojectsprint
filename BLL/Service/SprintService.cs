using agileprojectsprint.BLL.DTOs;
using agileprojectsprint.DAL.Models;
using agileprojectsprint.DAL.Repository;

namespace agileprojectsprint.BLL.Service
{
    public class SprintService : ISprintService
    {
        public readonly ISprintRepository SprintRepository;
        public SprintService(ISprintRepository SprintRepository)
        {
            this.SprintRepository = SprintRepository;
        }

        public bool InsertNewProject(SprintDTO sprint)
        {
            return SprintRepository.InsertNewProject((Sprint)sprint);
        }
    }
}
