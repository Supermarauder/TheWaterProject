namespace TheWaterProject.Models
{
    public class EFWaterRepository : IWaterRepository
    {
        private WaterProjectContext _context;
        public EFWaterRepository(WaterProjectContext temp) {

            _context = temp;
        } //Constructor


        public IQueryable<Project> Projects => _context.projects;
    }
}
