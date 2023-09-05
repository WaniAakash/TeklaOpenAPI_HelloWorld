using System;
using System.Windows.Forms;

using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;

namespace tekla_Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create model instance and check connecction status

            Model model = new Model();
            if (!model.GetConnectionStatus())
            {
                MessageBox.Show(" Tekla Structure not connected.");
                return;
            }

            // Get model info and send msg "Hello World" to message box

            ModelInfo modelInfo = model.GetInfo();
            string name = modelInfo.ModelName;
            MessageBox.Show(string.Format("Hello World! Your current model is named: {0}", name));

            // Send "Hello world" msg to tekla structure user command prompt

            Operation.DisplayPrompt(string.Format("Hello World! Your current model is named: {0}", name));
        }
    }
}
