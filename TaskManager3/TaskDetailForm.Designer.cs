namespace TaskManager
{
    partial class TaskDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetailForm));
            labelTaskTitle = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxEditTitle = new TextBox();
            textBoxEditDescription = new TextBox();
            textBoxEditAssignedTo = new TextBox();
            dateTimePickerEditDeadline = new DateTimePicker();
            lblTaskDescription = new Label();
            lblTaskDeadline = new Label();
            lblTaskAssignedTo = new Label();
            SuspendLayout();
            // 
            // labelTaskTitle
            // 
            labelTaskTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTaskTitle.Location = new Point(32, 42);
            labelTaskTitle.Name = "labelTaskTitle";
            labelTaskTitle.Size = new Size(171, 36);
            labelTaskTitle.TabIndex = 0;
            labelTaskTitle.Text = "Задача";
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(734, 354);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(121, 36);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(551, 354);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(139, 36);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(734, 396);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(121, 38);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(551, 401);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(139, 33);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxEditTitle
            // 
            textBoxEditTitle.Location = new Point(233, 42);
            textBoxEditTitle.Name = "textBoxEditTitle";
            textBoxEditTitle.Size = new Size(595, 27);
            textBoxEditTitle.TabIndex = 1;
            textBoxEditTitle.TextChanged += textBoxEdit_TextChanged;
            // 
            // textBoxEditDescription
            // 
            textBoxEditDescription.Location = new Point(233, 110);
            textBoxEditDescription.Multiline = true;
            textBoxEditDescription.Name = "textBoxEditDescription";
            textBoxEditDescription.Size = new Size(595, 77);
            textBoxEditDescription.TabIndex = 6;
            // 
            // textBoxEditAssignedTo
            // 
            textBoxEditAssignedTo.Location = new Point(233, 275);
            textBoxEditAssignedTo.Name = "textBoxEditAssignedTo";
            textBoxEditAssignedTo.Size = new Size(595, 27);
            textBoxEditAssignedTo.TabIndex = 7;
            // 
            // dateTimePickerEditDeadline
            // 
            dateTimePickerEditDeadline.Location = new Point(591, 220);
            dateTimePickerEditDeadline.Name = "dateTimePickerEditDeadline";
            dateTimePickerEditDeadline.Size = new Size(237, 27);
            dateTimePickerEditDeadline.TabIndex = 8;
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskDescription.Location = new Point(32, 109);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(171, 36);
            lblTaskDescription.TabIndex = 9;
            lblTaskDescription.Text = "Описание";
            // 
            // lblTaskDeadline
            // 
            lblTaskDeadline.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskDeadline.Location = new Point(32, 211);
            lblTaskDeadline.Name = "lblTaskDeadline";
            lblTaskDeadline.Size = new Size(171, 36);
            lblTaskDeadline.TabIndex = 10;
            lblTaskDeadline.Text = "Дедлайн по задаче";
            // 
            // lblTaskAssignedTo
            // 
            lblTaskAssignedTo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTaskAssignedTo.Location = new Point(32, 275);
            lblTaskAssignedTo.Name = "lblTaskAssignedTo";
            lblTaskAssignedTo.Size = new Size(171, 27);
            lblTaskAssignedTo.TabIndex = 11;
            lblTaskAssignedTo.Text = "Исполнитель";
            // 
            // TaskDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(888, 459);
            Controls.Add(lblTaskAssignedTo);
            Controls.Add(lblTaskDeadline);
            Controls.Add(lblTaskDescription);
            Controls.Add(dateTimePickerEditDeadline);
            Controls.Add(textBoxEditAssignedTo);
            Controls.Add(textBoxEditDescription);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxEditTitle);
            Controls.Add(labelTaskTitle);
            Name = "TaskDetailForm";
            Text = "TaskManager";
            Load += TaskDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTaskTitle;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxEditTitle;
        private TextBox textBoxEditDescription;
        private TextBox textBoxEditAssignedTo;
        private DateTimePicker dateTimePickerEditDeadline;
        private Label lblTaskDescription;
        private Label lblTaskDeadline;
        private Label lblTaskAssignedTo;
    }
}