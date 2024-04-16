using System.Collections.Generic;
using UserModel;
namespace UserData1
{
    public class Class1
    {
        List<Class2> verifyuser = new List<Class2>();

        public Class1()
        {
            CreateVerifyUser();
        }

        private void CreateVerifyUser()
        {

            Class2 student1 = new Class2 { username = "Maria", password = "abc123" };
            Class2 student2 = new Class2 { username = "Josefa", password = "abc123" };
            Class2 student3 = new Class2 { username = "Vida", password = "abc123" };

            verifyuser.Add(student1);
            verifyuser.Add(student2);
            verifyuser.Add(student3);

        }

        public Class2 GetUser(string username, string password)
        {
            Class2 foundUser = new Class2();

            foreach (var verify in verifyuser)
            {
                if (username == verify.username)
                {
                    foundUser = verify;
                }
            }
            return foundUser;
        }
    }
}
