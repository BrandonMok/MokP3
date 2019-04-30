﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MokP3
{
    public partial class StudentServicesForm : MaterialForm
    {
        private StudentServices ss;
        private Panel academicAdvisorPanel;
        private Panel professonalAdvisorsPanel;
        private Panel facultyAdvisorsPanel;
        private Panel istMinorAdvisingPanel;

        private List<Panel> panelList = null;

        // Constructor
        public StudentServicesForm(StudentServices ss)
        {
            this.ss = ss;

            InitializeComponent();

            setFormStyle(); // Set Form Style
            
            // Keep a list of all panels
            // Will use to show/hide based on clicked button
            panelList.Add(academicAdvisorPanel);
            panelList.Add(professonalAdvisorsPanel);
            panelList.Add(facultyAdvisorsPanel);
            panelList.Add(istMinorAdvisingPanel);
        }


        #region AcademicAdvisors
        // Academic Advisors Click Button
        private void mb_academicAdvisor_Click(object sender, EventArgs e)
        {
            // Check if panel doesn't exist
            // First time! Only ran once
            if (academicAdvisorPanel == null)
            {
                academicAdvisorPanel = new Panel();
                academicAdvisorPanel.Dock = DockStyle.Fill;

                MaterialLabel mlTitle = new MaterialLabel();
                mlTitle.Text = ss.academicAdvisors.title;
                mlTitle.Location = new Point(380, 20);
                academicAdvisorPanel.Controls.Add(mlTitle);

                Label lblDesc = new Label();
                lblDesc.Text = ss.academicAdvisors.description;
                lblDesc.MaximumSize = new Size(500, 500);
                lblDesc.AutoSize = true;
                lblDesc.Location = new Point(180, 50);
                academicAdvisorPanel.Controls.Add(lblDesc);

                Label lblFAQ = new Label();
                lblFAQ.Text = ss.academicAdvisors.faq.title;
                lblFAQ.AutoSize = true;
                lblFAQ.Font = new Font("Arial", 10);
                lblFAQ.Location = new Point(180, 220);
                academicAdvisorPanel.Controls.Add(lblFAQ);

                LinkLabel ll = new LinkLabel();
                ll.Text = ss.academicAdvisors.faq.contentHref;
                ll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(faqLinkClick);
                ll.Location = new Point(180, 250);
                academicAdvisorPanel.Controls.Add(ll);

                panel_advisors_container.Controls.Add(academicAdvisorPanel);
                academicAdvisorPanel.Show();

                if (professonalAdvisorsPanel != null)
                {
                    professonalAdvisorsPanel.Visible = false;
                }

            }
            else 
            {
                if (professonalAdvisorsPanel != null)
                {
                    professonalAdvisorsPanel.Visible = false;
                }


                // Toggle visibility
                academicAdvisorPanel.Visible = !academicAdvisorPanel.Visible;
            }
        }

        private void faqLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            System.Diagnostics.Process.Start(ll.Text);
        }
        #endregion


        #region ProfessionalAdvisors
        private void mb_professionalAdvisors_Click(object sender, EventArgs e)
        {
            if(professonalAdvisorsPanel == null)
            {
                professonalAdvisorsPanel = new Panel();
                professonalAdvisorsPanel.Dock = DockStyle.Fill;

                MaterialLabel mlTitle = new MaterialLabel();
                mlTitle.Text = ss.professonalAdvisors.title;
                mlTitle.AutoSize = true;
                mlTitle.Location = new Point(340, 30);
                professonalAdvisorsPanel.Controls.Add(mlTitle);


                int xCoord = 100;

                List<AdvisorInformation> advisorsList = ss.professonalAdvisors.advisorInformation;
                for(int i = 0, len = advisorsList.Count; i < len; i++)
                {
                    Panel advisorPanel = new Panel();
                    advisorPanel.Size = new Size(200, 200);
                    advisorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


                    // Positioning
                    if (i != 0)
                    {
                        xCoord += 220;
                    }

                    advisorPanel.Location = new Point(xCoord, 60);
                    professonalAdvisorsPanel.Controls.Add(advisorPanel);
                    if (academicAdvisorPanel != null)
                    {
                        academicAdvisorPanel.Visible = false;
                    }
                }


                panel_advisors_container.Controls.Add(professonalAdvisorsPanel);
                professonalAdvisorsPanel.Show();
            }
            else
            {
                if(academicAdvisorPanel != null)
                {
                    academicAdvisorPanel.Visible = false;
                }

                // Toggle
                professonalAdvisorsPanel.Visible = !professonalAdvisorsPanel.Visible;
            }
        }
        #endregion




        // Set Form Styling
        private void setFormStyle()
        {
            this.Text = "Advisors";

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
    }
}
