using UserData1;
namespace UserBL
{
    public class Class3
    {
        public bool UserVerify(string username, string password)
        {
            Class1 DataService = new Class1();
            var result = DataService.GetUser(username, password);

            return result.username != null ? true : false;
        }
    }
}
