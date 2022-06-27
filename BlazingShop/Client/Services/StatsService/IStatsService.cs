namespace BlazingShop.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}
