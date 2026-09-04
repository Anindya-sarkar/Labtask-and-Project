using System;
using Main_project.Models;

namespace Main_project
{
    
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }
        public static bool IsUserLoggedIn => CurrentUser != null;

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
