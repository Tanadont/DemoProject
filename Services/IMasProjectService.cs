using DemoProject.Models;

namespace DemoProject.Services
{
    public interface IMasProjectService
    {
        ApiResponse GetAll(Query query);
    }
}
