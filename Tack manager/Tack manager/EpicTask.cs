using System;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    class EpicTask : Tasks
    {
        // Имя задачи.
        public string EpicTitle;
        // Список подзадач.
        public List<Tasks> SubTasks = new List<Tasks>();
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="_name"></param>
        public EpicTask(string _name) : base(_name)
        {
            EpicTitle = _name;
            DataOfCreation = DateTime.Now;
        }
    }
}
