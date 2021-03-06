﻿namespace MokP3
{
    partial class StudyAbroadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ml_studyAbroad_title = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_studyAbroad_desc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ml_place1_name = new MaterialSkin.Controls.MaterialLabel();
            this.ml_place2_name = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_place1_desc = new System.Windows.Forms.Label();
            this.lbl_place2_desc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ml_studyAbroad_title
            // 
            this.ml_studyAbroad_title.AutoSize = true;
            this.ml_studyAbroad_title.Depth = 0;
            this.ml_studyAbroad_title.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_studyAbroad_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_studyAbroad_title.Location = new System.Drawing.Point(469, 112);
            this.ml_studyAbroad_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_studyAbroad_title.Name = "ml_studyAbroad_title";
            this.ml_studyAbroad_title.Size = new System.Drawing.Size(141, 27);
            this.ml_studyAbroad_title.TabIndex = 0;
            this.ml_studyAbroad_title.Text = "Study Abroad";
            // 
            // lbl_studyAbroad_desc
            // 
            this.lbl_studyAbroad_desc.AutoSize = true;
            this.lbl_studyAbroad_desc.Location = new System.Drawing.Point(206, 155);
            this.lbl_studyAbroad_desc.Name = "lbl_studyAbroad_desc";
            this.lbl_studyAbroad_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_studyAbroad_desc.TabIndex = 1;
            this.lbl_studyAbroad_desc.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_place1_desc);
            this.panel1.Controls.Add(this.ml_place1_name);
            this.panel1.Location = new System.Drawing.Point(69, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 293);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_place2_desc);
            this.panel2.Controls.Add(this.ml_place2_name);
            this.panel2.Location = new System.Drawing.Point(580, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 293);
            this.panel2.TabIndex = 3;
            // 
            // ml_place1_name
            // 
            this.ml_place1_name.AutoSize = true;
            this.ml_place1_name.Depth = 0;
            this.ml_place1_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_place1_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_place1_name.Location = new System.Drawing.Point(124, 27);
            this.ml_place1_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_place1_name.Name = "ml_place1_name";
            this.ml_place1_name.Size = new System.Drawing.Size(84, 27);
            this.ml_place1_name.TabIndex = 0;
            this.ml_place1_name.Text = "Place 1";
            // 
            // ml_place2_name
            // 
            this.ml_place2_name.AutoSize = true;
            this.ml_place2_name.Depth = 0;
            this.ml_place2_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.ml_place2_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ml_place2_name.Location = new System.Drawing.Point(28, 27);
            this.ml_place2_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.ml_place2_name.Name = "ml_place2_name";
            this.ml_place2_name.Size = new System.Drawing.Size(84, 27);
            this.ml_place2_name.TabIndex = 1;
            this.ml_place2_name.Text = "Place 2";
            // 
            // lbl_place1_desc
            // 
            this.lbl_place1_desc.AutoSize = true;
            this.lbl_place1_desc.Location = new System.Drawing.Point(35, 80);
            this.lbl_place1_desc.Name = "lbl_place1_desc";
            this.lbl_place1_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_place1_desc.TabIndex = 1;
            this.lbl_place1_desc.Text = "Description";
            // 
            // lbl_place2_desc
            // 
            this.lbl_place2_desc.AutoSize = true;
            this.lbl_place2_desc.Location = new System.Drawing.Point(23, 80);
            this.lbl_place2_desc.Name = "lbl_place2_desc";
            this.lbl_place2_desc.Size = new System.Drawing.Size(89, 20);
            this.lbl_place2_desc.TabIndex = 2;
            this.lbl_place2_desc.Text = "Description";
            // 
            // StudyAbroadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_studyAbroad_desc);
            this.Controls.Add(this.ml_studyAbroad_title);
            this.Name = "StudyAbroadForm";
            this.Text = "StudyAbroadForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ml_studyAbroad_title;
        private System.Windows.Forms.Label lbl_studyAbroad_desc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_place1_desc;
        private MaterialSkin.Controls.MaterialLabel ml_place1_name;
        private System.Windows.Forms.Label lbl_place2_desc;
        private MaterialSkin.Controls.MaterialLabel ml_place2_name;
    }
}