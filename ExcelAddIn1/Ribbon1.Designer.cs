namespace ExcelAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.opcoes = this.Factory.CreateRibbonGroup();
            this.BtnFormPedido = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.opcoes);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // opcoes
            // 
            this.opcoes.DialogLauncher = ribbonDialogLauncherImpl1;
            this.opcoes.Items.Add(this.BtnFormPedido);
            this.opcoes.Label = "Opções";
            this.opcoes.Name = "opcoes";
            // 
            // BtnFormPedido
            // 
            this.BtnFormPedido.ImageName = "iBtnFormPedido";
            this.BtnFormPedido.Label = "Pedido";
            this.BtnFormPedido.Name = "BtnFormPedido";
            this.BtnFormPedido.OfficeImageId = "DataFormExcel";
            this.BtnFormPedido.ShowImage = true;
            this.BtnFormPedido.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnFormPedido_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Click);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.opcoes.ResumeLayout(false);
            this.opcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup opcoes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnFormPedido;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
