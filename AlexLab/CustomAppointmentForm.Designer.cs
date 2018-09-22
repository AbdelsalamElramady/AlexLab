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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpRoom = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpClient = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalPrice = new DevExpress.XtraEditors.CalcEdit();
            this.TxtPaidMoney = new DevExpress.XtraEditors.CalcEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.lookUpCourseType = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtStudentBookMoney = new DevExpress.XtraEditors.CalcEdit();
            this.TxtCoursePrice = new DevExpress.XtraEditors.CalcEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.lookUpClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPaidMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCourseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStudentBookMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCoursePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(16, 138);
            this.lblSubject.Size = new System.Drawing.Size(67, 13);
            this.lblSubject.Text = "&Course name:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(16, 341);
            this.lblLocation.Visible = false;
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Location = new System.Drawing.Point(2, 10);
            this.lblLabel.Visible = false;
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
            this.lblShowTimeAs.Location = new System.Drawing.Point(320, 341);
            this.lblShowTimeAs.Visible = false;
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.edtLabel.Location = new System.Drawing.Point(75, 7);
            this.edtLabel.Visible = false;
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Location = new System.Drawing.Point(400, 338);
            this.edtShowTimeAs.Size = new System.Drawing.Size(112, 20);
            this.edtShowTimeAs.Visible = false;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(96, 136);
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.tbSubject, conditionValidationRule1);
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
            this.chkReminder.Visible = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 364);
            this.tbDescription.Size = new System.Drawing.Size(496, 110);
            // 
            // cbReminder
            // 
            this.cbReminder.Visible = false;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(96, 338);
            this.tbLocation.Size = new System.Drawing.Size(83, 20);
            this.tbLocation.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(325, 128);
            this.panel1.Visible = false;
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(192, 330);
            this.progressPanel.Size = new System.Drawing.Size(107, 34);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(0, 31);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(89, 10);
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
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.lookUpRoom, conditionValidationRule2);
            this.lookUpRoom.EditValueChanged += new System.EventHandler(this.edtStartDate_EditValueChanged);
            // 
            // lookUpClient
            // 
            this.lookUpClient.Location = new System.Drawing.Point(96, 43);
            this.lookUpClient.Name = "lookUpClient";
            this.lookUpClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpClient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientName", "Client name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientPhone", "Client phone"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientNationalId", "Client national ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes", "Notes")});
            this.lookUpClient.Properties.DisplayMember = "ClientName";
            this.lookUpClient.Properties.NullText = "";
            this.lookUpClient.Properties.ValueMember = "ClientId";
            this.lookUpClient.Size = new System.Drawing.Size(416, 20);
            this.lookUpClient.TabIndex = 32;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.lookUpClient, conditionValidationRule3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Client name:";
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
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dxValidationProvider1.SetValidationRule(this.TxtTotalPrice, conditionValidationRule4);
            // 
            // TxtPaidMoney
            // 
            this.TxtPaidMoney.Enabled = false;
            this.TxtPaidMoney.Location = new System.Drawing.Point(345, 307);
            this.TxtPaidMoney.Name = "TxtPaidMoney";
            this.TxtPaidMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtPaidMoney.Size = new System.Drawing.Size(167, 20);
            this.TxtPaidMoney.TabIndex = 36;
            this.TxtPaidMoney.ValueChanged += new System.EventHandler(this.TxtPaidMoney_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Course type:";
            // 
            // lookUpCourseType
            // 
            this.lookUpCourseType.Location = new System.Drawing.Point(96, 70);
            this.lookUpCourseType.Name = "lookUpCourseType";
            this.lookUpCourseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCourseType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseTypeDesc", "Course type")});
            this.lookUpCourseType.Properties.DisplayMember = "CourseTypeDesc";
            this.lookUpCourseType.Properties.NullText = "";
            this.lookUpCourseType.Properties.ValueMember = "CourseTypeId";
            this.lookUpCourseType.Size = new System.Drawing.Size(416, 20);
            this.lookUpCourseType.TabIndex = 38;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.lookUpCourseType, conditionValidationRule5);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Student book money:";
            // 
            // TxtStudentBookMoney
            // 
            this.TxtStudentBookMoney.Location = new System.Drawing.Point(128, 227);
            this.TxtStudentBookMoney.Name = "TxtStudentBookMoney";
            this.TxtStudentBookMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtStudentBookMoney.Size = new System.Drawing.Size(184, 20);
            this.TxtStudentBookMoney.TabIndex = 40;
            // 
            // TxtCoursePrice
            // 
            this.TxtCoursePrice.Location = new System.Drawing.Point(128, 253);
            this.TxtCoursePrice.Name = "TxtCoursePrice";
            this.TxtCoursePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCoursePrice.Size = new System.Drawing.Size(184, 20);
            this.TxtCoursePrice.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Student course price:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(345, 278);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(167, 23);
            this.simpleButton1.TabIndex = 43;
            this.simpleButton1.Text = "Pay";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // CustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 517);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TxtCoursePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtStudentBookMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpCourseType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPaidMoney);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lookUpClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpRoom);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(518, 307);
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
            this.Controls.SetChildIndex(this.lookUpClient, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtTotalPrice, 0);
            this.Controls.SetChildIndex(this.TxtPaidMoney, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lookUpCourseType, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtStudentBookMoney, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.TxtCoursePrice, 0);
            this.Controls.SetChildIndex(this.simpleButton1, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.lookUpClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPaidMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCourseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStudentBookMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCoursePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpRoom;
        private DevExpress.XtraEditors.LookUpEdit lookUpClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CalcEdit TxtTotalPrice;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lookUpCourseType;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CalcEdit TxtStudentBookMoney;
        private DevExpress.XtraEditors.CalcEdit TxtCoursePrice;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.CalcEdit TxtPaidMoney;
    }
}
