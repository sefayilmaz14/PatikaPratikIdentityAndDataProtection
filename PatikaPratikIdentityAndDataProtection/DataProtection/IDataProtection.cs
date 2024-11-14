namespace PatikaPratikIdentityAndDataProtection.DataProtection
{
    public interface IDataProtection
    {

        string Protect(string text);
        string UnProtect(string protectedText);
    }
}
