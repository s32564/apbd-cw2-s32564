namespace App;

public class GenId()
{
    private static int _gCounter;
    private static int _uCounter;
    private static int _rCounter;

    public static int Generate<T>(IEnumerable<T> objectToGenId)
    {
        foreach (var obj in objectToGenId)
        {
            if (obj == null) continue;
            switch (obj.GetType().Name)
            {
                case "Laptop":
                case "Camera":
                case "Projector":
                    _gCounter++;
                    return _gCounter;
                case "Student":
                case "Employee":
                    _uCounter++;
                    return _uCounter;
                case "Rent":
                    _rCounter++;
                    return _rCounter;
            }
        }

        return 0;
    }
}