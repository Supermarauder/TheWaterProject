namespace TheWaterProject.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IQueryable<Project> Projects { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();

        public string? CurrentProjectType { get; set;} //allow us to set the current project type
    }
}
