using System;
using System.Collections.Generic;
using System.Linq;

namespace TOEIC_Practice.DTO
{
    public static class Session
    {
        public static int AccountId { get; set; }
        public static string Username { get; set; }
        public static string DisplayName { get; set; }
        public static List<string> Roles { get; set; }

        public static bool IsLoggedIn
        {
            get { return AccountId > 0; }
        }

        public static bool IsAdmin
        {
            get
            {
                return Roles != null &&
                       Roles.Any(r => string.Equals(
                           (r ?? "").Trim(),
                           "Admin",
                           StringComparison.OrdinalIgnoreCase));
            }
        }

        public static bool IsUser
        {
            get
            {
                return Roles != null &&
                       Roles.Any(r => string.Equals(
                           (r ?? "").Trim(),
                           "User",
                           StringComparison.OrdinalIgnoreCase));
            }
        }

        public static void Clear()
        {
            AccountId = 0;
            Username = null;
            DisplayName = null;
            Roles = null;
        }
    }
}