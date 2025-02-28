sealed class SecuritySystem
{
    public void AuthenticateUser(string username, string password)
    {
        if (username == "admin" && password == "password123")
        {
            Console.WriteLine("Access Granted!");
        }
        else
        {
            Console.WriteLine("Access Denied!");
        }
    }
}