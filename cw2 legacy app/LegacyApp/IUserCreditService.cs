using System;

namespace LegacyApp
{
    internal interface IUserCreditService
    {
        int GetCreditLimit(string lastName, DateTime dateOfBirth);
    }
}