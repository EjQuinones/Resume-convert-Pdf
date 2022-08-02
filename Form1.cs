using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                Skills = "Computer Troubleshoot, Cyber Security Insttaller, Web developer"


            };

            string JsonOutput = JsonConvert.SerializeObject(my_Resume);
            ResumeTextbox1.Text = JsonOutput;
        }

        private void ConvertPdfButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = " My Resume, ValidateNames = True " })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(ResumeTextbox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
