using PdfiumViewer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OutlookDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
          
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            //moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
        private void guna2Button10_MouseHover(object sender, EventArgs e)
        {
            Mualliflar.Visible = false;
        }

        private void guna2Button10_MouseLeave(object sender, EventArgs e)
        {
            Mualliflar.Visible = true;
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button6_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            
        }


        private void guna2Button6_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button6_MouseLeave_1(object sender, EventArgs e)
        {
           
            guna2HtmlLabel5.Visible = false;
        }

        private void guna2Button6_MouseHover_1(object sender, EventArgs e)
        {
          
            guna2HtmlLabel5.Visible = true;
        }
     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //  glossary

            PdfDocument doc = PdfDocument.Load("amaliy\\1-amaliy.pdf");
            pdfViewer1.Document = doc;


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("glossary.pdf");
            pdfViewer1.Document = doc;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button41_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel2.Visible = false;
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
        }

        private void guna2Button64_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\23-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button40_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
        }

        private void guna2Button10_MouseHover_1(object sender, EventArgs e)
        {
            Mualliflar.Visible = true;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("binn\\Mualliflar.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button10_MouseLeave_1(object sender, EventArgs e)
        {
            Mualliflar.Visible = false;
        }

        private void guna2Button42_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\1-ma'ruza.pdf");
            pdfViewer1.Document = doc;
            //amaliy
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\2-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\3-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\4-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\5-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\6-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\7-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\8-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\9-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\10-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\11-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\12-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\13-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\14-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\16-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\15-amaliy.pdf");
            pdfViewer1.Document = doc;

        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\17-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\18-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\19-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button34_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\20-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button35_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\21-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\22-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button37_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\23-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("amaliy\\24-amaliy.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button43_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\2-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button44_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\3-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button45_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\4-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button46_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\5-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button47_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\6-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button48_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\7-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button49_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\8-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button50_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\9-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button51_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\10-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button52_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\11-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button53_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\12-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button54_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\13-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button55_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\14-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button56_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\15-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button57_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\16-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button58_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\17-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button59_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\18-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button60_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\19-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button61_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\20-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button62_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\21-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button63_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\22-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button65_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("maruza\\24-ma'ruza.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("binn\\ADABIYOTLAR.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("binn\\test.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("binn\\FD.pdf");
            pdfViewer1.Document = doc;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("binn\\ID.pdf");
            pdfViewer1.Document = doc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PdfDocument doc = PdfDocument.Load("binn\\MUQOVA.pdf");
            pdfViewer1.Document = doc;
        }
    }
}
