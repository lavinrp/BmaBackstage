namespace BmaBackstage.Domain
{

    public interface IStringGetter
    {
        string GetString();
    }
    public class Class1 : IStringGetter
    {
        public string GetString()
        {
            return "Domain";
        }
    }
}