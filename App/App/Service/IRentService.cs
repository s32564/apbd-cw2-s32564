namespace App.Service;

public interface IRentService
{
    void Rent(int userId, int gadgetId, int daysToRent);
    void Return(int userId, int gadgetId);
}