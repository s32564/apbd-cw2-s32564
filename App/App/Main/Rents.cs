using App.Container;

namespace App.Main;

public class Rents(int id, int userId, int gadgetId, DateTime start, DateTime end)
{
    public int Id { get; } = id;
    public int UserId { get; } = userId;
    public int GadgetId { get; } = gadgetId;
    public DateTime Start { get; set; } = start;
    public DateTime End { get; set; } = end;
    public DateTime? Returned { get; set; }

    public int Return(DateTime returnedAt)
    {
        var rent = new RentContainer();
        Returned = returnedAt;

        if (!(Returned > End)) return 0;
        var daysLate = (Returned - End).Value.Days;
        rent.Remove(this);
        return daysLate * 2;
    }
}