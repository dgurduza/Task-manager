using System;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    class Task : Tasks
    {
        // Имя задачи.
        public string TaskTitle;
        /// <summary>
        /// Конструктор для установки параметров.
        /// </summary>
        /// <param name="_name"></param>
        public Task(string _name) : base(_name)
        {
            TaskTitle = _name;
            DataOfCreation = DateTime.Now;
        }
        // Имя исполнителя.
        public User UserOfTask { get; set; }
    }
}
