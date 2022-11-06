using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCloset
{
    public partial class UploadView : Form
    {
        Form1 origView;
        Wardrobe origWardrobe;
        public int ReturnValueIndex { get; set; }
        public string ReturnValuePic { get; set; }
        public UploadView(Form1 view, Wardrobe w)
        {
            InitializeComponent();
            origView = view;
            origWardrobe = w;
            view.Hide();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if(itemSelect.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please Select One Type");
            }
            else if(itemSelect.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please Select Only One Type");
            }
            else
            {
                if (itemSelect.CheckedItems[0].ToString().Equals("Top"))
                {
                    ReturnValueIndex = 1;
                    ReturnValuePic = origWardrobe.AddTop();
                    this.Close();
                    origView.Show();
                }
                else if (itemSelect.CheckedItems[0].ToString().Equals("Bottom"))
                {
                    ReturnValueIndex = 2;
                    ReturnValuePic = origWardrobe.AddBottom();
                    this.Close();
                    origView.Show();
                }
                else if (itemSelect.CheckedItems[0].ToString().Equals("Shoes"))
                {
                    ReturnValueIndex = 3;
                    // origWardrobe.AddShoes();
                    this.Close();
                    origView.Show();
                }
                else
                {
                    MessageBox.Show("No Item Selected");
                }
            }
        }
    }
}
