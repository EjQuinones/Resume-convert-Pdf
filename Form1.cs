using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Resume_Json_to_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JsonButton1_Click(object sender, EventArgs e)
        {
            My_Resume my_Resume = new My_Resume()
            {
                ID = 10,
                Name = "Emmanuel John F. Quinones",
                Age = 19,
                Gender = "Male",
                Address = "204 BLPC Rd. 33 Bagong Pag Asa Quezon City",
                ContactNumber = "09212873695",
                Email = "ejquinones2@gmail.com",
                Highschool = "San Francisco Highschool",
                SeniorHighschool = "San Fracisco Highschool",
                College = "Polytechnic University Of The Philippines",
                Experiences = "introduction of computer troubleshooting, Phython, introduction of c#",


            };

            string JsonOutput = JsonConvert.SerializeObject(my_Resume);
            ResumeTextbox1.Text = JsonOutput;
        }
    }
}
