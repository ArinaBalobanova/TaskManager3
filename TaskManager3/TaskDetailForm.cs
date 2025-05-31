

namespace TaskManager
{
    public partial class TaskDetailForm : Form
    {
        private Task _currentTask;
        private AppDbContext _db;

        public TaskDetailForm()
        {
            InitializeComponent();
            
        }
        
        public void SetTask(Task task, AppDbContext db)
        {
            _currentTask = task;
            _db = db;
            

            textBoxEditTitle.Text = task.Title;
            textBoxEditDescription.Text = task.FullDescription;
            dateTimePickerEditDeadline.Value = task.Deadline < DateTime.Now ? DateTime.Now : task.Deadline;
            dateTimePickerEditDeadline.MinDate = DateTime.Now;
            textBoxEditAssignedTo.Text = task.AssignedTo;

            textBoxEditTitle.ReadOnly = true;
            textBoxEditDescription.ReadOnly = true;
            dateTimePickerEditDeadline.Enabled = false;
            textBoxEditAssignedTo.ReadOnly = true;

            buttonEdit.Visible = true;
            buttonDelete.Visible = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }
        private void TaskDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            _db.Tasks.Remove(_currentTask);
            await _db.SaveChangesAsync();
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            textBoxEditTitle.ReadOnly = false;
            textBoxEditDescription.ReadOnly = false;
            dateTimePickerEditDeadline.Enabled = true;
            textBoxEditAssignedTo.ReadOnly = false;

            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            _currentTask.Title = textBoxEditTitle.Text;
            _currentTask.FullDescription = textBoxEditDescription.Text;
            _currentTask.AssignedTo = textBoxEditAssignedTo.Text;
            _currentTask.Deadline = dateTimePickerEditDeadline.Value;

            _db.Tasks.Update(_currentTask);
            await _db.SaveChangesAsync();
            this.Close();
        }
    }
}
