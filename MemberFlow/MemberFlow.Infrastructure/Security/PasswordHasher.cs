using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberFlow.Application.Interfaces.Security;
using Microsoft.AspNetCore.Identity;

namespace MemberFlow.Infrastructure.Security
{
    public class PasswordHasher : IPasswordHasher
    {
        private readonly IPasswordHasher<object> _passwordHasher = new PasswordHasher<object>();

        public string HashPassword(string password)
        {
            return _passwordHasher.HashPassword(null, password);
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(null, hashedPassword, providedPassword);

            return result is (PasswordVerificationResult.Success or PasswordVerificationResult.SuccessRehashNeeded);

        }
    }
}
