using System;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    public class User
    {
        // Имя пользователя.
        public string NameOfUser { get; set; }
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"></param>
        public User(string name)
        {
            NameOfUser = name;
        }
    }
}
