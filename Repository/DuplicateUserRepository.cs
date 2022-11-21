using UserRegistrationNew.DataLayer;
using UserRegistrationNew.Models;

namespace UserRegistrationNew.Repository
{
    public class DuplicateUserRepository: IUserRepository
    {
        public void Add(UserViewModel userVM)
        {
            BrightDb2Context DB = new BrightDb2Context();

            User user = new User();
            user.Id = userVM.Id;
            user.UserName = userVM.UserName;
            user.Password = userVM.Password;
            user.Age = userVM.Age;
            user.Address = userVM.Address;
            user.EmailId = userVM.EmailId;

            DB.Users.Add(user);
        }
    }
}
