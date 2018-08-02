namespace AlexLab
{
    partial class CustomAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpRoom = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpCourse = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalPrice = new DevExpress.XtraEditors.CalcEdit();
            this.TxtPaidMoney = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPaidMoney.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(16, 107);
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(16, 133);
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(16, 170);
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(16, 195);
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(16, 232);
            // 
            // chkAllDay
            // 
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 483);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 483);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 483);
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(280, 483);
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(96, 167);
            this.edtStartDate.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(96, 192);
            this.edtEndDate.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(224, 168);
            this.edtStartTime.Properties.Mask.EditMask = "t";
            this.edtStartTime.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(224, 192);
            this.edtEndTime.Properties.Mask.EditMask = "t";
            this.edtEndTime.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // edtLabel
            // 
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Location = new System.Drawing.Point(96, 229);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(96, 105);
            // 
            // edtResource
            // 
            // 
            // edtResources
            // 
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            // 
            // chkReminder
            // 
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 364);
            this.tbDescription.Size = new System.Drawing.Size(496, 110);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(96, 130);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(325, 130);
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(16, 255);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Room:";
            // 
            // lookUpRoom
            // 
            this.lookUpRoom.Location = new System.Drawing.Point(96, 18);
            this.lookUpRoom.Name = "lookUpRoom";
            this.lookUpRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRoom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoomDesc", "Room name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HourPrice", "Hour price"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes", "Notes"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoomId", "RoomId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpRoom.Properties.DisplayMember = "RoomDesc";
            this.lookUpRoom.Properties.NullText = "";
            this.lookUpRoom.Properties.ValueMember = "RoomId";
            this.lookUpRoom.Size = new System.Drawing.Size(416, 20);
            this.lookUpRoom.TabIndex = 30;
            this.lookUpRoom.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // lookUpCourse
            // 
            this.lookUpCourse.Location = new System.Drawing.Point(96, 54);
            this.lookUpCourse.Name = "lookUpCourse";
            this.lookUpCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCourse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Course name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseTypeDesc", "Course type "),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientName", "Client name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseId", "CourseId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StudentBookMoney", "Student book money"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes", "Notes")});
            this.lookUpCourse.Properties.DisplayMember = "CourseName";
            this.lookUpCourse.Properties.NullText = "";
            this.lookUpCourse.Properties.ValueMember = "CourseId";
            this.lookUpCourse.Size = new System.Drawing.Size(416, 20);
            this.lookUpCourse.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Course name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Paid money:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Total price:";
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Location = new System.Drawing.Point(96, 304);
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTotalPrice.Size = new System.Drawing.Size(162, 20);
            this.TxtTotalPrice.TabIndex = 35;
            // 
            // TxtPaidMoney
            // 
            this.TxtPaidMoney.Location = new System.Drawing.Point(345, 307);
            this.TxtPaidMoney.Name = "TxtPaidMoney";
            this.TxtPaidMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtPaidMoney.Size = new System.Drawing.Size(167, 20);
            this.TxtPaidMoney.TabIndex = 36;
            // 
            // CustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 517);
            this.Controls.Add(this.TxtPaidMoney);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lookUpCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpRoom);
            this.Controls.Add(this.label1);
            this.Name = "CustomAppointmentForm";
            this.Load += new System.EventHandler(this.CustomAppointmentForm_Load);
            this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
            this.Controls.SetChildIndex(this.edtEndTime, 0);
            this.Controls.SetChildIndex(this.edtEndDate, 0);
            this.Controls.SetChildIndex(this.btnRecurrence, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
            this.Controls.SetChildIndex(this.lblEndTime, 0);
            this.Controls.SetChildIndex(this.tbLocation, 0);
            this.Controls.SetChildIndex(this.lblSubject, 0);
            this.Controls.SetChildIndex(this.lblLocation, 0);
            this.Controls.SetChildIndex(this.tbSubject, 0);
            this.Controls.SetChildIndex(this.lblStartTime, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.edtStartDate, 0);
            this.Controls.SetChildIndex(this.edtStartTime, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.progressPanel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lookUpRoom, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lookUpCourse, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtTotalPrice, 0);
            this.Controls.SetChildIndex(this.TxtPaidMoney, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPaidMoney.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpRoom;
        private DevExpress.XtraEditors.LookUpEdit lookUpCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CalcEdit TxtTotalPrice;
        private DevExpress.XtraEditors.CalcEdit TxtPaidMoney;
    }
}
