using System;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    class Bug : Tasks
    {
        // Имя задачи.
        public string BugTitle;
        // Имя пользователя.
        public User UserOfBug { get; set; }
        /// <summary>
        ///  Конструктор данных.
        /// </summary>
        /// <param name="_name"></param>
        public Bug(string _name) : base(_name)
        {
            BugTitle = _name;
            DataOfCreation = DateTime.Now;
        }
    }
}
