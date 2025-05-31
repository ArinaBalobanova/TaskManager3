using Castle.Windsor;
using Microsoft.EntityFrameworkCore; 

namespace TaskManager
{
    public partial class TaskListForm : Form
    {
        private readonly AppDbContext _db;
        private readonly WindsorContainer _container;
        public TaskListForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
            LoadTasks();
        }

        
        private async void LoadTasks()
        {

            listBoxTasks.Items.Clear();

            var header = $"{"��������",-30} | {"��������",-50} | {"�������",-20} | {"�����������",-20}";
            listBoxTasks.Items.Add(header);
            listBoxTasks.Items.Add(new string('-', header.Length));

            var tasks = await _db.Tasks.ToListAsync();

            foreach (var task in tasks)
            {
                
                listBoxTasks.Items.Add(task);
            }
            
        }
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                _db.Tasks.Add(new Task
                {
                    Title = textBoxTitle.Text,
                    FullDescription = textBoxDescription.Text,
                    Deadline = dateTimePickerDeadline.Value,
                    AssignedTo = textBoxAssignedTo.Text
                });
                await _db.SaveChangesAsync();

                // ������� �����
                textBoxTitle.Clear();
                textBoxDescription.Clear();
                textBoxAssignedTo.Clear();
                dateTimePickerDeadline.Value = DateTime.Now.AddDays(1);

                LoadTasks();
            }
        }
        private void textBoxNewTask_TextChanged(object sender, EventArgs e)
        {
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            base.OnFormClosing(e);
        }

        private void listBoxTasks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null && listBoxTasks.SelectedItem is Task selectedTask)
            {
                var detailForm = new TaskDetailForm();
                detailForm.SetTask(selectedTask, _db);
                detailForm.ShowDialog();
                LoadTasks();
            }
        }
    }
}
