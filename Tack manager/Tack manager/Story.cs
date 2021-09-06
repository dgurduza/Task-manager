using System;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    public class Story : Tasks
    {
        // Имя задачи.
        public string StoryTitle;
        // Список пользователей.
        public List<User> UsersOfStory = new List<User>();
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="_name"></param>
        public Story(string _name) : base(_name)
        {
            StoryTitle = _name;
            DataOfCreation = DateTime.Now;
        }
        /// <summary>
        /// Добавление исполнителя.
        /// </summary>
        /// <param name="_user"></param>
        public void GetUser(User _user)
        {
            if (UsersOfStory.Count < 3)
            {
                UsersOfStory.Add(_user);
            }
        }
    }
}
