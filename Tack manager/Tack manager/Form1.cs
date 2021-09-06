using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tack_manager
{
    public partial class Manager : Form
    {
        // Список пользователей, создан доступности информации о пользователях.
        List<User> MyUsers = new List<User>();
        // Список проектов.
        List<Project> MyProjects = new List<Project>();
        public int CountOfUsers = 1;
        public int CountOfProject = 1;
        public Manager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод добавления пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetNewUser(object sender, EventArgs e)
        {
            try
            {
                User tempUser = new User($"User{CountOfUsers}");
                // Добавление созданного пользователя в рабочее пространство.
                ListOfUsers.Items.Add(tempUser.NameOfUser);
                MyUsers.Add(tempUser);
                BoxListOfUsers.Items.Add(tempUser.NameOfUser);
                CountOfUsers++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Метод удаления пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteUser(object sender, EventArgs e)
        {
            try
            {
                if (ListOfUsers.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show(
                       "Удалить пользователя?",
                       "Сообщение",
                       MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    // Получение данных о нажатой кнопке на MessageBox.
                    {
                        // Удаление пользователя из списка, из ListBox, и из ComboBox.
                        GetInfoAboutExecutorInTask(MyUsers[ListOfUsers.SelectedIndex]);
                        MyUsers.RemoveAt(ListOfUsers.SelectedIndex);
                        BoxListOfUsers.Items.RemoveAt(ListOfUsers.SelectedIndex);
                        ListOfUsers.Items.RemoveAt(ListOfUsers.SelectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите пользователя!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Метод создания проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CreateProject(object sender, EventArgs e)
        {
            try
            {
                Project tempProject = new Project($"Project{CountOfProject}");
                BoxOfProjects.Items.Add(tempProject.ToString());
                MyProjects.Add(tempProject);
                CountOfProject++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Метод удаления проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveProject(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProjects.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show(
                       "Удалить проект?",
                       "Сообщение",
                       MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MyProjects.RemoveAt(BoxOfProjects.SelectedIndex);
                        BoxOfProjects.Items.RemoveAt(BoxOfProjects.SelectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите проект!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Переименование проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Renaming(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProjects.SelectedIndex >= 0)
                {
                    MessageBox.Show("Введите новое название в появившуюся строку");
                    // Для того, чтобы пользователю было легче кнопка и строка для изменения имени проекта скрыты.
                    CheckNewTitle.Visible = true;
                    GetNewTitle.Visible = true;
                }
                else
                {
                    MessageBox.Show("Выберите проект!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Проверка введенного имени.
        /// </summary>
        /// <returns></returns>
        public bool CheckRenaming()
        {
            if (GetNewTitle.Text == "")
            {
                MessageBox.Show("Вы не ввели новое имя!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод для открытия кнопки и среды для получения нового имени проекта. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckNewTitle_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRenaming())
                {
                    // Изменение данных в списке проектов.
                    MyProjects[BoxOfProjects.SelectedIndex].Title = GetNewTitle.Text;
                    BoxOfProjects.Items[BoxOfProjects.SelectedIndex] = MyProjects[BoxOfProjects.SelectedIndex].ToString();
                    // Сокрытие кнопок.
                    CheckNewTitle.Visible = false;
                    GetNewTitle.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Полчение данных о выбранном проекте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadBoxOfTasks(object sender, EventArgs e)
        {
            try
            {
                int tempNum = BoxOfProjects.SelectedIndex;
                int num = BoxOfTasks.Items.Count;
                int subNum = BoxOfSubtasks.Items.Count;
                int usersNum = ListOfTaskPerformers.Items.Count;
                // Очистка рабочей среды для записи новой информации.
                for (int j = 0; j < num; j++)
                {
                    BoxOfTasks.Items.RemoveAt(0);
                }
                if (BoxOfSubtasks.Items.Count > 0)
                {
                    for (int j = 0; j < subNum; j++)
                    {
                        BoxOfSubtasks.Items.RemoveAt(0);
                    }
                }
                if (ListOfTaskPerformers.Items.Count > 0)
                {
                    for (int j = 0; j < usersNum; j++)
                    {
                        ListOfTaskPerformers.Items.RemoveAt(0);
                    }
                }
                if (tempNum >= 0)
                {
                    // Добавление новой информации в рабочую среду.
                    if (MyProjects[tempNum].TaskFromProject.Count > 0)
                    {
                        for (int i = 0; i < MyProjects[tempNum].TaskFromProject.Count; i++)
                        {
                            BoxOfTasks.Items.Add(MyProjects[tempNum].TaskFromProject[i].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Создание новой задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewTask(object sender, EventArgs e)
        {
            try
            {
                int tempCount = BoxOfProjects.SelectedIndex;
                Tasks tempTask;
                if (BoxOfProjects.SelectedIndex >= 0 && ListOfTitles.SelectedIndex >= 0)
                {
                    // Создание задачи выбранной пользователем.
                    if (ListOfTitles.Text == "Epic")
                    {
                        tempTask = new EpicTask("Epic");
                    }
                    else if (ListOfTitles.Text == "Task")
                    {
                        tempTask = new Task("Task");
                    }
                    else if (ListOfTitles.Text == "Bug")
                    {
                        tempTask = new Bug("Bug");
                    }
                    else
                    {
                        tempTask = new Story("Story");
                    }
                    if (MyProjects[tempCount].TaskFromProject.Count <= 10)
                    {
                        MyProjects[tempCount].GetTask(tempTask);
                        BoxOfTasks.Items.Add(tempTask.ToString());
                        BoxOfProjects.Items[tempCount] = MyProjects[tempCount].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Превышено максимальное допустимое число задач в проекте.");
                    }
                }
                else
                {
                    if (BoxOfProjects.SelectedIndex < 0)
                    {
                        MessageBox.Show("Вы не выбрали проект в котором нужно создать задачу!");
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали тип задачи!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Удаление задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeletingTask(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProjects.SelectedIndex >= 0 && BoxOfTasks.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show(
                       "Удалить задачу?",
                       "Сообщение",
                       MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Удаление задачи из рабочего пространства и из списка задач.
                        MyProjects[BoxOfProjects.SelectedIndex].RemoveTask(BoxOfTasks.SelectedIndex);
                        BoxOfTasks.Items.RemoveAt(BoxOfTasks.SelectedIndex);
                        BoxOfProjects.Items[BoxOfProjects.SelectedIndex] = MyProjects[BoxOfProjects.SelectedIndex].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали задачу!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Показ подзадач Epic.
        /// </summary>
        public void ShowSubTasks()
        {
            try
            {
                int remNum = BoxOfSubtasks.Items.Count;
                // Очистка рабочей среды для подзадач.
                for (int j = 0; j < remNum; j++)
                {
                    BoxOfSubtasks.Items.RemoveAt(0);
                }
                EpicTask tempEpic = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                if (tempEpic.SubTasks.Count > 0)
                {
                    for (int k = 0; k < tempEpic.SubTasks.Count; k++)
                    {
                        BoxOfSubtasks.Items.Add(tempEpic.SubTasks[k].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Добавление подзадач.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetSubTask(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfTasks.SelectedIndex >= 0)
                {
                    if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Epic")
                    {
                        // Создание экземпляра класса для получения доступа к методам класса.
                        EpicTask tempTask = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                        if (ListOfSubtasks.Text.Length > 0)
                        {
                            if (ListOfSubtasks.Text == "Story")
                            {
                                Story tempStory = new Story("Story");
                                tempTask.SubTasks.Add(tempStory);
                                // Создание подзадачи.
                                BoxOfSubtasks.Items.Add(tempStory.ToString());
                            }
                            else
                            {
                                Task tempSubtask = new Task("Task");
                                tempTask.SubTasks.Add(tempSubtask);
                                BoxOfSubtasks.Items.Add(tempSubtask.ToString());
                            }
                            // Присвоение измененной задачи обратно в список.
                            MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = tempTask;
                        }
                        else
                        {
                            MessageBox.Show("Вы не выбрали тип подзадачи!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Задачам этого типа нельзя присвоить подзадачу!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали задачу!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Получение данных о выбранной задаче.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxOfTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tempCount = BoxOfSubtasks.Items.Count;
                int tempUserCount = ListOfTaskPerformers.Items.Count;
                if (BoxOfTasks.SelectedIndex >= 0)
                {
                    // Очистка среды для вывода статуса задачи.
                    ChangeStatus.Text = "";
                    ChangeStatus.SelectedText = MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].StatusOfTask;
                    if (BoxListOfUsers.Items.Count > 0)
                    {
                        for (int j = 0; j < tempUserCount; j++)
                        {
                            ListOfTaskPerformers.Items.RemoveAt(0);
                        }
                    }
                    if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Epic")
                    {
                        // Если выбранная задача типа Epic, то мы выводим ее подзадачи.
                        ShowSubTasks();
                    }
                    else
                    {
                        for (int j = 0; j < tempCount; j++)
                        {
                            BoxOfSubtasks.Items.RemoveAt(0);
                        }
                        // Вывод исполнителей задачи.
                        ShowUsers(MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Удаление подзадач.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteSubtasks(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfSubtasks.SelectedIndex >= 0 && BoxOfTasks.SelectedIndex >= 0 && BoxOfProjects.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show(
                       "Удалить подзадачу?",
                       "Сообщение",
                       MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        EpicTask tempEpic = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                        tempEpic.SubTasks.RemoveAt(BoxOfSubtasks.SelectedIndex);
                        BoxOfSubtasks.Items.RemoveAt(BoxOfSubtasks.SelectedIndex);
                        // Присвоение измененного экземпляра класса.
                        MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = tempEpic;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите подзадачу!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Присвоение задачи исполнителя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetExecutor(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfTasks.SelectedIndex >= 0)
                {
                    if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask != "Epic")
                    {
                        if (BoxListOfUsers.SelectedIndex >= 0)
                        {
                            // Проверка к какому типу относится задача.
                            if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Task")
                            {
                                Task newTask = (Task)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                                // Проверка на наличие исполнителей в задаче.
                                if (CheckUsersInTasks(MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex]))
                                {
                                    // Присвоение пользователю задачи.
                                    newTask.UserOfTask = MyUsers[BoxListOfUsers.SelectedIndex];
                                    // Получение данных об выбранной задаче.
                                    MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = newTask;
                                    // Добавление пользователя в рабочую среду.
                                    ListOfTaskPerformers.Items.Add(MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser);
                                }
                                else
                                {
                                    MessageBox.Show("Исполнителем этой задачи может быть только один пользователь!");
                                }
                            }
                            else if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Bug")
                            {
                                Bug newBug = (Bug)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                                if (CheckUsersInTasks(MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex]))
                                {
                                    newBug.UserOfBug = MyUsers[BoxListOfUsers.SelectedIndex];
                                    MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = newBug;
                                    ListOfTaskPerformers.Items.Add(MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser);
                                }
                                else
                                {
                                    MessageBox.Show("Исполнителем этой задачи может быть только один пользователь!");
                                }
                            }
                            else
                            {
                                Story newStory = (Story)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                                if (GetInfoAboutExecutors(newStory, MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser))
                                {
                                    newStory.GetUser(MyUsers[BoxListOfUsers.SelectedIndex]);
                                    MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = newStory;
                                    ListOfTaskPerformers.Items.Add(MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser);
                                }
                                else if (newStory.UsersOfStory.Count >= 3)
                                {
                                    MessageBox.Show("Превышен лимит пользователей!");
                                }
                                else
                                {
                                    MessageBox.Show("Пользователь уже является исполнителем этой задачи!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выберите пользователя!");
                        }
                    }
                    else if (BoxListOfUsers.SelectedIndex >= 0)
                    // Проверка на наличие выбранного пользователя.
                    {
                        if (BoxOfSubtasks.SelectedIndex >= 0)
                        {
                            EpicTask epic = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                            // Работа с подзадачами и назначение пользователей им.
                            if (epic.SubTasks[BoxOfSubtasks.SelectedIndex].NameOfTask == "Task")
                            {
                                Task newTask = (Task)epic.SubTasks[BoxOfSubtasks.SelectedIndex];
                                if (CheckUsersInTasks(MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex]))
                                {
                                    newTask.UserOfTask = MyUsers[BoxListOfUsers.SelectedIndex];
                                    epic.SubTasks[BoxOfSubtasks.SelectedIndex] = newTask;
                                    ListOfTaskPerformers.Items.Add(MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser);
                                }
                                else
                                {
                                    MessageBox.Show("Исполнителем этой задачи может быть только один пользователь!");
                                }
                            }
                            else
                            {
                                if (CheckUsersInTasks(MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex]))
                                {
                                    Story newStory = (Story)epic.SubTasks[BoxOfSubtasks.SelectedIndex];
                                    if (GetInfoAboutExecutors(newStory, MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser))
                                    {
                                        newStory.GetUser(MyUsers[BoxListOfUsers.SelectedIndex]);
                                        epic.SubTasks[BoxOfSubtasks.SelectedIndex] = newStory;
                                        ListOfTaskPerformers.Items.Add(MyUsers[BoxListOfUsers.SelectedIndex].NameOfUser);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Пользователь уже является исполнителем этой задачи!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Превышен лимит пользователей!");
                                }
                            }
                        }
                        else if (BoxOfSubtasks.Items.Count > 0)
                        {
                            MessageBox.Show("Вы не выбрали задачу для отражения ее пользователей!");
                        }
                        else
                        {
                            MessageBox.Show("Этот тип задач не имеет исполнителей!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Этот тип задач не имеет исполнителей!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали задачу!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Удаление исполнителя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteExecutor(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfTasks.SelectedIndex >= 0)
                {
                    if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask != "Epic")
                    // Проверка того, что задача не имеет подзадач.
                    {
                        if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Task" && ListOfTaskPerformers.Items.Count >= 0)
                        {
                            Task taskToDeleting = (Task)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                            // Удаление пользователя тк у данного типа задач он только один.
                            ListOfTaskPerformers.Items.RemoveAt(0);
                            taskToDeleting.UserOfTask = null;
                            MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = taskToDeleting;
                        }
                        else if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Bug" && ListOfTaskPerformers.Items.Count >= 0)
                        {
                            Bug bugToDeleting = (Bug)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                            ListOfTaskPerformers.Items.RemoveAt(0);
                            bugToDeleting.UserOfBug = null;
                            MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = bugToDeleting;
                        }
                        else if (ListOfTaskPerformers.Items.Count >= 0)
                        {
                            Story storyToDeleting = (Story)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                            if (ListOfTaskPerformers.SelectedIndex >= 0)
                            // Проверка на индекс выбранного исполнителя для последующего удаления.
                            {
                                storyToDeleting.UsersOfStory.RemoveAt(ListOfTaskPerformers.SelectedIndex);
                                ListOfTaskPerformers.Items.RemoveAt(ListOfTaskPerformers.SelectedIndex);
                            }
                            MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex] = storyToDeleting;
                        }
                        else
                        {
                            MessageBox.Show("Выберите пользователя!");
                        }
                    }
                    // Аналогчиная работа с подзадачами.
                    else if (BoxOfSubtasks.SelectedIndex >= 0)
                    {
                        EpicTask newEpic = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                        if (newEpic.SubTasks[BoxOfSubtasks.SelectedIndex].NameOfTask == "Task" && ListOfTaskPerformers.Items.Count >= 0)
                        {
                            Task taskToDeleting = (Task)newEpic.SubTasks[BoxOfSubtasks.SelectedIndex];
                            ListOfTaskPerformers.Items.RemoveAt(0);
                            taskToDeleting.UserOfTask = null;
                            newEpic.SubTasks[BoxOfSubtasks.SelectedIndex] = taskToDeleting;
                        }
                        else if (ListOfTaskPerformers.Items.Count >= 0)
                        {
                            Story storyToDeleting = (Story)newEpic.SubTasks[BoxOfSubtasks.SelectedIndex];
                            if (ListOfTaskPerformers.SelectedIndex >= 0)
                            {
                                storyToDeleting.UsersOfStory.RemoveAt(ListOfTaskPerformers.SelectedIndex);
                                ListOfTaskPerformers.Items.RemoveAt(ListOfTaskPerformers.SelectedIndex);
                            }
                            newEpic.SubTasks[BoxOfSubtasks.SelectedIndex] = storyToDeleting;
                        }
                        else
                        {
                            MessageBox.Show("Выберите пользователя!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите подзадачу!");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите задачу!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Вывод исполнителей в рабочую среду.
        /// </summary>
        /// <param name="temp"></param>
        public void ShowUsers(Tasks temp)
        {
            try
            {
                if (temp.NameOfTask == "Task")
                {
                    Task tempTask = (Task)temp;
                    if (tempTask.UserOfTask != null)
                    {
                        // Добавление исполнителей в рабочую среду, если у задачи есть исполнитель.
                        ListOfTaskPerformers.Items.Add(tempTask.UserOfTask.NameOfUser);
                    }
                }
                else if (temp.NameOfTask == "Bug")
                {
                    Bug tempBug = (Bug)temp;
                    if (tempBug.UserOfBug != null)
                    {
                        ListOfTaskPerformers.Items.Add(tempBug.UserOfBug.NameOfUser);
                    }
                }
                else
                {
                    Story tempStory = (Story)temp;
                    int count = tempStory.UsersOfStory.Count;
                    // Добавление исполнителей в цикле для задач типа Story.
                    for (int i = 0; i < count; i++)
                    {
                        if (tempStory.UsersOfStory[i] != null)
                        {
                            ListOfTaskPerformers.Items.Add(tempStory.UsersOfStory[i].NameOfUser);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Получение данных о выбранной подзадаче.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxOfSubtasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int num = ListOfTaskPerformers.Items.Count;
                if (BoxOfSubtasks.SelectedIndex >= 0)
                {
                    // Очистка списка исполнителей.
                    for (int i = 0; i < num; i++)
                    {
                        ListOfTaskPerformers.Items.RemoveAt(0);
                    }
                    EpicTask newEpic = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                    // Установка статуса.
                    ChangeStatus.Text = "";
                    ChangeStatus.SelectedText = newEpic.SubTasks[BoxOfSubtasks.SelectedIndex].StatusOfTask;
                    // Вывод исполнителей подзадачи.
                    ShowUsers(newEpic.SubTasks[BoxOfSubtasks.SelectedIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Проверка наличия исполнителей у задач.
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool CheckUsersInTasks(Tasks task)
        {
            // Работа с задачами.
            if (task.NameOfTask != "Epic")
            {
                if (task.NameOfTask == "Task")
                {
                    Task getTask = (Task)task;
                    if (getTask.UserOfTask == null)
                    {
                        return true;
                    }
                }
                else if (task.NameOfTask == "Bug")
                {
                    Bug getBug = (Bug)task;
                    if (getBug.UserOfBug == null)
                    {
                        return true;
                    }
                }
                else
                {
                    Story getstory = (Story)task;
                    if (getstory.UsersOfStory.Count < 3)
                    {
                        return true;
                    }
                }
            }
            else
            {
                try
                {
                    // Работа с подзадачами.
                    EpicTask epicTask = (EpicTask)task;
                    if (epicTask.SubTasks[BoxOfSubtasks.SelectedIndex].NameOfTask == "Task")
                    {
                        Task getTask = (Task)epicTask.SubTasks[BoxOfSubtasks.SelectedIndex];
                        if (getTask.UserOfTask == null)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        Story getstory = (Story)epicTask.SubTasks[BoxOfSubtasks.SelectedIndex];
                        if (getstory.UsersOfStory.Count < 3)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        /// <summary>
        /// Проверка на наличие такого же исполнителя у задачи.
        /// </summary>
        /// <param name="story">Задача</param>
        /// <param name="newName">Новое имя исполнителя</param>
        /// <returns></returns>
        public bool GetInfoAboutExecutors(Story story, string newName)
        {
            for (int i = 0; i < story.UsersOfStory.Count; i++)
            {
                if (story.UsersOfStory[i].NameOfUser == newName)
                {
                    return false;
                }
                else if (story.UsersOfStory.Count >= 3)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Получение нового статуса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetNewStatus(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfTasks.SelectedIndex >= 0)
                {
                    // Изменение статуса у задач.
                    if (MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].StatusOfTask != ChangeStatus.SelectedText)
                    {
                        MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].StatusOfTask = ChangeStatus.Text;
                    }
                    else
                    {
                        MessageBox.Show("Такой татус уже установлен для этой задачи!");
                    }
                    // Изменение статуса у подзадач.
                    if (BoxOfSubtasks.SelectedIndex >= 0 && MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex].NameOfTask == "Epic")
                    {
                        // Создание экземпляра класса для получения данных.
                        EpicTask epicForChange = (EpicTask)MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[BoxOfTasks.SelectedIndex];
                        if (epicForChange.SubTasks[BoxOfSubtasks.SelectedIndex].StatusOfTask != ChangeStatus.SelectedText)
                        {
                            epicForChange.SubTasks[BoxOfSubtasks.SelectedIndex].StatusOfTask = ChangeStatus.Text;
                        }
                        else
                        {
                            MessageBox.Show("Такой татус уже установлен для этой задачи!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали задачу!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Получение информации о задачах, для удаляемого исполнителя.
        /// </summary>
        /// <param name="user"></param>
        public void GetInfoAboutExecutorInTask(User user)
        {
            try
            {
                // Цикл для просмотра всех проектов.
                for (int c = 0; c < MyProjects.Count; c++)
                {
                    // Для упрощения работы создал новый список класса Tasks.
                    List<Tasks> newListOfTasks = MyProjects[c].TaskFromProject;
                    // Цикл для просмотра всех задач.
                    for (int i = 0; i < newListOfTasks.Count; i++)
                    {
                        if (newListOfTasks[i].NameOfTask != "Epic")
                        {
                            if (newListOfTasks[i].NameOfTask == "Task")
                            {
                                Task temp = (Task)newListOfTasks[i];
                                if (temp.UserOfTask != null)
                                {
                                    if (temp.UserOfTask.NameOfUser == user.NameOfUser)
                                    {
                                        temp.UserOfTask = null;
                                    }
                                }
                                newListOfTasks[i] = temp;
                            }
                            else if (newListOfTasks[i].NameOfTask == "Bug")
                            {
                                Bug temp = (Bug)newListOfTasks[i];
                                if (temp.UserOfBug != null)
                                {
                                    if (temp.UserOfBug.NameOfUser == user.NameOfUser)
                                    {
                                        temp.UserOfBug = null;
                                    }
                                }
                                newListOfTasks[i] = temp;
                            }
                            else
                            {
                                Story temp = (Story)newListOfTasks[i];
                                // Просмотр всех исполнителей.
                                for (int j = 0; j < temp.UsersOfStory.Count; j++)
                                {
                                    if (temp.UsersOfStory[j].NameOfUser == user.NameOfUser)
                                    {
                                        temp.UsersOfStory.RemoveAt(j);
                                    }
                                }
                                newListOfTasks[i] = temp;
                            }
                        }
                        else
                        {
                            // Проверка наличия исполителя у подзадач и дальнейшая работа с ними.
                            EpicTask epic = (EpicTask)newListOfTasks[i];
                            for (int k = 0; k < epic.SubTasks.Count; k++)
                            {
                                if (epic.SubTasks[k].NameOfTask == "Task")
                                {
                                    Task tempSubTask = (Task)epic.SubTasks[k];
                                    if (tempSubTask.UserOfTask != null)
                                    {
                                        if (tempSubTask.UserOfTask.NameOfUser == user.NameOfUser)
                                        {
                                            tempSubTask.UserOfTask = null;
                                        }
                                    }
                                    epic.SubTasks[k] = tempSubTask;
                                }
                                else
                                {
                                    Story tempSubTask = (Story)epic.SubTasks[k];
                                    for (int j = 0; j < tempSubTask.UsersOfStory.Count; j++)
                                    {
                                        if (tempSubTask.UsersOfStory[j].NameOfUser == user.NameOfUser)
                                        {
                                            // Использование RemoveAt для последующего доступа к добавлению пользователей.
                                            tempSubTask.UsersOfStory.RemoveAt(j);
                                        }
                                    }
                                    epic.SubTasks[k] = tempSubTask;
                                }
                            }
                        }
                    }
                    MyProjects[c].TaskFromProject = newListOfTasks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Метод сортировки задач по статусу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Sorting(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProjects.SelectedIndex >= 0 && BoxOfTasks.Items.Count > 0)
                {
                    List<Tasks> sorted = MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject;
                    // Переопределенный метод для сортировки задач по статусу.
                    sorted.Sort();
                    MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject = sorted;
                    int count = MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject.Count;
                    // Очистка рабочей среды.
                    for (int i = 0; i < count; i++)
                    {
                        BoxOfTasks.Items.RemoveAt(0);
                    }
                    // Добавление в рабочую среду отсортированного списка задач.
                    for (int j = 0; j < count; j++)
                    {
                        BoxOfTasks.Items.Add(MyProjects[BoxOfProjects.SelectedIndex].TaskFromProject[j].ToString());
                    }
                }
                else if (BoxOfProjects.SelectedIndex >= 0 && BoxOfTasks.Items.Count > 0)
                {
                    MessageBox.Show("Создайте задачи!");
                }
                else
                {
                    MessageBox.Show("Вы не выбрали проект!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Загрузка формы и загрузка информации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Manager_Load(object sender, EventArgs e)
        {
            try
            {
                // Вывод информации о программе.
                string str = File.ReadAllText("info.txt");
                MessageBox.Show(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}