namespace To_Do_List
//Author: Jayden Robertson
//Date: 09/03/2025
//Description: This is a simple to do list application that allows the user to add, delete, complete, move up and move down tasks in a list.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //This is the label, isn't meant to do anything   
        }

        //Delete task from list
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) //Check if item is selected
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); //Remove selected item
            }
        }

        //Add task to lists
        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTask.Text)) //Check if textbox is empty
            {
                listBox1.Items.Add(textBoxTask.Text); //Add task to listbox
                textBoxTask.Clear();
            }
        }

        //Complete task in list
        private void pictureBoxComplete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //Get selected task
            if (index != -1)
            {
                string task = listBox1.SelectedItem.ToString();

                if (task.StartsWith("✔"))
                {
                    task = task.Substring(4); // Remove "✔" from task
                }
                else
                {
                    task = "✔ " + task; // Add "✔" to task
                }

                listBox1.Items[index] = task; // Update task in listbox
            }
        }

        // Move task up in list
        private void pictureBoxUp_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; //Get selected task
            if (index > 0)
            {
                //Swap selected task with the one above
                var temp = listBox1.Items[index];
                listBox1.Items[index] = listBox1.Items[index - 1];
                listBox1.Items[index - 1] = temp;
                listBox1.SelectedIndex = index - 1;
            }
        }

        // Move task down in list
        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex; // Get selected task
            if (index < 1)
            {
                //Swap selected task with the one below
                var temp = listBox1.Items[index]; 
                listBox1.Items[index] = listBox1.Items[index + 1]; 
                listBox1.Items[index + 1] = temp; 
                listBox1.SelectedIndex = index + 1;
            }
        }
    }
}
