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

        private List<Panel> panelList;


        // Constructor
        public StudentServicesForm(StudentServices ss)
        {
            this.ss = ss;

            InitializeComponent();

            setFormStyle(); // Set Form Style

            // Initialize panel list
            panelList = new List<Panel>();


            // Load all info for all panels here
            // methods here, but don't show yet
            loadAcademicAdvisors();
            loadProfessionalAdvisors();
            loadFacultyAdvisors();
            loadISTMinorsAdvisors();


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
            hideShowPanels(academicAdvisorPanel);
            academicAdvisorPanel.Visible = !academicAdvisorPanel.Visible;
        }

        private void loadAcademicAdvisors()
        {
            academicAdvisorPanel = new Panel();
            academicAdvisorPanel.Dock = DockStyle.Fill;

            // Title
            MaterialLabel mlTitle = new MaterialLabel();
            mlTitle.Text = ss.academicAdvisors.title;
            mlTitle.Location = new Point(380, 20);
            academicAdvisorPanel.Controls.Add(mlTitle);

            // Description
            Label lblDesc = new Label();
            lblDesc.Text = ss.academicAdvisors.description;
            lblDesc.MaximumSize = new Size(500, 500);
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(180, 50);
            lblDesc.Font = new Font("Arial", 9);
            academicAdvisorPanel.Controls.Add(lblDesc);

            // FAQ 
            Label lblFAQ = new Label();
            lblFAQ.Text = ss.academicAdvisors.faq.title;
            lblFAQ.AutoSize = true;
            lblFAQ.Font = new Font("Arial", 10);
            lblFAQ.Location = new Point(180, 260);
            academicAdvisorPanel.Controls.Add(lblFAQ);

            // LinkLabel for FAQ
            LinkLabel linkLBL = new LinkLabel();
            linkLBL.Text = ss.academicAdvisors.faq.contentHref;
            linkLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(faqLinkClick);
            linkLBL.Location = new Point(180, 280);
            academicAdvisorPanel.Controls.Add(linkLBL);

            panel_advisors_container.Controls.Add(academicAdvisorPanel);
            academicAdvisorPanel.Visible = false; // HIDE IT initially
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
            hideShowPanels(professonalAdvisorsPanel);
            professonalAdvisorsPanel.Visible = !professonalAdvisorsPanel.Visible;
        }

        private void loadProfessionalAdvisors()
        {
            // Professional Advisors
            professonalAdvisorsPanel = new Panel();
            professonalAdvisorsPanel.Dock = DockStyle.Fill;

            MaterialLabel mlTitle = new MaterialLabel();
            mlTitle.Text = ss.professonalAdvisors.title;
            mlTitle.AutoSize = true;
            mlTitle.Location = new Point(340, 30);
            professonalAdvisorsPanel.Controls.Add(mlTitle);


            int xCoord = 100;

            List<AdvisorInformation> advisorsList = ss.professonalAdvisors.advisorInformation;
            for (int i = 0, len = advisorsList.Count; i < len; i++)
            {
                // Panel
                Panel advisorPanel = new Panel();
                advisorPanel.Size = new Size(200, 200);
                advisorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                // Advisor Name
                MaterialLabel mlName = new MaterialLabel();
                mlName.Text = advisorsList[i].name;
                mlName.AutoSize = true;
                mlName.Location = new Point(50, 60);
                advisorPanel.Controls.Add(mlName); // add this label to this advisor's panel

                // Department
                Label lblDep = new Label();
                lblDep.Text = advisorsList[i].department;
                lblDep.AutoSize = true;
                lblDep.Location = new Point(30, 80);
                lblDep.MaximumSize = new Size(150, 0);
                advisorPanel.Controls.Add(lblDep);

                // Email
                Label lblEmail = new Label();
                lblEmail.Text = advisorsList[i].email;
                lblEmail.AutoSize = true;
                lblEmail.Location = new Point(50, 150);
                advisorPanel.Controls.Add(lblEmail);

                // Positioning
                if (i != 0)
                {
                    xCoord += 220;
                }

                advisorPanel.Location = new Point(xCoord, 60);
                professonalAdvisorsPanel.Controls.Add(advisorPanel);
            }


            panel_advisors_container.Controls.Add(professonalAdvisorsPanel);
            professonalAdvisorsPanel.Visible = false;
        }
        #endregion

        #region FacultyAdvisors
        private void mb_facultyAdvisors_Click(object sender, EventArgs e)
        {
            hideShowPanels(facultyAdvisorsPanel);
            facultyAdvisorsPanel.Visible = !facultyAdvisorsPanel.Visible;
        }

        private void loadFacultyAdvisors()
        {
            facultyAdvisorsPanel = new Panel();
            facultyAdvisorsPanel.Dock = DockStyle.Fill;

            // Title
            MaterialLabel ml_FacAdvTitle = new MaterialLabel();
            ml_FacAdvTitle.Text = ss.facultyAdvisors.title;
            ml_FacAdvTitle.Location = new Point(340, 30);
            facultyAdvisorsPanel.Controls.Add(ml_FacAdvTitle);

            // Description
            Label lbl_facAdv = new Label();
            lbl_facAdv.Text = ss.facultyAdvisors.description;
            lbl_facAdv.AutoSize = true;
            lbl_facAdv.Font = new Font("Arial", 9);
            lbl_facAdv.Location = new Point(100, 70);
            lbl_facAdv.MaximumSize = new Size(600, 0);
            facultyAdvisorsPanel.Controls.Add(lbl_facAdv);

            // Set visible to false initially
            facultyAdvisorsPanel.Visible = false;
            panel_advisors_container.Controls.Add(facultyAdvisorsPanel); // add this panel to main
        }
        #endregion


        #region ISTMinorsAdvisors
        private void mb_ISTMinorsAdvisors_Click(object sender, EventArgs e)
        {
            hideShowPanels(istMinorAdvisingPanel);
            istMinorAdvisingPanel.Visible = !istMinorAdvisingPanel.Visible;
        }

        private void loadISTMinorsAdvisors()
        {
            istMinorAdvisingPanel = new Panel();
            istMinorAdvisingPanel.Dock = DockStyle.Fill;

            // Title
            MaterialLabel ml_ISTMinorTitle = new MaterialLabel();
            ml_ISTMinorTitle.Text = ss.istMinorAdvising.title;
            ml_ISTMinorTitle.Location = new Point(370, 20);
            istMinorAdvisingPanel.Controls.Add(ml_ISTMinorTitle);



            // List of minor adivor information
            List<MinorAdvisorInformation> istMinorAdvisingList = ss.istMinorAdvising.minorAdvisorInformation;
            int istMinorAdvisingLength = istMinorAdvisingList.Count;

            // Initial - preset values
            int xCoordinate = 20; 
            int yCoordinate = 60;  

            // Loop through the list
            for (int i = 0; i < istMinorAdvisingLength; i++)
            {
                // Each minor advisor panel
                Panel minorAdvisorPanel = new Panel();
                minorAdvisorPanel.Size = new Size(180, 120);
                minorAdvisorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                // Title
                MaterialLabel ml_minorAdvTitle = new MaterialLabel();
                ml_minorAdvTitle.Text = istMinorAdvisingList[i].title;
                ml_minorAdvTitle.AutoSize = true;
                ml_minorAdvTitle.Location = new Point(10, 10);
                ml_minorAdvTitle.MaximumSize = new Size(180, 0);
                minorAdvisorPanel.Controls.Add(ml_minorAdvTitle);

                // name
                Label lbl_minorAdvName = new Label();
                lbl_minorAdvName.AutoSize = true;
                lbl_minorAdvName.Text = istMinorAdvisingList[i].advisor;
                lbl_minorAdvName.Location = new Point(10, 80);
                minorAdvisorPanel.Controls.Add(lbl_minorAdvName);

                // email
                Label lbl_minorAdvEmail = new Label();
                lbl_minorAdvEmail.Text = istMinorAdvisingList[i].email;
                lbl_minorAdvEmail.AutoSize = true;
                lbl_minorAdvEmail.Location = new Point(10, 100);
                minorAdvisorPanel.Controls.Add(lbl_minorAdvEmail);

                // If not the first box. First box use the preset coordinates before for loop
                // All others need to move over 200px
                // Increment and move each time, but check for limit to then slide rest below
                if (i != 0)
                {
                    xCoordinate += 200;

                    if (xCoordinate >= 700)
                    {
                        xCoordinate = 20;
                        yCoordinate += 140;
                    }
                }
                minorAdvisorPanel.Location = new Point(xCoordinate, yCoordinate);

                istMinorAdvisingPanel.Controls.Add(minorAdvisorPanel);
            }




            istMinorAdvisingPanel.Visible = false;

            panel_advisors_container.Controls.Add(istMinorAdvisingPanel);
        }
        #endregion





        // Hides all other panels besides the one passed in
        private void hideShowPanels(Panel currPanel)
        {
            // Loop through all panels and set all other panels to hide
            // use len to cycle, calculated ONCE so all can use
            int len = panelList.Count;
            for (int i  = 0; i < len; i++)
            {
                if(panelList[i] != currPanel)
                {
                    panelList[i].Visible = false;
                }
            }
        }


        // Set Form Styling
        private void setFormStyle()
        {
            this.Text = "Advisors";
            this.Size = new Size(900, 600);

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
