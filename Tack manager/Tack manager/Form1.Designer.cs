namespace Tack_manager
{
    partial class Manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListOfUsers = new System.Windows.Forms.ListBox();
            this.ContextMenuOfUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetUser = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletingOfUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleOfBox = new System.Windows.Forms.Label();
            this.BoxOfProjects = new System.Windows.Forms.ListBox();
            this.ContextMenuOfProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameProject = new System.Windows.Forms.ToolStripMenuItem();
            this.TitelOfListProjects = new System.Windows.Forms.Label();
            this.CheckNewTitle = new System.Windows.Forms.Button();
            this.GetNewTitle = new System.Windows.Forms.TextBox();
            this.BoxOfTasks = new System.Windows.Forms.ListBox();
            this.ContextMenuOfTasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateTask = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTaskFromProject = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangedStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.SortFromStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleOfTasks = new System.Windows.Forms.Label();
            this.ListOfTitles = new System.Windows.Forms.ComboBox();
            this.BoxOfSubtasks = new System.Windows.Forms.ListBox();
            this.ContextMenuOFSubTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateSubTask = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSubTask = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Label();
            this.ListOfTaskPerformers = new System.Windows.Forms.ListBox();
            this.ContextMenuOfPerformers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AppointmentExecutor = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletingOfExecutor = new System.Windows.Forms.ToolStripMenuItem();
            this.Performer = new System.Windows.Forms.Label();
            this.BoxListOfUsers = new System.Windows.Forms.ComboBox();
            this.ListOfSubtasks = new System.Windows.Forms.ComboBox();
            this.ChangeStatus = new System.Windows.Forms.ComboBox();
            this.StatusOfTasks = new System.Windows.Forms.Label();
            this.GetInfoAboutProgram = new System.Windows.Forms.Button();
            this.ContextMenuOfUsers.SuspendLayout();
            this.ContextMenuOfProjects.SuspendLayout();
            this.ContextMenuOfTasks.SuspendLayout();
            this.ContextMenuOFSubTask.SuspendLayout();
            this.ContextMenuOfPerformers.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfUsers
            // 
            this.ListOfUsers.ContextMenuStrip = this.ContextMenuOfUsers;
            this.ListOfUsers.FormattingEnabled = true;
            this.ListOfUsers.ItemHeight = 25;
            this.ListOfUsers.Location = new System.Drawing.Point(878, 44);
            this.ListOfUsers.Name = "ListOfUsers";
            this.ListOfUsers.Size = new System.Drawing.Size(199, 179);
            this.ListOfUsers.TabIndex = 3;
            // 
            // ContextMenuOfUsers
            // 
            this.ContextMenuOfUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuOfUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetUser,
            this.DeletingOfUsers});
            this.ContextMenuOfUsers.Name = "ContextMenuOfUsers";
            this.ContextMenuOfUsers.Size = new System.Drawing.Size(266, 68);
            // 
            // GetUser
            // 
            this.GetUser.Name = "GetUser";
            this.GetUser.Size = new System.Drawing.Size(265, 32);
            this.GetUser.Text = "Создать пользователя";
            this.GetUser.Click += new System.EventHandler(this.GetNewUser);
            // 
            // DeletingOfUsers
            // 
            this.DeletingOfUsers.Name = "DeletingOfUsers";
            this.DeletingOfUsers.Size = new System.Drawing.Size(265, 32);
            this.DeletingOfUsers.Text = "Удалить пользователя";
            this.DeletingOfUsers.Click += new System.EventHandler(this.DeleteUser);
            // 
            // TitleOfBox
            // 
            this.TitleOfBox.AutoSize = true;
            this.TitleOfBox.Location = new System.Drawing.Point(948, 9);
            this.TitleOfBox.Name = "TitleOfBox";
            this.TitleOfBox.Size = new System.Drawing.Size(59, 25);
            this.TitleOfBox.TabIndex = 4;
            this.TitleOfBox.Text = "Users:";
            // 
            // BoxOfProjects
            // 
            this.BoxOfProjects.ContextMenuStrip = this.ContextMenuOfProjects;
            this.BoxOfProjects.FormattingEnabled = true;
            this.BoxOfProjects.ItemHeight = 25;
            this.BoxOfProjects.Location = new System.Drawing.Point(12, 44);
            this.BoxOfProjects.Name = "BoxOfProjects";
            this.BoxOfProjects.Size = new System.Drawing.Size(244, 429);
            this.BoxOfProjects.TabIndex = 5;
            this.BoxOfProjects.SelectedIndexChanged += new System.EventHandler(this.ReloadBoxOfTasks);
            // 
            // ContextMenuOfProjects
            // 
            this.ContextMenuOfProjects.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuOfProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateButton,
            this.DeleteButton,
            this.RenameProject});
            this.ContextMenuOfProjects.Name = "ContextMenu";
            this.ContextMenuOfProjects.Size = new System.Drawing.Size(215, 100);
            // 
            // CreateButton
            // 
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(214, 32);
            this.CreateButton.Text = "Создать проект";
            this.CreateButton.Click += new System.EventHandler(this.CreateProject);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(214, 32);
            this.DeleteButton.Text = "Удалить проект";
            this.DeleteButton.Click += new System.EventHandler(this.RemoveProject);
            // 
            // RenameProject
            // 
            this.RenameProject.Name = "RenameProject";
            this.RenameProject.Size = new System.Drawing.Size(214, 32);
            this.RenameProject.Text = "Переименовать";
            this.RenameProject.Click += new System.EventHandler(this.Renaming);
            // 
            // TitelOfListProjects
            // 
            this.TitelOfListProjects.AutoSize = true;
            this.TitelOfListProjects.Location = new System.Drawing.Point(87, 9);
            this.TitelOfListProjects.Name = "TitelOfListProjects";
            this.TitelOfListProjects.Size = new System.Drawing.Size(78, 25);
            this.TitelOfListProjects.TabIndex = 9;
            this.TitelOfListProjects.Text = "Projects:";
            // 
            // CheckNewTitle
            // 
            this.CheckNewTitle.BackColor = System.Drawing.SystemColors.Info;
            this.CheckNewTitle.Location = new System.Drawing.Point(71, 523);
            this.CheckNewTitle.Name = "CheckNewTitle";
            this.CheckNewTitle.Size = new System.Drawing.Size(112, 34);
            this.CheckNewTitle.TabIndex = 10;
            this.CheckNewTitle.Text = "Rename";
            this.CheckNewTitle.UseVisualStyleBackColor = false;
            this.CheckNewTitle.Visible = false;
            this.CheckNewTitle.Click += new System.EventHandler(this.CheckNewTitle_Click);
            // 
            // GetNewTitle
            // 
            this.GetNewTitle.Location = new System.Drawing.Point(53, 486);
            this.GetNewTitle.Name = "GetNewTitle";
            this.GetNewTitle.Size = new System.Drawing.Size(150, 31);
            this.GetNewTitle.TabIndex = 11;
            this.GetNewTitle.Visible = false;
            // 
            // BoxOfTasks
            // 
            this.BoxOfTasks.ContextMenuStrip = this.ContextMenuOfTasks;
            this.BoxOfTasks.FormattingEnabled = true;
            this.BoxOfTasks.ItemHeight = 25;
            this.BoxOfTasks.Location = new System.Drawing.Point(296, 44);
            this.BoxOfTasks.Name = "BoxOfTasks";
            this.BoxOfTasks.Size = new System.Drawing.Size(265, 429);
            this.BoxOfTasks.TabIndex = 12;
            this.BoxOfTasks.SelectedIndexChanged += new System.EventHandler(this.BoxOfTasks_SelectedIndexChanged);
            // 
            // ContextMenuOfTasks
            // 
            this.ContextMenuOfTasks.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuOfTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTask,
            this.DeleteTaskFromProject,
            this.ChangedStatus,
            this.SortFromStatus});
            this.ContextMenuOfTasks.Name = "ContextMenuOfTasks";
            this.ContextMenuOfTasks.Size = new System.Drawing.Size(273, 132);
            // 
            // CreateTask
            // 
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(272, 32);
            this.CreateTask.Text = "Создать задачу";
            this.CreateTask.Click += new System.EventHandler(this.NewTask);
            // 
            // DeleteTaskFromProject
            // 
            this.DeleteTaskFromProject.Name = "DeleteTaskFromProject";
            this.DeleteTaskFromProject.Size = new System.Drawing.Size(272, 32);
            this.DeleteTaskFromProject.Text = "Удалить задачу";
            this.DeleteTaskFromProject.Click += new System.EventHandler(this.DeletingTask);
            // 
            // ChangedStatus
            // 
            this.ChangedStatus.Name = "ChangedStatus";
            this.ChangedStatus.Size = new System.Drawing.Size(272, 32);
            this.ChangedStatus.Text = "Изменить статус";
            this.ChangedStatus.Click += new System.EventHandler(this.GetNewStatus);
            // 
            // SortFromStatus
            // 
            this.SortFromStatus.Name = "SortFromStatus";
            this.SortFromStatus.Size = new System.Drawing.Size(272, 32);
            this.SortFromStatus.Text = "Сортировка по статусу";
            this.SortFromStatus.Click += new System.EventHandler(this.Sorting);
            // 
            // TitleOfTasks
            // 
            this.TitleOfTasks.AutoSize = true;
            this.TitleOfTasks.Location = new System.Drawing.Point(404, 9);
            this.TitleOfTasks.Name = "TitleOfTasks";
            this.TitleOfTasks.Size = new System.Drawing.Size(57, 25);
            this.TitleOfTasks.TabIndex = 13;
            this.TitleOfTasks.Text = "Tasks:";
            // 
            // ListOfTitles
            // 
            this.ListOfTitles.FormattingEnabled = true;
            this.ListOfTitles.Items.AddRange(new object[] {
            "Epic",
            "Story",
            "Task",
            "Bug"});
            this.ListOfTitles.Location = new System.Drawing.Point(328, 488);
            this.ListOfTitles.Name = "ListOfTitles";
            this.ListOfTitles.Size = new System.Drawing.Size(203, 33);
            this.ListOfTitles.TabIndex = 15;
            // 
            // BoxOfSubtasks
            // 
            this.BoxOfSubtasks.ContextMenuStrip = this.ContextMenuOFSubTask;
            this.BoxOfSubtasks.FormattingEnabled = true;
            this.BoxOfSubtasks.ItemHeight = 25;
            this.BoxOfSubtasks.Location = new System.Drawing.Point(611, 44);
            this.BoxOfSubtasks.Name = "BoxOfSubtasks";
            this.BoxOfSubtasks.Size = new System.Drawing.Size(240, 154);
            this.BoxOfSubtasks.TabIndex = 16;
            this.BoxOfSubtasks.SelectedIndexChanged += new System.EventHandler(this.BoxOfSubtasks_SelectedIndexChanged);
            // 
            // ContextMenuOFSubTask
            // 
            this.ContextMenuOFSubTask.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuOFSubTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateSubTask,
            this.DeleteSubTask});
            this.ContextMenuOFSubTask.Name = "ContextMenuOFSubTask";
            this.ContextMenuOFSubTask.Size = new System.Drawing.Size(241, 68);
            // 
            // CreateSubTask
            // 
            this.CreateSubTask.Name = "CreateSubTask";
            this.CreateSubTask.Size = new System.Drawing.Size(240, 32);
            this.CreateSubTask.Text = "Создать подзадачу";
            this.CreateSubTask.Click += new System.EventHandler(this.GetSubTask);
            // 
            // DeleteSubTask
            // 
            this.DeleteSubTask.Name = "DeleteSubTask";
            this.DeleteSubTask.Size = new System.Drawing.Size(240, 32);
            this.DeleteSubTask.Text = "Удалить подзадачу";
            this.DeleteSubTask.Click += new System.EventHandler(this.DeleteSubtasks);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(693, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(87, 25);
            this.Title.TabIndex = 17;
            this.Title.Text = "Subtasks:";
            // 
            // ListOfTaskPerformers
            // 
            this.ListOfTaskPerformers.ContextMenuStrip = this.ContextMenuOfPerformers;
            this.ListOfTaskPerformers.FormattingEnabled = true;
            this.ListOfTaskPerformers.ItemHeight = 25;
            this.ListOfTaskPerformers.Location = new System.Drawing.Point(611, 319);
            this.ListOfTaskPerformers.Name = "ListOfTaskPerformers";
            this.ListOfTaskPerformers.Size = new System.Drawing.Size(240, 154);
            this.ListOfTaskPerformers.TabIndex = 18;
            // 
            // ContextMenuOfPerformers
            // 
            this.ContextMenuOfPerformers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuOfPerformers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppointmentExecutor,
            this.DeletingOfExecutor});
            this.ContextMenuOfPerformers.Name = "ContextMenuOfPerformers";
            this.ContextMenuOfPerformers.Size = new System.Drawing.Size(298, 68);
            // 
            // AppointmentExecutor
            // 
            this.AppointmentExecutor.Name = "AppointmentExecutor";
            this.AppointmentExecutor.Size = new System.Drawing.Size(297, 32);
            this.AppointmentExecutor.Text = "Назначение пользователя";
            this.AppointmentExecutor.Click += new System.EventHandler(this.GetExecutor);
            // 
            // DeletingOfExecutor
            // 
            this.DeletingOfExecutor.Name = "DeletingOfExecutor";
            this.DeletingOfExecutor.Size = new System.Drawing.Size(297, 32);
            this.DeletingOfExecutor.Text = "Удаление пользователя";
            this.DeletingOfExecutor.Click += new System.EventHandler(this.DeleteExecutor);
            // 
            // Performer
            // 
            this.Performer.AutoSize = true;
            this.Performer.Location = new System.Drawing.Point(663, 282);
            this.Performer.Name = "Performer";
            this.Performer.Size = new System.Drawing.Size(142, 25);
            this.Performer.TabIndex = 19;
            this.Performer.Text = "Task performers:";
            // 
            // BoxListOfUsers
            // 
            this.BoxListOfUsers.FormattingEnabled = true;
            this.BoxListOfUsers.Location = new System.Drawing.Point(641, 486);
            this.BoxListOfUsers.Name = "BoxListOfUsers";
            this.BoxListOfUsers.Size = new System.Drawing.Size(182, 33);
            this.BoxListOfUsers.TabIndex = 20;
            // 
            // ListOfSubtasks
            // 
            this.ListOfSubtasks.FormattingEnabled = true;
            this.ListOfSubtasks.Items.AddRange(new object[] {
            "Task",
            "Story"});
            this.ListOfSubtasks.Location = new System.Drawing.Point(641, 218);
            this.ListOfSubtasks.Name = "ListOfSubtasks";
            this.ListOfSubtasks.Size = new System.Drawing.Size(182, 33);
            this.ListOfSubtasks.TabIndex = 21;
            // 
            // ChangeStatus
            // 
            this.ChangeStatus.FormattingEnabled = true;
            this.ChangeStatus.Items.AddRange(new object[] {
            "Открытая задача",
            "Задача в работе",
            "Завершенная задача"});
            this.ChangeStatus.Location = new System.Drawing.Point(878, 372);
            this.ChangeStatus.Name = "ChangeStatus";
            this.ChangeStatus.Size = new System.Drawing.Size(182, 33);
            this.ChangeStatus.TabIndex = 22;
            // 
            // StatusOfTasks
            // 
            this.StatusOfTasks.AutoSize = true;
            this.StatusOfTasks.Location = new System.Drawing.Point(900, 319);
            this.StatusOfTasks.Name = "StatusOfTasks";
            this.StatusOfTasks.Size = new System.Drawing.Size(131, 25);
            this.StatusOfTasks.TabIndex = 23;
            this.StatusOfTasks.Text = "Status of tasks:";
            // 
            // GetInfoAboutProgram
            // 
            this.GetInfoAboutProgram.BackColor = System.Drawing.SystemColors.Info;
            this.GetInfoAboutProgram.Location = new System.Drawing.Point(900, 486);
            this.GetInfoAboutProgram.Name = "GetInfoAboutProgram";
            this.GetInfoAboutProgram.Size = new System.Drawing.Size(160, 65);
            this.GetInfoAboutProgram.TabIndex = 24;
            this.GetInfoAboutProgram.Text = "About";
            this.GetInfoAboutProgram.UseVisualStyleBackColor = false;
            this.GetInfoAboutProgram.Click += new System.EventHandler(this.Manager_Load);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 563);
            this.Controls.Add(this.GetInfoAboutProgram);
            this.Controls.Add(this.StatusOfTasks);
            this.Controls.Add(this.ChangeStatus);
            this.Controls.Add(this.ListOfSubtasks);
            this.Controls.Add(this.BoxListOfUsers);
            this.Controls.Add(this.Performer);
            this.Controls.Add(this.ListOfTaskPerformers);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BoxOfSubtasks);
            this.Controls.Add(this.ListOfTitles);
            this.Controls.Add(this.TitleOfTasks);
            this.Controls.Add(this.BoxOfTasks);
            this.Controls.Add(this.GetNewTitle);
            this.Controls.Add(this.CheckNewTitle);
            this.Controls.Add(this.TitelOfListProjects);
            this.Controls.Add(this.BoxOfProjects);
            this.Controls.Add(this.TitleOfBox);
            this.Controls.Add(this.ListOfUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ContextMenuOfUsers.ResumeLayout(false);
            this.ContextMenuOfProjects.ResumeLayout(false);
            this.ContextMenuOfTasks.ResumeLayout(false);
            this.ContextMenuOFSubTask.ResumeLayout(false);
            this.ContextMenuOfPerformers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListOfUsers;
        private System.Windows.Forms.Label TitleOfBox;
        private System.Windows.Forms.ListBox BoxOfProjects;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOfProjects;
        private System.Windows.Forms.ToolStripMenuItem CreateButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem RenameProject;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOfUsers;
        private System.Windows.Forms.Label TitelOfListProjects;
        private System.Windows.Forms.ToolStripMenuItem GetUser;
        private System.Windows.Forms.ToolStripMenuItem DeletingOfUsers;
        private System.Windows.Forms.Button CheckNewTitle;
        private System.Windows.Forms.TextBox GetNewTitle;
        private System.Windows.Forms.ListBox BoxOfTasks;
        private System.Windows.Forms.Label TitleOfTasks;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOfTasks;
        private System.Windows.Forms.ToolStripMenuItem CreateTask;
        private System.Windows.Forms.ComboBox ListOfTitles;
        private System.Windows.Forms.ListBox BoxOfSubtasks;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ToolStripMenuItem DeleteTaskFromProject;
        private System.Windows.Forms.ListBox ListOfTaskPerformers;
        private System.Windows.Forms.Label Performer;
        private System.Windows.Forms.ComboBox BoxListOfUsers;
        private System.Windows.Forms.ComboBox ListOfSubtasks;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOFSubTask;
        private System.Windows.Forms.ToolStripMenuItem CreateSubTask;
        private System.Windows.Forms.ToolStripMenuItem DeleteSubTask;
        private System.Windows.Forms.ContextMenuStrip ContextMenuOfPerformers;
        private System.Windows.Forms.ToolStripMenuItem AppointmentExecutor;
        private System.Windows.Forms.ToolStripMenuItem DeletingOfExecutor;
        private System.Windows.Forms.ToolStripMenuItem ChangedStatus;
        private System.Windows.Forms.ComboBox ChangeStatus;
        private System.Windows.Forms.Label StatusOfTasks;
        private System.Windows.Forms.ToolStripMenuItem SortFromStatus;
        private System.Windows.Forms.Button GetInfoAboutProgram;
    }
}

