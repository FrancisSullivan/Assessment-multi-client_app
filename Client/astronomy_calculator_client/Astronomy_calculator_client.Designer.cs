namespace astronomy_calculator_client
{
    partial class Astronomy_calculator_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astronomy_calculator_client));
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderNameOfBody = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKelvin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSchwarzschildRadius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelObservedWavelength = new System.Windows.Forms.Label();
            this.labelNM1 = new System.Windows.Forms.Label();
            this.labelNM2 = new System.Windows.Forms.Label();
            this.labelRestWavelength = new System.Windows.Forms.Label();
            this.textBoxObservedWavelength = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLightOrDark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemColour = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxRestWavelength = new System.Windows.Forms.TextBox();
            this.groupBoxCalculateVelocity = new System.Windows.Forms.GroupBox();
            this.groupBoxCalculateDistance = new System.Windows.Forms.GroupBox();
            this.labelParallaxAngle = new System.Windows.Forms.Label();
            this.labelArcseconds = new System.Windows.Forms.Label();
            this.textBoxParallaxAngle = new System.Windows.Forms.TextBox();
            this.groupBoxConvertToKelvin = new System.Windows.Forms.GroupBox();
            this.labelInitialTemperature = new System.Windows.Forms.Label();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.groupBoxCalculateSchwarzschildRadius = new System.Windows.Forms.GroupBox();
            this.labelMassOfBody = new System.Windows.Forms.Label();
            this.labelExponent = new System.Windows.Forms.Label();
            this.labelKilograms = new System.Windows.Forms.Label();
            this.textBoxMassExponent = new System.Windows.Forms.TextBox();
            this.textBoxMassBase = new System.Windows.Forms.TextBox();
            this.groupBoxNameOfBody = new System.Windows.Forms.GroupBox();
            this.textBoxNameOfBody = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBoxCalculateVelocity.SuspendLayout();
            this.groupBoxCalculateDistance.SuspendLayout();
            this.groupBoxConvertToKelvin.SuspendLayout();
            this.groupBoxCalculateSchwarzschildRadius.SuspendLayout();
            this.groupBoxNameOfBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNameOfBody,
            this.columnHeaderVelocity,
            this.columnHeaderDistance,
            this.columnHeaderKelvin,
            this.columnHeaderSchwarzschildRadius});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            resources.ApplyResources(this.listView, "listView");
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNameOfBody
            // 
            resources.ApplyResources(this.columnHeaderNameOfBody, "columnHeaderNameOfBody");
            // 
            // columnHeaderVelocity
            // 
            resources.ApplyResources(this.columnHeaderVelocity, "columnHeaderVelocity");
            // 
            // columnHeaderDistance
            // 
            resources.ApplyResources(this.columnHeaderDistance, "columnHeaderDistance");
            // 
            // columnHeaderKelvin
            // 
            resources.ApplyResources(this.columnHeaderKelvin, "columnHeaderKelvin");
            // 
            // columnHeaderSchwarzschildRadius
            // 
            resources.ApplyResources(this.columnHeaderSchwarzschildRadius, "columnHeaderSchwarzschildRadius");
            // 
            // labelObservedWavelength
            // 
            resources.ApplyResources(this.labelObservedWavelength, "labelObservedWavelength");
            this.labelObservedWavelength.Name = "labelObservedWavelength";
            // 
            // labelNM1
            // 
            resources.ApplyResources(this.labelNM1, "labelNM1");
            this.labelNM1.Name = "labelNM1";
            // 
            // labelNM2
            // 
            resources.ApplyResources(this.labelNM2, "labelNM2");
            this.labelNM2.Name = "labelNM2";
            // 
            // labelRestWavelength
            // 
            resources.ApplyResources(this.labelRestWavelength, "labelRestWavelength");
            this.labelRestWavelength.Name = "labelRestWavelength";
            // 
            // textBoxObservedWavelength
            // 
            resources.ApplyResources(this.textBoxObservedWavelength, "textBoxObservedWavelength");
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.textBoxObservedWavelength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObservedWavelength_KeyPress);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLanguage,
            this.toolStripMenuItemTheme});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // toolStripMenuItemLanguage
            // 
            this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnglish,
            this.toolStripMenuItemFrench,
            this.toolStripMenuItemGerman});
            resources.ApplyResources(this.toolStripMenuItemLanguage, "toolStripMenuItemLanguage");
            this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
            // 
            // toolStripMenuItemEnglish
            // 
            resources.ApplyResources(this.toolStripMenuItemEnglish, "toolStripMenuItemEnglish");
            this.toolStripMenuItemEnglish.Name = "toolStripMenuItemEnglish";
            this.toolStripMenuItemEnglish.Click += new System.EventHandler(this.toolStripMenuItemEnglish_Click);
            // 
            // toolStripMenuItemFrench
            // 
            resources.ApplyResources(this.toolStripMenuItemFrench, "toolStripMenuItemFrench");
            this.toolStripMenuItemFrench.Name = "toolStripMenuItemFrench";
            this.toolStripMenuItemFrench.Click += new System.EventHandler(this.toolStripMenuItemFrench_Click);
            // 
            // toolStripMenuItemGerman
            // 
            resources.ApplyResources(this.toolStripMenuItemGerman, "toolStripMenuItemGerman");
            this.toolStripMenuItemGerman.Name = "toolStripMenuItemGerman";
            this.toolStripMenuItemGerman.Click += new System.EventHandler(this.toolStripMenuItemGerman_Click);
            // 
            // toolStripMenuItemTheme
            // 
            this.toolStripMenuItemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLightOrDark,
            this.toolStripMenuItemColour});
            this.toolStripMenuItemTheme.Name = "toolStripMenuItemTheme";
            resources.ApplyResources(this.toolStripMenuItemTheme, "toolStripMenuItemTheme");
            // 
            // toolStripMenuItemLightOrDark
            // 
            this.toolStripMenuItemLightOrDark.Name = "toolStripMenuItemLightOrDark";
            resources.ApplyResources(this.toolStripMenuItemLightOrDark, "toolStripMenuItemLightOrDark");
            this.toolStripMenuItemLightOrDark.Click += new System.EventHandler(this.toolStripMenuItemLightOrDark_Click);
            // 
            // toolStripMenuItemColour
            // 
            this.toolStripMenuItemColour.Name = "toolStripMenuItemColour";
            resources.ApplyResources(this.toolStripMenuItemColour, "toolStripMenuItemColour");
            this.toolStripMenuItemColour.Click += new System.EventHandler(this.toolStripMenuItemColour_Click);
            // 
            // textBoxRestWavelength
            // 
            resources.ApplyResources(this.textBoxRestWavelength, "textBoxRestWavelength");
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.textBoxRestWavelength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRestWavelength_KeyPress);
            // 
            // groupBoxCalculateVelocity
            // 
            this.groupBoxCalculateVelocity.Controls.Add(this.labelObservedWavelength);
            this.groupBoxCalculateVelocity.Controls.Add(this.labelNM1);
            this.groupBoxCalculateVelocity.Controls.Add(this.labelNM2);
            this.groupBoxCalculateVelocity.Controls.Add(this.labelRestWavelength);
            this.groupBoxCalculateVelocity.Controls.Add(this.textBoxRestWavelength);
            this.groupBoxCalculateVelocity.Controls.Add(this.textBoxObservedWavelength);
            resources.ApplyResources(this.groupBoxCalculateVelocity, "groupBoxCalculateVelocity");
            this.groupBoxCalculateVelocity.Name = "groupBoxCalculateVelocity";
            this.groupBoxCalculateVelocity.TabStop = false;
            // 
            // groupBoxCalculateDistance
            // 
            this.groupBoxCalculateDistance.Controls.Add(this.labelParallaxAngle);
            this.groupBoxCalculateDistance.Controls.Add(this.labelArcseconds);
            this.groupBoxCalculateDistance.Controls.Add(this.textBoxParallaxAngle);
            resources.ApplyResources(this.groupBoxCalculateDistance, "groupBoxCalculateDistance");
            this.groupBoxCalculateDistance.Name = "groupBoxCalculateDistance";
            this.groupBoxCalculateDistance.TabStop = false;
            // 
            // labelParallaxAngle
            // 
            resources.ApplyResources(this.labelParallaxAngle, "labelParallaxAngle");
            this.labelParallaxAngle.Name = "labelParallaxAngle";
            // 
            // labelArcseconds
            // 
            resources.ApplyResources(this.labelArcseconds, "labelArcseconds");
            this.labelArcseconds.Name = "labelArcseconds";
            // 
            // textBoxParallaxAngle
            // 
            resources.ApplyResources(this.textBoxParallaxAngle, "textBoxParallaxAngle");
            this.textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            this.textBoxParallaxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxParallaxAngle_KeyPress);
            // 
            // groupBoxConvertToKelvin
            // 
            this.groupBoxConvertToKelvin.Controls.Add(this.labelInitialTemperature);
            this.groupBoxConvertToKelvin.Controls.Add(this.labelCelsius);
            this.groupBoxConvertToKelvin.Controls.Add(this.textBoxCelsius);
            resources.ApplyResources(this.groupBoxConvertToKelvin, "groupBoxConvertToKelvin");
            this.groupBoxConvertToKelvin.Name = "groupBoxConvertToKelvin";
            this.groupBoxConvertToKelvin.TabStop = false;
            // 
            // labelInitialTemperature
            // 
            resources.ApplyResources(this.labelInitialTemperature, "labelInitialTemperature");
            this.labelInitialTemperature.Name = "labelInitialTemperature";
            // 
            // labelCelsius
            // 
            resources.ApplyResources(this.labelCelsius, "labelCelsius");
            this.labelCelsius.Name = "labelCelsius";
            // 
            // textBoxCelsius
            // 
            resources.ApplyResources(this.textBoxCelsius, "textBoxCelsius");
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelsius_KeyPress);
            // 
            // groupBoxCalculateSchwarzschildRadius
            // 
            this.groupBoxCalculateSchwarzschildRadius.Controls.Add(this.labelMassOfBody);
            this.groupBoxCalculateSchwarzschildRadius.Controls.Add(this.labelExponent);
            this.groupBoxCalculateSchwarzschildRadius.Controls.Add(this.labelKilograms);
            this.groupBoxCalculateSchwarzschildRadius.Controls.Add(this.textBoxMassExponent);
            this.groupBoxCalculateSchwarzschildRadius.Controls.Add(this.textBoxMassBase);
            resources.ApplyResources(this.groupBoxCalculateSchwarzschildRadius, "groupBoxCalculateSchwarzschildRadius");
            this.groupBoxCalculateSchwarzschildRadius.Name = "groupBoxCalculateSchwarzschildRadius";
            this.groupBoxCalculateSchwarzschildRadius.TabStop = false;
            // 
            // labelMassOfBody
            // 
            resources.ApplyResources(this.labelMassOfBody, "labelMassOfBody");
            this.labelMassOfBody.Name = "labelMassOfBody";
            // 
            // labelExponent
            // 
            resources.ApplyResources(this.labelExponent, "labelExponent");
            this.labelExponent.Name = "labelExponent";
            // 
            // labelKilograms
            // 
            resources.ApplyResources(this.labelKilograms, "labelKilograms");
            this.labelKilograms.Name = "labelKilograms";
            // 
            // textBoxMassExponent
            // 
            resources.ApplyResources(this.textBoxMassExponent, "textBoxMassExponent");
            this.textBoxMassExponent.Name = "textBoxMassExponent";
            this.textBoxMassExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMassExponent_KeyPress);
            // 
            // textBoxMassBase
            // 
            resources.ApplyResources(this.textBoxMassBase, "textBoxMassBase");
            this.textBoxMassBase.Name = "textBoxMassBase";
            this.textBoxMassBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMassBase_KeyPress);
            // 
            // groupBoxNameOfBody
            // 
            this.groupBoxNameOfBody.Controls.Add(this.textBoxNameOfBody);
            resources.ApplyResources(this.groupBoxNameOfBody, "groupBoxNameOfBody");
            this.groupBoxNameOfBody.Name = "groupBoxNameOfBody";
            this.groupBoxNameOfBody.TabStop = false;
            // 
            // textBoxNameOfBody
            // 
            resources.ApplyResources(this.textBoxNameOfBody, "textBoxNameOfBody");
            this.textBoxNameOfBody.Name = "textBoxNameOfBody";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Astronomy_calculator_client
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxNameOfBody);
            this.Controls.Add(this.groupBoxCalculateSchwarzschildRadius);
            this.Controls.Add(this.groupBoxConvertToKelvin);
            this.Controls.Add(this.groupBoxCalculateDistance);
            this.Controls.Add(this.groupBoxCalculateVelocity);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Astronomy_calculator_client";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxCalculateVelocity.ResumeLayout(false);
            this.groupBoxCalculateVelocity.PerformLayout();
            this.groupBoxCalculateDistance.ResumeLayout(false);
            this.groupBoxCalculateDistance.PerformLayout();
            this.groupBoxConvertToKelvin.ResumeLayout(false);
            this.groupBoxConvertToKelvin.PerformLayout();
            this.groupBoxCalculateSchwarzschildRadius.ResumeLayout(false);
            this.groupBoxCalculateSchwarzschildRadius.PerformLayout();
            this.groupBoxNameOfBody.ResumeLayout(false);
            this.groupBoxNameOfBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label labelObservedWavelength;
        private System.Windows.Forms.Label labelNM1;
        private System.Windows.Forms.Label labelNM2;
        private System.Windows.Forms.Label labelRestWavelength;
        private System.Windows.Forms.TextBox textBoxObservedWavelength;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTheme;
        private System.Windows.Forms.TextBox textBoxRestWavelength;
        private System.Windows.Forms.ColumnHeader columnHeaderVelocity;
        private System.Windows.Forms.ColumnHeader columnHeaderDistance;
        private System.Windows.Forms.GroupBox groupBoxCalculateVelocity;
        private System.Windows.Forms.GroupBox groupBoxCalculateDistance;
        private System.Windows.Forms.Label labelParallaxAngle;
        private System.Windows.Forms.Label labelArcseconds;
        private System.Windows.Forms.TextBox textBoxParallaxAngle;
        private System.Windows.Forms.GroupBox groupBoxConvertToKelvin;
        private System.Windows.Forms.Label labelInitialTemperature;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.GroupBox groupBoxCalculateSchwarzschildRadius;
        private System.Windows.Forms.Label labelMassOfBody;
        private System.Windows.Forms.Label labelExponent;
        private System.Windows.Forms.TextBox textBoxMassBase;
        private System.Windows.Forms.Label labelKilograms;
        private System.Windows.Forms.TextBox textBoxMassExponent;
        private System.Windows.Forms.ColumnHeader columnHeaderKelvin;
        private System.Windows.Forms.ColumnHeader columnHeaderSchwarzschildRadius;
        private System.Windows.Forms.GroupBox groupBoxNameOfBody;
        private System.Windows.Forms.TextBox textBoxNameOfBody;
        private System.Windows.Forms.ColumnHeader columnHeaderNameOfBody;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFrench;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGerman;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLightOrDark;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColour;
    }
}

