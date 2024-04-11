using System;

namespace LegacyApp
{
    public class UserService
    {
        IClientRepository clientRepository = new ClientRepository();
        IUserCreditService userCreditService = new UserCreditService();
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {  
            Client client = clientRepository.GetById(clientId);
            User user = new User(client, dateOfBirth, email, firstName, lastName);
            bool isValidate = validateUser(firstName, lastName, email, dateOfBirth) && manageUserCreditLimit(client, user) ;
            if (isValidate)
            {
                UserDataAccess.AddUser(user);
            }
            return isValidate;
        }

        public bool validateUser(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            return validateAge(dateOfBirth) && validateEmail(email) && validateName(firstName, lastName);
        }

        public bool validateAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;
            return age > 20;
        }
        public bool validateName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return false;
            }
            return true;
        }

        public bool validateEmail(string email) 
        {
            if (!email.Contains("@") && !email.Contains("."))
            {
                return false;
            }
            return true;
        }

        public bool manageUserCreditLimit(Client client, User user)
        {
            if (client.Type == "VeryImportantClient")
            {
                user.HasCreditLimit = false;
            }
            else if (client.Type == "ImportantClient")
            {
                int creditLimit = userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);
                creditLimit = creditLimit * 2;
                user.CreditLimit = creditLimit;
            }
            else
            {
                user.HasCreditLimit = true;
                int creditLimit = userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);
                user.CreditLimit = creditLimit;
            }

            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            return true;
        }

    }
}
