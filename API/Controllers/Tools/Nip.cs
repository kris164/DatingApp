namespace API.Controllers.Tools
{
    public static class Nip
    {
            public static string CleanNip(string nip)
        { 
            return nip.Replace("-", "").Replace(" ", "") ;
        }
    }
}