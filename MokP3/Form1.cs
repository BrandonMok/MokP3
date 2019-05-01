﻿using Newtonsoft.Json.Linq;
using RESTUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace MokP3
{
    public partial class Form1 : MaterialForm     
    {
        // Instantiate my rest class
        REST rj = new REST("http://ist.rit.edu/api");

        // Instantiate my objects - if I need it later, able to access object info
        About about;
        Degrees degrees;
        Minors minors;
        Employment employment;
        People people;
        Research research;
        Resources resources;
        //News news;
        //Footer footer;


        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(900, 500); // Change size of the form
            this.Text = "IST Department";  // Change title of 

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // json2csharp.com

            // ABOUT
            string jsonAbout = rj.getRESTDataJSON("/about/"); 
            about = JToken.Parse(jsonAbout).ToObject<About>(); // cast it to the About object

            //textBox1.Text = about.description;
            lbl_title.Text = about.title;
            lbl_title.Font = new Font("Arial", 10);

            lbl_description.Text = about.description;
            lbl_description.MaximumSize = new Size(500, 0);
            lbl_description.Font = new Font("Arial", 9);

            lbl_quote.Text = about.quote;
            lbl_quote.MaximumSize = new Size(400, 0);
            lbl_quote.Font = new Font("Arial", 9);

            lbl_quote_author.Text = "- " + about.quoteAuthor;

            // NEWS
            // string jsonNews = rj.getRESTDataJSON("/news/");
            //News news = JToken.Parse(jsonNews).ToObject<News>();

            // FOOTER
            // string jsonFooter = rj.getRESTDataJSON("/footer/");
            // footer = JToken.Parse(jsonFooter).ToObject<Footer>();
        }





        #region DegreesPageEnter
        private void DegreesPage_Enter(object sender, EventArgs e)
        {
            if(degrees == null)
            {
                // Load in Degree Data!
                string jsonDegrees = rj.getRESTDataJSON("/degrees/");
                degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();
            }

        }

        #region DegreesClicks
        private void panel_uDegrees_WMC_Click(object sender, EventArgs e)
        {
            Undergraduate ug = degrees.undergraduate.Find(x => x.degreeName == "wmc");
            EachDegree ed = new EachDegree(ug, null);
            ed.ShowDialog();
        }

        private void panel_uDegrees_HCC_Click(object sender, EventArgs e)
        {
            Undergraduate ug = degrees.undergraduate.Find(x => x.degreeName == "hcc");
            EachDegree ed = new EachDegree(ug, null);
            ed.ShowDialog();
        }

        private void panel_uDegrees_CIT_Click(object sender, EventArgs e)
        {
            Undergraduate ug = degrees.undergraduate.Find(x => x.degreeName == "cit");
            EachDegree ed = new EachDegree(ug, null);
            ed.ShowDialog();
        }

        private void panel_gDegrees_IST_Click(object sender, EventArgs e)
        {
            Graduate grad = degrees.graduate.Find(x => x.degreeName == "ist");
            EachDegree ed = new EachDegree(null, grad);
            ed.ShowDialog();
        }

        private void panel_gDegrees_HCI_Click(object sender, EventArgs e)
        {
            Graduate grad = degrees.graduate.Find(x => x.degreeName == "hci");
            EachDegree ed = new EachDegree(null, grad);
            ed.ShowDialog();
        }

        private void panel_gDegrees_NSA_Click(object sender, EventArgs e)
        {
            Graduate grad = degrees.graduate.Find(x => x.degreeName == "nsa");
            EachDegree ed = new EachDegree(null, grad);
            ed.ShowDialog();
        }
        #endregion

        #endregion


        #region MinorsPageEnter
        private void MinorsPage_Enter(object sender, EventArgs e)
        {
            if(minors == null)
            {
                // Get Minors Data
                string jsonMinors = rj.getRESTDataJSON("/minors/");
                minors = JToken.Parse(jsonMinors).ToObject<Minors>();
            }

        }

        #region MinorsClicks
        private void panel_minors_DBDDI_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "DBDDI-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panel_minors_GIS_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "GIS-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panel_minors_MEDINFO_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "MEDINFO-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panels_minors_MDDEV_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "MDDEV-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panel_minors_MDEV_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "MDEV-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panel_minors_NETSYS_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "NETSYS-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panel_minors_WEBDD_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "WEBDD-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }

        private void panel_minors_WEBD_Click(object sender, EventArgs e)
        {
            UgMinor ugm = minors.UgMinors.Find(x => x.name == "WEBD-MN");
            EachMinor em = new EachMinor(ugm);
            em.ShowDialog();
        }
        #endregion
        #endregion


        #region EmploymentPage
        // Employment Page Enter
        private void employmentPage_Enter(object sender, EventArgs e)
        {
            // CHECK: if I have the data already
            if (employment == null)
            {
                string jsonEmployment = rj.getRESTDataJSON("/employment/");
                employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            }

            // Set the title
            lbl_employment_introTitle.Text = employment.introduction.title;

            // Descriptions
            lbl_employment_content.Text = employment.introduction.content[0].description;
            lbl_coop_content.Text = employment.introduction.content[1].description;

            // Employment Content
            lbl_employment_content.MaximumSize = new Size(325, 400);
            lbl_employment_content.Font = new Font("Arial", 9);

            // Coop Content
            lbl_coop_content.MaximumSize = new Size(325, 400);
            lbl_coop_content.Font = new Font("Arial", 9);
        }


        // Show employment/coop tables!
        private void btn_showTables_Click(object sender, EventArgs e)
        {
            // Send data to Tables.cs Form to display table data
            // NOTE: Already have the employment object from the enter event of the page
            Tables tables = new Tables(employment);
            tables.ShowDialog();
        }

        // Show statistics / employers / careers
        private void btn_moreInfo_Click(object sender, EventArgs e)
        {
            MoreInfo mi = new MoreInfo(employment.degreeStatistics, employment.careers, employment.employers);
            mi.ShowDialog();
        }
        #endregion


        #region PeoplePage
        private void peoplePage_Enter(object sender, EventArgs e)
        {
            if(people == null)
            {
                string jsonpeople = rj.getRESTDataJSON("/people/");
                people = JToken.Parse(jsonpeople).ToObject<People>();
            }

            // Set the SubTitle
            lbl_people_subtitle.Text = people.subTitle;


            // Keep all the faculty & staff in a list
            List<Faculty> facultyList = people.faculty;
            List<Staff> staffList = people.staff;

            // Need a check to reset content
            int newPointX = 0;
            int newPointY = 0;

            for (int i = 0; i < facultyList.Count; i++) // 34 fac in total
            {
                // Panel that acts as a container for each person
                Panel newPanel = new Panel();
                newPanel.Size = new Size(90, 90);
                newPanel.Name = "panel_" + facultyList[i].username; // make panel's name the same as the person

                newPanel.Cursor = Cursors.Hand;

                // Each image of person
                PictureBox pb = new PictureBox();
                pb.Load(facultyList[i].imagePath);
                pb.Dock = DockStyle.Fill;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                newPanel.Controls.Add(pb);

                // set an onclick to pass in the username to find that data
                pb.Click += new EventHandler(pictureBox_Click);

             

                // If not the first person box, then move the next one over
                if (i != 0)
                {
                    newPointX += 100;
                }

                // if reaches a certain point, reset the x coordinate and change the y coordinate
                if (newPointX >= 800)
                {
                    newPointX = 0;
                    newPointY += 100;
                }
                
                newPanel.Location = new Point(newPointX, newPointY);

                // Finally add the new dynamic panel to the main panel
                panel_faculty_container.Controls.Add(newPanel);
            }



            // STAFF
            int newPointSX = 0;
            int newPointSY = 0;

            for (int i = 0; i < staffList.Count; i++) // 17 fac in total
            {
                // Panel that acts as a container for each person
                Panel newStaffPanel = new Panel();
                newStaffPanel.Size = new Size(90, 90);
                newStaffPanel.Name = "panel_" + staffList[i].username; // make panel's name the same as the person

                newStaffPanel.Cursor = Cursors.Hand;

                // Each image of person
                PictureBox pb2 = new PictureBox();
                pb2.Load(staffList[i].imagePath);
                pb2.Dock = DockStyle.Fill;
                pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                newStaffPanel.Controls.Add(pb2);

                // set an onclick to pass in the username to find that data
                pb2.Click += new EventHandler(pictureBox_Click);


                // If not the first person box, then move the next one over
                if (i != 0)
                {
                    newPointSX += 100;
                }

                // if reaches a certain point, reset the x coordinate and change the y coordinate
                if (newPointSX >= 800)
                {
                    newPointSX = 0;
                    newPointSY += 100;
                }

                newStaffPanel.Location = new Point(newPointSX, newPointSY);

                // Finally add the new dynamic panel to the main panel
                panel_staff_container.Controls.Add(newStaffPanel);
            }
        }

        // Click on specific person!
        private void pictureBox_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            string filepath = pb.ImageLocation;

            int lastSlash = filepath.LastIndexOf("/") + 1;

            string userName = filepath.Substring(lastSlash,6);

            // BOTH objects look for the username, will check which is null to know where it is
            Faculty fac = people.faculty.Find(x => x.username == userName);
            Staff staff = people.staff.Find(x => x.username == userName);

            FacStaff fs; // facultyStaff separate form
           

            if(staff != null)
            {
                fs = new FacStaff(null, staff);
                fs.ShowDialog();
            }
            else
            {
                string usrName = filepath.Substring(lastSlash, 7);
                Staff anotherStaff = people.staff.Find(x => x.username == usrName);

                if (anotherStaff != null)
                {
                    fs = new FacStaff(null, anotherStaff);
                    fs.ShowDialog();
                }
            }

      
            
            if (fac != null)
            {
                fs = new FacStaff(fac, null);
                fs.ShowDialog();
            }
        }
        #endregion


        #region ResearchPage
        private void researchPage_Enter(object sender, EventArgs e)
        {
            // RESEARCH
            string jsonResearch = rj.getRESTDataJSON("/research/");
            research = JToken.Parse(jsonResearch).ToObject<Research>();

            cb_research.SelectedItem = "ByInterestArea"; // By Default show ByInterestArea
        }

        // When change on combobox options
        private void cb_research_change(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string changed = cb.Text;

            switch (changed)
            {
                case "ByInterestArea":
                    getResearchInterestArea();
                    break;
                case "ByFaculty":
                    getResearchFaculty();
                    break;
                default:
                    getResearchInterestArea();
                    break;
            }
        }

        // Interest Area - for the main form
        private void getResearchInterestArea()
        {
            // Clear panel contents before changing content
            panel_research_container.Controls.Clear();

            // Coordinates for the point
            int xCoord = 0;
            int yCoord = 0;

            // List of interestAreas
            List<ByInterestArea> interestList = research.byInterestArea;

            // Cycle through all!
            for(int i = 0; i < interestList.Count; i++)
            {
                Button btnNew = new Button();
                btnNew.Size = new Size(90, 90);
                btnNew.Name = "btn_" + interestList[i].areaName;
                //btnNew.Name = interestList[i].areaName;
                btnNew.Text = interestList[i].areaName;

                btnNew.Cursor = Cursors.Hand;
                btnNew.Click += new EventHandler(getResearch);



                // If not the first person box, then move the next one over
                if (i != 0)
                {
                    xCoord += 100;
                }

                // if reaches a certain point, reset the x coordinate and change the y coordinate
                if (xCoord >= 800)
                {
                    xCoord = 0;
                    yCoord += 100;
                }

                // Set Location of each panel
               // iaPanel.Location = new Point(xCoord, yCoord);
                btnNew.Location = new Point(xCoord, yCoord);

                // Finally add the new dynamic panel to the main panel
                panel_research_container.Controls.Add(btnNew);
            }
        }

        // By Faculty - for the main form
        private void getResearchFaculty()
        {
            // Clear panel contents before changing content
            panel_research_container.Controls.Clear();

            // Coordinates
            int xCoordinate = 0;
            int yCoordinate = 0;

            // List of faculty research
            List<ByFaculty> byFacultyList = research.byFaculty;

            // Loop through all in the list
            for(int i = 0; i < byFacultyList.Count; i++)
            {
                Button btnNew = new Button();
                btnNew.Size = new Size(90, 90);
                btnNew.Name = "btn_" + byFacultyList[i].username;
                //btnNew.Name = byFacultyList[i].username;
                btnNew.Text = byFacultyList[i].username;

                btnNew.Cursor = Cursors.Hand;
                btnNew.Click += new EventHandler(getResearch);


                if (i != 0)
                {
                    xCoordinate += 100;
                }
                

                // if reaches a certain point, reset the x coordinate and change the y coordinate
                if (xCoordinate >= 800)
                {
                    xCoordinate = 0;
                    yCoordinate += 100;
                }

                btnNew.Location = new Point(xCoordinate, yCoordinate);
                panel_research_container.Controls.Add(btnNew);
            }
        }

        // Get
        private void getResearch(object sender, EventArgs e) 
        {
            Button clickedButton = sender as Button;
            //Console.WriteLine(clickedButton.Name);


            // If wanted to make it reusable, if there are more areas added in future!
            // get length of string
            // get last index of bit
            // length - index
            // substring(lastIndex, length-lastIndex)
            string buttonName = clickedButton.Name;
            int btnSection = buttonName.LastIndexOf("_") + 1;
            int nameLength = buttonName.Length;
            int name = nameLength - btnSection;
            string researchName = buttonName.Substring(btnSection, name);
            Console.WriteLine(researchName);

            // Make objects to find. See which one is not null to send over
            ByInterestArea bia = research.byInterestArea.Find(x => x.areaName == researchName);
            ByFaculty byFac = research.byFaculty.Find(x => x.username == researchName);

            // Have one form obj
            EachResearch er = null;

            // Find which is the clicked one and pass info
            if(bia != null)
            {
                er = new EachResearch(bia);
            }
            else if(byFac != null)
            {
                er = new EachResearch(byFac);
            }
            er.ShowDialog();
        }
        #endregion


        #region ResourcesPage
        private void resourcesPage_Enter(object sender, EventArgs e)
        {
            if (resources == null)
            {
                string jsonResources = rj.getRESTDataJSON("/resources/");
                resources = JToken.Parse(jsonResources).ToObject<Resources>();
            }

            // Set the subtitle
            lbl_studentRes_subTitle.Text = resources.subTitle;
        }

        // STUDY ABROAD
        private void btn_studyAbroad_Click(object sender, EventArgs e)
        {
            // Get the studyAbroad and pass obj to another form
            StudyAbroadForm sa = new StudyAbroadForm(resources.studyAbroad);
            sa.ShowDialog();
        }

        // FACULTY ADVISORS
        private void btn_facultyAdvisors_Click(object sender, EventArgs e)
        {
            StudentServicesForm ss = new StudentServicesForm(resources.studentServices);
            ss.ShowDialog();
        }

        // TUTORS / LAB
        private void btn_tutorsAndLabInformation_Click(object sender, EventArgs e)
        {
            LabsTutorsForm ltf = new LabsTutorsForm(resources.tutorsAndLabInformation);
            ltf.ShowDialog();
        }

        // STUDENT AMBASSADORS
        private void btn_studentAmbassadors_Click(object sender, EventArgs e)
        {
            StudentAmbassadorsForm saf = new StudentAmbassadorsForm(resources.studentAmbassadors);
            saf.ShowDialog();
        }

        // FORMS
        private void btn_forms_Click(object sender, EventArgs e)
        {
            FormsForm ff = new FormsForm(resources.forms);
            ff.ShowDialog();
        }
        #endregion










        #region peopleTestInclass
        private void btn_people_click(object sender, EventArgs e)
        {
            // get the json for people
            string jsonpeople = rj.getRESTDataJSON("/people/");
            people = JToken.Parse(jsonpeople).ToObject<People>();

            // play with data
            foreach (Faculty thisfac in people.faculty)
            {
                Console.WriteLine(thisfac.name);
                //pictureBox1.Load(thisfac.imagePath);
            }

            // issue is how to find data on ONE individual?
            getSingleInstance("dsbics");
        }



        private void getSingleInstance(string id)
        {
            // Would send the data to another form!

            Faculty result = people.faculty.Find(x => x.username == id);
            //Console.WriteLine(result.office);


            // useful
            List<Faculty> res = people.faculty.FindAll(x => x.title == "Associate Professor");
            //Console.WriteLine(res[3].name);
        }
        #endregion


        #region LinkLabelToPDF
        // Can be used multiple times
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // go and load the pdf!
            // which url do I need? We can get it from sender

            // LinkLabel me = (LinkLabel)sender; 
            LinkLabel me = sender as LinkLabel;

            // make me look like I was visited
            me.LinkVisited = true;

            System.Diagnostics.Process.Start(me.Text);
        }






        #endregion

    }
}
