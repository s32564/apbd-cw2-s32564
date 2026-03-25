namespace App.Service;

public interface IRentService
{
    void Rent(int userId, int gadgetId, string dateToRet);
    void Return(int userId, int gadgetId);
}