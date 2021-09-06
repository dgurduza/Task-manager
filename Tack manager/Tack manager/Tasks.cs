using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tack_manager
{
    public class Tasks: IComparable<Tasks>
    {
        // Тип задачи.
        public string NameOfTask { get; set; }
        // Поле для получения точной даты создания.
        public DateTime DataOfCreation;
        // Статус задачи.
        public string StatusOfTask = "Открытая задача";
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="_name"></param>
        public Tasks(string _name)
        {
            NameOfTask = _name;
        }
        /// <summary>
        /// Использование интерфейса IComparable для сортировки по статусу.
        /// </summary>
        /// <param name="taskToSort"></param>
        /// <returns></returns>
        public int CompareTo(Tasks taskToSort)
        {
            if (taskToSort.StatusOfTask == "Открытая задача")
            {
                if(StatusOfTask== "Открытая задача")
                {
                    return 0;
                }
                else if (StatusOfTask== "Задача в работе")
                {
                    return 1;
                }
                else
                {
                    return 1;
                }
            }
            else if(taskToSort.StatusOfTask == "Задача в работе")
            {
                if (StatusOfTask == "Открытая задача")
                {
                    return -1;
                }
                else if (StatusOfTask == "Задача в работе")
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (StatusOfTask == "Открытая задача")
                {
                    return -1;
                }
                else if (StatusOfTask == "Задача в работе")
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Переопределенный метод для вывода необходимой информации о выбранной задаче.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{NameOfTask} Data:{DataOfCreation}";
        }
    }
}
