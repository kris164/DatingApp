namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int status, string messege = null, string details = null)
        {
            Status = status;
            Messege = messege;
            Details = details;
        }

        public int Status  {get;set;}
        public string Messege  {get;set;}
        public string Details  {get;set;}
    }
}