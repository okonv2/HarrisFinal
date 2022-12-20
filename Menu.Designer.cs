
namespace HarrisFinal
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentbutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentpanelmenu = new System.Windows.Forms.Panel();
            this.newstudentsbutton = new System.Windows.Forms.Button();
            this.managestudentsbutton = new System.Windows.Forms.Button();
            this.statusstudentsbutton = new System.Windows.Forms.Button();
            this.staffpanelmenu = new System.Windows.Forms.Panel();
            this.managestaffbutton = new System.Windows.Forms.Button();
            this.newstaffbutton = new System.Windows.Forms.Button();
            this.statusstaffbutton = new System.Windows.Forms.Button();
            this.staffbutton = new System.Windows.Forms.Button();
            this.classespanelmenu = new System.Windows.Forms.Panel();
            this.classesbutton = new System.Windows.Forms.Button();
            this.materialspanelmenu = new System.Windows.Forms.Panel();
            this.materialsbutton = new System.Windows.Forms.Button();
            this.enrolmentpanelmenu = new System.Windows.Forms.Panel();
            this.enrolmentbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.newclassesbutton = new System.Windows.Forms.Button();
            this.manageclassesbutton = new System.Windows.Forms.Button();
            this.statusclassesbutton = new System.Windows.Forms.Button();
            this.newenrolmentbutton = new System.Windows.Forms.Button();
            this.manageenrolmentbutton = new System.Windows.Forms.Button();
            this.statusenrolmentbutton = new System.Windows.Forms.Button();
            this.newmaterialsbutton = new System.Windows.Forms.Button();
            this.managematerialsbutton = new System.Windows.Forms.Button();
            this.statusmaterialsbutton = new System.Windows.Forms.Button();
            this.studentpanelmenu.SuspendLayout();
            this.staffpanelmenu.SuspendLayout();
            this.classespanelmenu.SuspendLayout();
            this.materialspanelmenu.SuspendLayout();
            this.enrolmentpanelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 52);
            this.panel1.TabIndex = 0;
            // 
            // studentbutton
            // 
            this.studentbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.studentbutton.Location = new System.Drawing.Point(31, 75);
            this.studentbutton.Name = "studentbutton";
            this.studentbutton.Size = new System.Drawing.Size(166, 41);
            this.studentbutton.TabIndex = 1;
            this.studentbutton.Text = "Students";
            this.studentbutton.UseVisualStyleBackColor = false;
            this.studentbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // studentpanelmenu
            // 
            this.studentpanelmenu.Controls.Add(this.newstudentsbutton);
            this.studentpanelmenu.Controls.Add(this.managestudentsbutton);
            this.studentpanelmenu.Controls.Add(this.statusstudentsbutton);
            this.studentpanelmenu.Location = new System.Drawing.Point(31, 116);
            this.studentpanelmenu.Name = "studentpanelmenu";
            this.studentpanelmenu.Size = new System.Drawing.Size(166, 115);
            this.studentpanelmenu.TabIndex = 3;
            // 
            // newstudentsbutton
            // 
            this.newstudentsbutton.Location = new System.Drawing.Point(0, 0);
            this.newstudentsbutton.Name = "newstudentsbutton";
            this.newstudentsbutton.Size = new System.Drawing.Size(166, 27);
            this.newstudentsbutton.TabIndex = 0;
            this.newstudentsbutton.Text = "New";
            this.newstudentsbutton.UseVisualStyleBackColor = true;
            this.newstudentsbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // managestudentsbutton
            // 
            this.managestudentsbutton.Location = new System.Drawing.Point(0, 24);
            this.managestudentsbutton.Name = "managestudentsbutton";
            this.managestudentsbutton.Size = new System.Drawing.Size(166, 27);
            this.managestudentsbutton.TabIndex = 10;
            this.managestudentsbutton.Text = "Manage";
            this.managestudentsbutton.UseVisualStyleBackColor = true;
            this.managestudentsbutton.Click += new System.EventHandler(this.managestudentsbutton_Click);
            // 
            // statusstudentsbutton
            // 
            this.statusstudentsbutton.Location = new System.Drawing.Point(0, 48);
            this.statusstudentsbutton.Name = "statusstudentsbutton";
            this.statusstudentsbutton.Size = new System.Drawing.Size(166, 27);
            this.statusstudentsbutton.TabIndex = 11;
            this.statusstudentsbutton.Text = "Status";
            this.statusstudentsbutton.UseVisualStyleBackColor = true;
            this.statusstudentsbutton.Click += new System.EventHandler(this.statusstudentsbutton_Click);
            // 
            // staffpanelmenu
            // 
            this.staffpanelmenu.Controls.Add(this.managestaffbutton);
            this.staffpanelmenu.Controls.Add(this.newstaffbutton);
            this.staffpanelmenu.Controls.Add(this.statusstaffbutton);
            this.staffpanelmenu.Location = new System.Drawing.Point(294, 116);
            this.staffpanelmenu.Name = "staffpanelmenu";
            this.staffpanelmenu.Size = new System.Drawing.Size(167, 115);
            this.staffpanelmenu.TabIndex = 5;
            // 
            // managestaffbutton
            // 
            this.managestaffbutton.Location = new System.Drawing.Point(0, 24);
            this.managestaffbutton.Name = "managestaffbutton";
            this.managestaffbutton.Size = new System.Drawing.Size(166, 27);
            this.managestaffbutton.TabIndex = 17;
            this.managestaffbutton.Text = "Manage";
            this.managestaffbutton.UseVisualStyleBackColor = true;
            this.managestaffbutton.Click += new System.EventHandler(this.button11_Click);
            // 
            // newstaffbutton
            // 
            this.newstaffbutton.Location = new System.Drawing.Point(0, 0);
            this.newstaffbutton.Name = "newstaffbutton";
            this.newstaffbutton.Size = new System.Drawing.Size(166, 27);
            this.newstaffbutton.TabIndex = 16;
            this.newstaffbutton.Text = "New";
            this.newstaffbutton.UseVisualStyleBackColor = true;
            this.newstaffbutton.Click += new System.EventHandler(this.button10_Click);
            // 
            // statusstaffbutton
            // 
            this.statusstaffbutton.Location = new System.Drawing.Point(0, 48);
            this.statusstaffbutton.Name = "statusstaffbutton";
            this.statusstaffbutton.Size = new System.Drawing.Size(166, 27);
            this.statusstaffbutton.TabIndex = 18;
            this.statusstaffbutton.Text = "Status";
            this.statusstaffbutton.UseVisualStyleBackColor = true;
            this.statusstaffbutton.Click += new System.EventHandler(this.button12_Click);
            // 
            // staffbutton
            // 
            this.staffbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.staffbutton.Location = new System.Drawing.Point(294, 75);
            this.staffbutton.Name = "staffbutton";
            this.staffbutton.Size = new System.Drawing.Size(167, 41);
            this.staffbutton.TabIndex = 4;
            this.staffbutton.Text = "Staff";
            this.staffbutton.UseVisualStyleBackColor = false;
            this.staffbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // classespanelmenu
            // 
            this.classespanelmenu.Controls.Add(this.newclassesbutton);
            this.classespanelmenu.Controls.Add(this.manageclassesbutton);
            this.classespanelmenu.Controls.Add(this.statusclassesbutton);
            this.classespanelmenu.Location = new System.Drawing.Point(544, 116);
            this.classespanelmenu.Name = "classespanelmenu";
            this.classespanelmenu.Size = new System.Drawing.Size(166, 115);
            this.classespanelmenu.TabIndex = 7;
            // 
            // classesbutton
            // 
            this.classesbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.classesbutton.Location = new System.Drawing.Point(544, 75);
            this.classesbutton.Name = "classesbutton";
            this.classesbutton.Size = new System.Drawing.Size(166, 41);
            this.classesbutton.TabIndex = 6;
            this.classesbutton.Text = "Classes";
            this.classesbutton.UseVisualStyleBackColor = false;
            this.classesbutton.Click += new System.EventHandler(this.classesbutton_Click);
            // 
            // materialspanelmenu
            // 
            this.materialspanelmenu.Controls.Add(this.newmaterialsbutton);
            this.materialspanelmenu.Controls.Add(this.managematerialsbutton);
            this.materialspanelmenu.Controls.Add(this.statusmaterialsbutton);
            this.materialspanelmenu.Location = new System.Drawing.Point(434, 316);
            this.materialspanelmenu.Name = "materialspanelmenu";
            this.materialspanelmenu.Size = new System.Drawing.Size(166, 115);
            this.materialspanelmenu.TabIndex = 9;
            // 
            // materialsbutton
            // 
            this.materialsbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialsbutton.Location = new System.Drawing.Point(434, 275);
            this.materialsbutton.Name = "materialsbutton";
            this.materialsbutton.Size = new System.Drawing.Size(166, 41);
            this.materialsbutton.TabIndex = 8;
            this.materialsbutton.Text = "Teaching Materials";
            this.materialsbutton.UseVisualStyleBackColor = false;
            this.materialsbutton.Click += new System.EventHandler(this.materialsbutton_Click);
            // 
            // enrolmentpanelmenu
            // 
            this.enrolmentpanelmenu.Controls.Add(this.newenrolmentbutton);
            this.enrolmentpanelmenu.Controls.Add(this.manageenrolmentbutton);
            this.enrolmentpanelmenu.Controls.Add(this.statusenrolmentbutton);
            this.enrolmentpanelmenu.Location = new System.Drawing.Point(154, 316);
            this.enrolmentpanelmenu.Name = "enrolmentpanelmenu";
            this.enrolmentpanelmenu.Size = new System.Drawing.Size(166, 115);
            this.enrolmentpanelmenu.TabIndex = 9;
            this.enrolmentpanelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // enrolmentbutton
            // 
            this.enrolmentbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.enrolmentbutton.Location = new System.Drawing.Point(154, 275);
            this.enrolmentbutton.Name = "enrolmentbutton";
            this.enrolmentbutton.Size = new System.Drawing.Size(166, 41);
            this.enrolmentbutton.TabIndex = 8;
            this.enrolmentbutton.Text = "Enrolment";
            this.enrolmentbutton.UseVisualStyleBackColor = false;
            this.enrolmentbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 27);
            this.button4.TabIndex = 12;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // newclassesbutton
            // 
            this.newclassesbutton.Location = new System.Drawing.Point(0, 0);
            this.newclassesbutton.Name = "newclassesbutton";
            this.newclassesbutton.Size = new System.Drawing.Size(166, 27);
            this.newclassesbutton.TabIndex = 20;
            this.newclassesbutton.Text = "New";
            this.newclassesbutton.UseVisualStyleBackColor = true;
            this.newclassesbutton.Click += new System.EventHandler(this.newclassesbutton_Click);
            // 
            // manageclassesbutton
            // 
            this.manageclassesbutton.Location = new System.Drawing.Point(0, 24);
            this.manageclassesbutton.Name = "manageclassesbutton";
            this.manageclassesbutton.Size = new System.Drawing.Size(166, 27);
            this.manageclassesbutton.TabIndex = 21;
            this.manageclassesbutton.Text = "Manage";
            this.manageclassesbutton.UseVisualStyleBackColor = true;
            this.manageclassesbutton.Click += new System.EventHandler(this.manageclassesbutton_Click);
            // 
            // statusclassesbutton
            // 
            this.statusclassesbutton.Location = new System.Drawing.Point(0, 48);
            this.statusclassesbutton.Name = "statusclassesbutton";
            this.statusclassesbutton.Size = new System.Drawing.Size(166, 27);
            this.statusclassesbutton.TabIndex = 22;
            this.statusclassesbutton.Text = "Status";
            this.statusclassesbutton.UseVisualStyleBackColor = true;
            this.statusclassesbutton.Click += new System.EventHandler(this.statusclassesbutton_Click);
            // 
            // newenrolmentbutton
            // 
            this.newenrolmentbutton.Location = new System.Drawing.Point(0, 0);
            this.newenrolmentbutton.Name = "newenrolmentbutton";
            this.newenrolmentbutton.Size = new System.Drawing.Size(166, 27);
            this.newenrolmentbutton.TabIndex = 13;
            this.newenrolmentbutton.Text = "New";
            this.newenrolmentbutton.UseVisualStyleBackColor = true;
            this.newenrolmentbutton.Click += new System.EventHandler(this.newenrolmentbutton_Click);
            // 
            // manageenrolmentbutton
            // 
            this.manageenrolmentbutton.Location = new System.Drawing.Point(0, 24);
            this.manageenrolmentbutton.Name = "manageenrolmentbutton";
            this.manageenrolmentbutton.Size = new System.Drawing.Size(166, 27);
            this.manageenrolmentbutton.TabIndex = 14;
            this.manageenrolmentbutton.Text = "Manage";
            this.manageenrolmentbutton.UseVisualStyleBackColor = true;
            this.manageenrolmentbutton.Click += new System.EventHandler(this.manageenrolmentbutton_Click);
            // 
            // statusenrolmentbutton
            // 
            this.statusenrolmentbutton.Location = new System.Drawing.Point(0, 48);
            this.statusenrolmentbutton.Name = "statusenrolmentbutton";
            this.statusenrolmentbutton.Size = new System.Drawing.Size(166, 27);
            this.statusenrolmentbutton.TabIndex = 15;
            this.statusenrolmentbutton.Text = "Status";
            this.statusenrolmentbutton.UseVisualStyleBackColor = true;
            this.statusenrolmentbutton.Click += new System.EventHandler(this.statusenrolmentbutton_Click);
            // 
            // newmaterialsbutton
            // 
            this.newmaterialsbutton.Location = new System.Drawing.Point(0, 0);
            this.newmaterialsbutton.Name = "newmaterialsbutton";
            this.newmaterialsbutton.Size = new System.Drawing.Size(166, 27);
            this.newmaterialsbutton.TabIndex = 13;
            this.newmaterialsbutton.Text = "New";
            this.newmaterialsbutton.UseVisualStyleBackColor = true;
            this.newmaterialsbutton.Click += new System.EventHandler(this.newmaterialsbutton_Click);
            // 
            // managematerialsbutton
            // 
            this.managematerialsbutton.Location = new System.Drawing.Point(0, 24);
            this.managematerialsbutton.Name = "managematerialsbutton";
            this.managematerialsbutton.Size = new System.Drawing.Size(166, 27);
            this.managematerialsbutton.TabIndex = 14;
            this.managematerialsbutton.Text = "Manage";
            this.managematerialsbutton.UseVisualStyleBackColor = true;
            this.managematerialsbutton.Click += new System.EventHandler(this.managematerialsbutton_Click);
            // 
            // statusmaterialsbutton
            // 
            this.statusmaterialsbutton.Location = new System.Drawing.Point(0, 48);
            this.statusmaterialsbutton.Name = "statusmaterialsbutton";
            this.statusmaterialsbutton.Size = new System.Drawing.Size(166, 27);
            this.statusmaterialsbutton.TabIndex = 15;
            this.statusmaterialsbutton.Text = "Status";
            this.statusmaterialsbutton.UseVisualStyleBackColor = true;
            this.statusmaterialsbutton.Click += new System.EventHandler(this.statusmaterialsbutton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.enrolmentpanelmenu);
            this.Controls.Add(this.enrolmentbutton);
            this.Controls.Add(this.materialspanelmenu);
            this.Controls.Add(this.materialsbutton);
            this.Controls.Add(this.classespanelmenu);
            this.Controls.Add(this.classesbutton);
            this.Controls.Add(this.staffpanelmenu);
            this.Controls.Add(this.staffbutton);
            this.Controls.Add(this.studentpanelmenu);
            this.Controls.Add(this.studentbutton);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.studentpanelmenu.ResumeLayout(false);
            this.staffpanelmenu.ResumeLayout(false);
            this.classespanelmenu.ResumeLayout(false);
            this.materialspanelmenu.ResumeLayout(false);
            this.enrolmentpanelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button studentbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel studentpanelmenu;
        private System.Windows.Forms.Panel staffpanelmenu;
        private System.Windows.Forms.Button staffbutton;
        private System.Windows.Forms.Panel classespanelmenu;
        private System.Windows.Forms.Button classesbutton;
        private System.Windows.Forms.Panel materialspanelmenu;
        private System.Windows.Forms.Button materialsbutton;
        private System.Windows.Forms.Panel enrolmentpanelmenu;
        private System.Windows.Forms.Button enrolmentbutton;
        private System.Windows.Forms.Button newstudentsbutton;
        private System.Windows.Forms.Button managestudentsbutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button statusstudentsbutton;
        private System.Windows.Forms.Button managestaffbutton;
        private System.Windows.Forms.Button newstaffbutton;
        private System.Windows.Forms.Button statusstaffbutton;
        private System.Windows.Forms.Button newclassesbutton;
        private System.Windows.Forms.Button manageclassesbutton;
        private System.Windows.Forms.Button statusclassesbutton;
        private System.Windows.Forms.Button newmaterialsbutton;
        private System.Windows.Forms.Button managematerialsbutton;
        private System.Windows.Forms.Button statusmaterialsbutton;
        private System.Windows.Forms.Button newenrolmentbutton;
        private System.Windows.Forms.Button manageenrolmentbutton;
        private System.Windows.Forms.Button statusenrolmentbutton;
    }
}

