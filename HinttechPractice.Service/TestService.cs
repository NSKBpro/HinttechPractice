using HinttechPractice.Data;
using HinttechPractice.Models;

namespace HinttechPractice.Service
{
    class TestService
    {
        private readonly hinttechPracticeEntities dataContext;

        public TestService()
        {
            if (dataContext == null)
            {
                dataContext = new hinttechPracticeEntities();
            }
        }

        public void Add(TestViewModel testModel)
        {
            var newUser = new User
            {
                Firstname = testModel.Name
            };

            dataContext.Users.Add(newUser);
            dataContext.SaveChanges();
        }
    }
}
