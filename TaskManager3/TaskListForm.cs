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
            InitializeComponents();
            LoadTasks();

        }
        private void InitializeComponents()
        {
            listViewTasks.View = View.Details;
            listViewTasks.FullRowSelect = true;
            listViewTasks.GridLines = true;
            var taskColumns = new (string Text, int Width)[]
            {
        ("Название", 150),
        ("Описание", 250),
        ("Дедлайн", 100),
        ("Исполнитель", 150)
            };

            foreach (var column in taskColumns)
            {
                listViewTasks.Columns.Add(column.Text, column.Width);
            }
        }

        public async void LoadTasks()
        {

            listViewTasks.Items.Clear();

            var tasks = await _db.Tasks.ToListAsync();

            foreach (var task in tasks)
            {
                var item = new ListViewItem(task.Title);
                item.SubItems.Add(task.FullDescription);
                item.SubItems.Add(task.Deadline.ToString("d"));
                item.SubItems.Add(task.AssignedTo);

                item.Tag = task;

                listViewTasks.Items.Add(item);
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

        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                var selectedItem = listViewTasks.SelectedItems[0];

                if (selectedItem.Tag is Task selectedTask)
                {
                    var detailForm = new TaskDetailForm();
                    detailForm.SetTask(selectedTask, _db, this);
                    detailForm.ShowDialog(); ;

                    LoadTasks();
                }
            }

        }
        public void ClearSelection()
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                listViewTasks.SelectedItems[0].Selected = false;
            }

            listViewTasks.Focus();
        }

    }
}
