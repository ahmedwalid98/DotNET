namespace Task2;

public class NIC
{

    #region Properties

    public string Manufacture { get; set; }
    public int MacAddress { get; set; }
    public Type Type { get; set; }

    #endregion

    #region ctor

    private NIC()
    {
    }

    #endregion

    #region Singeltone instance

    public static NIC Instance { get; } = new NIC();

    #endregion
}