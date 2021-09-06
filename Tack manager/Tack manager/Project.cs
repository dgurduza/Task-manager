using System;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    class Project
    {
        // Имя проекта.
        public string Title { get; set; }
        // Список задач в проекте.
        public List<Tasks> TaskFromProject = new List<Tasks>();
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"></param>
        public Project(string name)
        {
            Title = name;
        }
        /// <summary>
        /// Добавление задач в проект.
        /// </summary>
        /// <param name="newTask"></param>
        public void GetTask(Tasks newTask)
        {
            if (TaskFromProject.Count <= 10)
            {
            TaskFromProject.Add(newTask);
            }
        }
        /// <summary>
        /// Удаление задач из проекта
        /// </summary>
        /// <param name="numOfTaskInList"></param>
        public void RemoveTask(int numOfTaskInList)
        {
            if (TaskFromProject.Count > 0)
            {
                TaskFromProject.RemoveAt(numOfTaskInList);
            }
        }
        /// <summary>
        /// Метод для вывода необходимой информации.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title} Count of Tasks:{TaskFromProject.Count}";
        }
    }
}
