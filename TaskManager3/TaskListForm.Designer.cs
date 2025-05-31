
namespace TaskManager
{
    partial class TaskListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListForm));
            textBoxTitle = new TextBox();
            buttonAdd = new Button();
            listBoxTasks = new ListBox();
            textBoxDescription = new TextBox();
            textBoxAssignedTo = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            lblTasks = new Label();
            lblTaskTitle = new Label();
            lblTaskDescription = new Label();
            lblTaskDeadline = new Label();
            lblTaskAssignedTo = new Label();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(223, 225);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(552, 27);
            textBoxTitle.TabIndex = 1;
            textBoxTitle.TextChanged += textBoxNewTask_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(603, 459);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(172, 34);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить задачу";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = SystemColors.Window;
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.Location = new Point(26, 38);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(749, 164);
            listBoxTasks.TabIndex = 3;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged_1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(223, 270);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(552, 75);
            textBoxDescription.TabIndex = 4;
            // 
            // textBoxAssignedTo
            // 
            textBoxAssignedTo.Location = new Point(341, 414);
            textBoxAssignedTo.Name = "textBoxAssignedTo";
            textBoxAssignedTo.Size = new Size(434, 27);
            textBoxAssignedTo.TabIndex = 5;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(538, 370);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(237, 27);
            dateTimePickerDeadline.TabIndex = 6;
            // 
            // lblTasks
            // 
            lblTasks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTasks.Location = new Point(26, 9);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(219, 25);
            lblTasks.TabIndex = 7;
            lblTasks.Text = "Список задач";
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskTitle.Location = new Point(26, 225);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(190, 25);
            lblTaskTitle.TabIndex = 8;
            lblTaskTitle.Text = "Задача";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskDescription.Location = new Point(26, 273);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(190, 25);
            lblTaskDescription.TabIndex = 9;
            lblTaskDescription.Text = "Описание";
            // 
            // lblTaskDeadline
            // 
            lblTaskDeadline.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskDeadline.Location = new Point(26, 370);
            lblTaskDeadline.Name = "lblTaskDeadline";
            lblTaskDeadline.Size = new Size(190, 25);
            lblTaskDeadline.TabIndex = 10;
            lblTaskDeadline.Text = "Дедлайн по задаче";
            // 
            // lblTaskAssignedTo
            // 
            lblTaskAssignedTo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskAssignedTo.Location = new Point(26, 416);
            lblTaskAssignedTo.Name = "lblTaskAssignedTo";
            lblTaskAssignedTo.Size = new Size(190, 25);
            lblTaskAssignedTo.TabIndex = 11;
            lblTaskAssignedTo.Text = "Исполнитель";
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(834, 498);
            Controls.Add(lblTaskAssignedTo);
            Controls.Add(lblTaskDeadline);
            Controls.Add(lblTaskDescription);
            Controls.Add(lblTaskTitle);
            Controls.Add(lblTasks);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(textBoxAssignedTo);
            Controls.Add(textBoxDescription);
            Controls.Add(listBoxTasks);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTitle);
            Name = "TaskListForm";
            Text = "TaskManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTitle;
        private Button buttonAdd;
        private ListBox listBoxTasks;
        private TextBox textBoxDescription;
        private TextBox textBoxAssignedTo;
        private DateTimePicker dateTimePickerDeadline;
        private Label lblTasks;
        private Label lblTaskTitle;
        private Label lblTaskDescription;
        private Label lblTaskDeadline;
        private Label lblTaskAssignedTo;
    }
}
