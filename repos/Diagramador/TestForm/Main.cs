using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Dalssoft.DiagramNet;

namespace Dalssoft.TestForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private bool changeDocumentProp = true;

		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton btnAdd;
		private System.Windows.Forms.ToolBarButton btnDelete;
		private System.Windows.Forms.ToolBarButton btnConnect;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.ToolBarButton sep1;
		private System.Windows.Forms.ToolBarButton btnSave;
		private System.Windows.Forms.ToolBarButton btnOpen;
		private System.Windows.Forms.ToolBarButton sep2;
		private System.Windows.Forms.ToolBarButton btnUndo;
		private System.Windows.Forms.ToolBarButton btnRedo;
		private System.Windows.Forms.ToolBarButton sep3;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem mnuSave;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuTbRectangle;
		private System.Windows.Forms.MenuItem mnuTbElipse;
		private System.Windows.Forms.MenuItem mnuTbRectangleNode;
		private System.Windows.Forms.MenuItem mnuTbElipseNode;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ContextMenu contextMenu2;
		private System.Windows.Forms.MenuItem mnuTbStraightLink;
		private System.Windows.Forms.MenuItem mnuTbRightAngleLink;
		private System.Windows.Forms.ToolBarButton sep4;
		private System.Windows.Forms.ContextMenu contextMenu_Zoom;
		private System.Windows.Forms.MenuItem mnuZoom_10;
		private System.Windows.Forms.MenuItem mnuZoom_25;
		private System.Windows.Forms.MenuItem mnuZoom_50;
		private System.Windows.Forms.MenuItem mnuZoom_75;
		private System.Windows.Forms.MenuItem mnuZoom_100;
		private System.Windows.Forms.MenuItem mnuZoom_150;
		private System.Windows.Forms.MenuItem mnuZoom_200;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.TextBox txtLog;
		private Dalssoft.DiagramNet.Designer designer1;
		private System.Windows.Forms.MenuItem TbCommentBox;
        private MenuItem menuSaveas;
        private MenuItem TbCommentBoxNode;
        private System.ComponentModel.IContainer components;

		public Form1()
		{

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.btnOpen = new System.Windows.Forms.ToolBarButton();
            this.btnSave = new System.Windows.Forms.ToolBarButton();
            this.sep1 = new System.Windows.Forms.ToolBarButton();
            this.btnDelete = new System.Windows.Forms.ToolBarButton();
            this.sep4 = new System.Windows.Forms.ToolBarButton();
            this.btnAdd = new System.Windows.Forms.ToolBarButton();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuTbRectangle = new System.Windows.Forms.MenuItem();
            this.mnuTbElipse = new System.Windows.Forms.MenuItem();
            this.mnuTbRectangleNode = new System.Windows.Forms.MenuItem();
            this.mnuTbElipseNode = new System.Windows.Forms.MenuItem();
            this.TbCommentBox = new System.Windows.Forms.MenuItem();
            this.TbCommentBoxNode = new System.Windows.Forms.MenuItem();
            this.btnConnect = new System.Windows.Forms.ToolBarButton();
            this.contextMenu2 = new System.Windows.Forms.ContextMenu();
            this.mnuTbStraightLink = new System.Windows.Forms.MenuItem();
            this.mnuTbRightAngleLink = new System.Windows.Forms.MenuItem();
            this.sep2 = new System.Windows.Forms.ToolBarButton();
            this.btnUndo = new System.Windows.Forms.ToolBarButton();
            this.btnRedo = new System.Windows.Forms.ToolBarButton();
            this.sep3 = new System.Windows.Forms.ToolBarButton();
            this.contextMenu_Zoom = new System.Windows.Forms.ContextMenu();
            this.mnuZoom_10 = new System.Windows.Forms.MenuItem();
            this.mnuZoom_25 = new System.Windows.Forms.MenuItem();
            this.mnuZoom_50 = new System.Windows.Forms.MenuItem();
            this.mnuZoom_75 = new System.Windows.Forms.MenuItem();
            this.mnuZoom_100 = new System.Windows.Forms.MenuItem();
            this.mnuZoom_150 = new System.Windows.Forms.MenuItem();
            this.mnuZoom_200 = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.menuSaveas = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.designer1 = new Dalssoft.DiagramNet.Designer();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.AllowDrop = true;
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.btnOpen,
            this.btnSave,
            this.sep1,
            this.btnDelete,
            this.sep4,
            this.btnAdd,
            this.btnConnect,
            this.sep2,
            this.btnUndo,
            this.btnRedo,
            this.sep3});
            this.toolBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolBar1.Divider = false;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(696, 26);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.Wrappable = false;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // btnOpen
            // 
            this.btnOpen.ImageIndex = 6;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Tag = "Open";
            this.btnOpen.ToolTipText = "Abrir";
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 5;
            this.btnSave.Name = "btnSave";
            this.btnSave.Tag = "Save";
            this.btnSave.ToolTipText = "Guardar";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.btnDelete.Tag = "Delete";
            this.btnDelete.ToolTipText = "Borrar";
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnAdd
            // 
            this.btnAdd.DropDownMenu = this.contextMenu1;
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.btnAdd.Tag = "Add";
            this.btnAdd.ToolTipText = "Agregar";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuTbRectangle,
            this.mnuTbElipse,
            this.mnuTbRectangleNode,
            this.mnuTbElipseNode,
            this.TbCommentBox,
            this.TbCommentBoxNode});
            // 
            // mnuTbRectangle
            // 
            this.mnuTbRectangle.Index = 0;
            this.mnuTbRectangle.Text = "&Rectangle";
            this.mnuTbRectangle.Click += new System.EventHandler(this.mnuTbRectangle_Click);
            // 
            // mnuTbElipse
            // 
            this.mnuTbElipse.Index = 1;
            this.mnuTbElipse.Text = "&Elipse";
            this.mnuTbElipse.Click += new System.EventHandler(this.mnuTbElipse_Click);
            // 
            // mnuTbRectangleNode
            // 
            this.mnuTbRectangleNode.Index = 2;
            this.mnuTbRectangleNode.Text = "&Node Rectangle";
            this.mnuTbRectangleNode.Click += new System.EventHandler(this.mnuTbRectangleNode_Click);
            // 
            // mnuTbElipseNode
            // 
            this.mnuTbElipseNode.Index = 3;
            this.mnuTbElipseNode.Text = "N&ode Elipse";
            this.mnuTbElipseNode.Click += new System.EventHandler(this.mnuTbElipseNode_Click);
            // 
            // TbCommentBox
            // 
            this.TbCommentBox.Index = 4;
            this.TbCommentBox.Text = "Comment Box";
            this.TbCommentBox.Click += new System.EventHandler(this.TbCommentBox_Click);
            // 
            // TbCommentBoxNode
            // 
            this.TbCommentBoxNode.Index = 5;
            this.TbCommentBoxNode.Text = "Comment Box Node";
            this.TbCommentBoxNode.Click += new System.EventHandler(this.TbCommentBoxNode_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.DropDownMenu = this.contextMenu2;
            this.btnConnect.ImageIndex = 3;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.btnConnect.Tag = "Connect";
            this.btnConnect.ToolTipText = "Relacion";
            // 
            // contextMenu2
            // 
            this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuTbStraightLink,
            this.mnuTbRightAngleLink});
            // 
            // mnuTbStraightLink
            // 
            this.mnuTbStraightLink.Index = 0;
            this.mnuTbStraightLink.Text = "Straight Link";
            this.mnuTbStraightLink.Click += new System.EventHandler(this.mnuTbStraightLink_Click);
            // 
            // mnuTbRightAngleLink
            // 
            this.mnuTbRightAngleLink.Index = 1;
            this.mnuTbRightAngleLink.Text = "Right Angle Link";
            this.mnuTbRightAngleLink.Click += new System.EventHandler(this.mnuTbRightAngleLink_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // btnUndo
            // 
            this.btnUndo.ImageIndex = 7;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Tag = "Undo";
            this.btnUndo.ToolTipText = "Deshacer";
            // 
            // btnRedo
            // 
            this.btnRedo.ImageIndex = 8;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Tag = "Redo";
            this.btnRedo.ToolTipText = "Rehacer";
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // contextMenu_Zoom
            // 
            this.contextMenu_Zoom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuZoom_10,
            this.mnuZoom_25,
            this.mnuZoom_50,
            this.mnuZoom_75,
            this.mnuZoom_100,
            this.mnuZoom_150,
            this.mnuZoom_200});
            // 
            // mnuZoom_10
            // 
            this.mnuZoom_10.Index = 0;
            this.mnuZoom_10.Text = "10%";
            this.mnuZoom_10.Click += new System.EventHandler(this.mnuZoom_10_Click);
            // 
            // mnuZoom_25
            // 
            this.mnuZoom_25.Index = 1;
            this.mnuZoom_25.Text = "25%";
            this.mnuZoom_25.Click += new System.EventHandler(this.mnuZoom_25_Click);
            // 
            // mnuZoom_50
            // 
            this.mnuZoom_50.Index = 2;
            this.mnuZoom_50.Text = "50%";
            this.mnuZoom_50.Click += new System.EventHandler(this.mnuZoom_50_Click);
            // 
            // mnuZoom_75
            // 
            this.mnuZoom_75.Index = 3;
            this.mnuZoom_75.Text = "75%";
            this.mnuZoom_75.Click += new System.EventHandler(this.mnuZoom_75_Click);
            // 
            // mnuZoom_100
            // 
            this.mnuZoom_100.Index = 4;
            this.mnuZoom_100.Text = "100%";
            this.mnuZoom_100.Click += new System.EventHandler(this.mnuZoom_100_Click);
            // 
            // mnuZoom_150
            // 
            this.mnuZoom_150.Index = 5;
            this.mnuZoom_150.Text = "150%";
            this.mnuZoom_150.Click += new System.EventHandler(this.mnuZoom_150_Click);
            // 
            // mnuZoom_200
            // 
            this.mnuZoom_200.Index = 6;
            this.mnuZoom_200.Text = "200%";
            this.mnuZoom_200.Click += new System.EventHandler(this.mnuZoom_200_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Silver;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.menuSaveas,
            this.menuItem26,
            this.mnuExit});
            this.mnuFile.Text = "&Archivo";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Text = "&Abrir";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 1;
            this.mnuSave.Text = "&Guardar";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // menuSaveas
            // 
            this.menuSaveas.Index = 2;
            this.menuSaveas.Text = "Guardar &como";
            this.menuSaveas.Click += new System.EventHandler(this.menuSaveas_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 3;
            this.menuItem26.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 4;
            this.mnuExit.Text = "&Salir";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.designer1);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 359);
            this.panel1.TabIndex = 2;
            // 
            // designer1
            // 
            this.designer1.AutoScroll = true;
            this.designer1.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.designer1.BackColor = System.Drawing.SystemColors.Window;
            this.designer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designer1.Location = new System.Drawing.Point(0, 0);
            this.designer1.Name = "designer1";
            this.designer1.Size = new System.Drawing.Size(692, 251);
            this.designer1.TabIndex = 6;
            this.designer1.ElementClick += new Dalssoft.DiagramNet.Designer.ElementEventHandler(this.designer1_ElementClick);
            this.designer1.ElementMouseDown += new Dalssoft.DiagramNet.Designer.ElementMouseEventHandler(this.designer1_ElementMouseDown);
            this.designer1.ElementMouseUp += new Dalssoft.DiagramNet.Designer.ElementMouseEventHandler(this.designer1_ElementMouseUp);
            this.designer1.ElementMoving += new Dalssoft.DiagramNet.Designer.ElementEventHandler(this.designer1_ElementMoving);
            this.designer1.ElementMoved += new Dalssoft.DiagramNet.Designer.ElementEventHandler(this.designer1_ElementMoved);
            this.designer1.ElementResizing += new Dalssoft.DiagramNet.Designer.ElementEventHandler(this.designer1_ElementResizing);
            this.designer1.ElementResized += new Dalssoft.DiagramNet.Designer.ElementEventHandler(this.designer1_ElementResized);
            this.designer1.ElementConnecting += new Dalssoft.DiagramNet.Designer.ElementConnectEventHandler(this.designer1_ElementConnecting);
            this.designer1.ElementConnected += new Dalssoft.DiagramNet.Designer.ElementConnectEventHandler(this.designer1_ElementConnected);
            this.designer1.ElementSelection += new Dalssoft.DiagramNet.Designer.ElementSelectionEventHandler(this.designer1_ElementSelection);
            this.designer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.designer1_MouseUp);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 251);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(692, 4);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 255);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(692, 104);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "Log:";
            this.txtLog.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(692, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 359);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.dgn";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(696, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Diagramador v.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();

			Application.Run(new Form1());
		}

		#region Functions
		private void Edit_UpdateUndoRedoEnable()
		{
			
			btnUndo.Enabled = designer1.CanUndo;

			btnRedo.Enabled = designer1.CanRedo;
		}

		private void Edit_Undo()
		{
			if (designer1.CanUndo)
				designer1.Undo();
			
			Edit_UpdateUndoRedoEnable();
		}

		private void Edit_Redo()
		{
			if (designer1.CanRedo)
				designer1.Redo();

			Edit_UpdateUndoRedoEnable();
		}

		private void Action_None()
		{
		

			
			btnAdd.Pushed = false;
			btnDelete.Pushed = false;
			btnConnect.Pushed = false;

		
			mnuTbRectangle.Checked = false;
	
			mnuTbElipse.Checked = false;
	
			mnuTbRectangleNode.Checked = false;
		
			mnuTbElipseNode.Checked = false;

            
		}

		private void Action_Size()
		{
			//Action_None();
		
			//btnSize.Pushed = true;
			//if (changeDocumentProp)
			//	designer1.Document.Action = DesignerAction.Select;
		}

		private void Action_Add(ElementType e)
		{
			Action_None();
			btnAdd.Pushed = true;
			switch(e)
			{
				case ElementType.Rectangle:
					
					mnuTbRectangle.Checked = true;
					break;
				case ElementType.Elipse:
				
					mnuTbElipse.Checked = true;
					break;
				case ElementType.RectangleNode:
				
					mnuTbRectangleNode.Checked = true;
					break;
				case ElementType.ElipseNode:
				
					mnuTbElipseNode.Checked = true;
					break;

            }
			
			if (changeDocumentProp)
			{
				designer1.Document.Action = DesignerAction.Add;
				designer1.Document.ElementType = e;
			}
		}

		private void Action_Delete()
		{
			Action_None();
		
			btnDelete.Pushed = true;
			if (changeDocumentProp)
				designer1.Document.DeleteSelectedElements();
			Action_None();
		}

		private void Action_Connect()
		{
			Action_None();
		
			btnConnect.Pushed = true;
			if (changeDocumentProp)
				designer1.Document.Action = DesignerAction.Connect;
		}

		private void Action_Connector(LinkType lt)
		{
			Action_None();
			switch(lt)
			{
				case LinkType.Straight:
					mnuTbStraightLink.Checked = true;
					mnuTbRightAngleLink.Checked = false;
					break;
				case LinkType.RightAngle:
					mnuTbStraightLink.Checked = false;
					mnuTbRightAngleLink.Checked = true;
					break;
			}
			designer1.Document.LinkType = lt;
			Action_Connect();
		}

		private void Action_Zoom(float zoom)
		{
			designer1.Document.Zoom = zoom;
		}
        public string  FileName { get; set; }
        private void File_Open()
		{
            openFileDialog1.FileName = FileName;
            openFileDialog1.Filter = "全部dgn文件(*.dgn)|*.dgn|全部文件(*.*)|*.*";
            openFileDialog1.DefaultExt = ".dgn";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
                FileName = openFileDialog1.FileName;

                designer1.Open(openFileDialog1.FileName);
			}
		}

		private void File_Save()
		{
            if (File.Exists(FileName))
            {
                designer1.Save(FileName);
                Bitmap bmp = new Bitmap(designer1.Width, designer1.Height);
                designer1.DrawToBitmap(bmp, new Rectangle(0, 0, designer1.Width, designer1.Height));
                bmp.Save(FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                File_SaveAs();
            }
		}
        private void File_SaveAs()
        {
            saveFileDialog1.FileName = FileName;
            saveFileDialog1.Filter = "全部dgn文件(*.dgn)|*.dgn|全部文件(*.*)|*.*";
            saveFileDialog1.DefaultExt = ".dgn";
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                designer1.Save(saveFileDialog1.FileName);
                Bitmap bmp = new Bitmap(designer1.Width, designer1.Height);
                designer1.DrawToBitmap(bmp, new Rectangle(0, 0, designer1.Width, designer1.Height));
                bmp.Save(saveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Order_BringToFront()
		{
			if (designer1.Document.SelectedElements.Count == 1)
			{
				designer1.Document.BringToFrontElement(designer1.Document.SelectedElements[0]);
				designer1.Refresh();
			}
		}

		private void Order_SendToBack()
		{
			if (designer1.Document.SelectedElements.Count == 1)
			{
				designer1.Document.SendToBackElement(designer1.Document.SelectedElements[0]);
				designer1.Refresh();
			}
		}

		private void Order_MoveUp()
		{
			if (designer1.Document.SelectedElements.Count == 1)
			{
				designer1.Document.MoveUpElement(designer1.Document.SelectedElements[0]);
				designer1.Refresh();
			}	
		}

		private void Order_MoveDown()
		{
			if (designer1.Document.SelectedElements.Count == 1)
			{
				designer1.Document.MoveDownElement(designer1.Document.SelectedElements[0]);
				designer1.Refresh();
			}	
		}

		private void Clipboard_Cut()
		{
			designer1.Cut();
		}

		private void Clipboard_Copy()
		{
			designer1.Copy();
		}

		private void Clipboard_Paste()
		{
			designer1.Paste();
		}

		#endregion

		#region Menu Events
		private void mnuUndo_Click(object sender, System.EventArgs e)
		{
			Edit_Undo();
		}

		private void mnuRedo_Click(object sender, System.EventArgs e)
		{
			Edit_Redo();
		}

		private void mnuSize_Click(object sender, System.EventArgs e)
		{
			Action_Size();		
		}

		private void mnuRectangle_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.Rectangle);
		}

		private void mnuElipse_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.Elipse);
		}

		private void mnuRectangleNode_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.RectangleNode);
		}

		private void mnuElipseNode_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.ElipseNode);
		}

		private void mnuDelete_Click(object sender, System.EventArgs e)
		{
			Action_Delete();
		}

		private void mnuCut_Click(object sender, System.EventArgs e)
		{
			Clipboard_Cut();
		}

		private void mnuCopy_Click(object sender, System.EventArgs e)
		{
			Clipboard_Copy();
		}

		private void mnuPaste_Click(object sender, System.EventArgs e)
		{
			Clipboard_Paste();
		}

		private void mnuConnect_Click(object sender, System.EventArgs e)
		{
			Action_Connect();
		}

		private void mnuBringToFront_Click(object sender, System.EventArgs e)
		{
			Order_BringToFront();
		}

		private void mnuSendToBack_Click(object sender, System.EventArgs e)
		{
			Order_SendToBack();
		}

		private void mnuMoveUp_Click(object sender, System.EventArgs e)
		{
			Order_MoveUp();
		}

		private void mnuMoveDown_Click(object sender, System.EventArgs e)
		{
			Order_MoveDown();
		}

		private void mnuOpen_Click(object sender, System.EventArgs e)
		{
			File_Open();
		}

		private void mnuSave_Click(object sender, System.EventArgs e)
		{
			File_Save();		
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			About about = new About();
			about.ShowDialog(this);
		}
		#endregion

		#region Toolbar Events
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			
			string btn = (string) e.Button.Tag;
			
			if (btn == "Open") File_Open();
			if (btn == "Save") File_Save();
			
			if (btn == "Size") Action_Size();
			//if (btn == "Add")
			if (btn == "Delete") Action_Delete();
			if (btn == "Connect") Action_Connect();

			if (btn == "Undo") Edit_Undo();
			if (btn == "Redo") Edit_Redo();

			if (btn == "Front") Order_BringToFront();
			if (btn == "Back") Order_SendToBack();
			if (btn == "MoveUp") Order_MoveUp();
			if (btn == "MoveDown") Order_MoveDown();

			if (btn == "Cut") Clipboard_Cut();
			if (btn == "Copy") Clipboard_Copy();
			if (btn == "Paste") Clipboard_Paste();
		}

		private void mnuTbRectangle_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.Rectangle);
		}

		private void mnuTbElipse_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.Elipse);
		}

		private void mnuTbRectangleNode_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.RectangleNode);
		}

		private void mnuTbElipseNode_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.ElipseNode);
		}

		private void TbCommentBox_Click(object sender, System.EventArgs e)
		{
			Action_Add(ElementType.CommentBox);
		}

		private void mnuTbStraightLink_Click(object sender, System.EventArgs e)
		{
			Action_Connector(LinkType.Straight);
		}

		private void mnuTbRightAngleLink_Click(object sender, System.EventArgs e)
		{
			Action_Connector(LinkType.RightAngle);
		}

		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Edit_UpdateUndoRedoEnable();
			
			//Events
			designer1.Document.PropertyChanged+=new EventHandler(Document_PropertyChanged);
		}

		private void Document_PropertyChanged(object sender, EventArgs e)
		{
			changeDocumentProp = false;

			Action_None();

			switch(designer1.Document.Action)
			{
				case DesignerAction.Select:
					Action_Size();
					break;
				case DesignerAction.Delete:
					Action_Delete();
					break;
				case DesignerAction.Connect:
					Action_Connect();
					break;
				case DesignerAction.Add:
					Action_Add(designer1.Document.ElementType);
					break;
			}

			Edit_UpdateUndoRedoEnable();

			changeDocumentProp = true;
		}

		private void mnuZoom_10_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(0.1f);
		}

		private void mnuZoom_25_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(0.25f);
		}

		private void mnuZoom_50_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(0.5f);
		}

		private void mnuZoom_75_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(0.75f);
		}

		private void mnuZoom_100_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(1f);
		}

		private void mnuZoom_150_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(1.5f);
		}

		private void mnuZoom_200_Click(object sender, System.EventArgs e)
		{
			Action_Zoom(2.0f);
		}

		private void mnuShowDebugLog_Click(object sender, System.EventArgs e)
		{
			//mnuShowDebugLog.Checked = !mnuShowDebugLog.Checked;
			//txtLog.Visible = mnuShowDebugLog.Checked;

		}

		#region Events Handling 
		private void designer1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			AppendLog("designer1_MouseUp: {0}", e.ToString());

			//propertyGrid1.SelectedObject = null;

			//if (designer1.Document.SelectedElements.Count == 1)
			//{
			//	propertyGrid1.SelectedObject = designer1.Document.SelectedElements[0];
			//}
			//else if (designer1.Document.SelectedElements.Count > 1)
			//{
			//	propertyGrid1.SelectedObjects = designer1.Document.SelectedElements.GetArray();
			//}
			//else if (designer1.Document.SelectedElements.Count == 0)
			//{
			//	propertyGrid1.SelectedObject = designer1.Document;
			//}
		}

		private void designer1_ElementClick(object sender, Dalssoft.DiagramNet.ElementEventArgs e)
		{
			AppendLog("designer1_ElementClick: {0}", e.ToString());
		}

		private void designer1_ElementMouseDown(object sender, Dalssoft.DiagramNet.ElementMouseEventArgs e)
		{
			AppendLog("designer1_ElementMouseDown: {0}", e.ToString());
		}

		private void designer1_ElementMouseUp(object sender, Dalssoft.DiagramNet.ElementMouseEventArgs e)
		{
			AppendLog("designer1_ElementMouseUp: {0}", e.ToString());
		}
		
		private void designer1_ElementMoved(object sender, Dalssoft.DiagramNet.ElementEventArgs e)
		{
			AppendLog("designer1_ElementMoved: {0}", e.ToString());
		}

		private void designer1_ElementMoving(object sender, Dalssoft.DiagramNet.ElementEventArgs e)
		{
			AppendLog("designer1_ElementMoving: {0}", e.ToString());
		}

		private void designer1_ElementResized(object sender, Dalssoft.DiagramNet.ElementEventArgs e)
		{
			AppendLog("designer1_ElementResized: {0}", e.ToString());
		}

		private void designer1_ElementResizing(object sender, Dalssoft.DiagramNet.ElementEventArgs e)
		{
			AppendLog("designer1_ElementResizing: {0}", e.ToString());
		}

		private void designer1_ElementConnected(object sender, Dalssoft.DiagramNet.ElementConnectEventArgs e)
		{
			AppendLog("designer1_ElementConnected: {0}", e.ToString());
		}

		private void designer1_ElementConnecting(object sender, Dalssoft.DiagramNet.ElementConnectEventArgs e)
		{
			AppendLog("designer1_ElementConnecting: {0}", e.ToString());
		}

		private void designer1_ElementSelection(object sender, Dalssoft.DiagramNet.ElementSelectionEventArgs e)
		{
			AppendLog("designer1_ElementSelection: {0}", e.ToString());
		}

		#endregion

		private void AppendLog(string log)
		{
			AppendLog(log, "");
		}

		private void AppendLog(string log, params object[] args)
		{
			//if (mnuShowDebugLog.Checked)
			//	txtLog.AppendText(String.Format(log, args) + "\r\n");
		}

        private void menuSaveas_Click(object sender, EventArgs e)
        {
            File_SaveAs();
        }

        private void TbCommentBoxNode_Click(object sender, EventArgs e)
        {
            Action_Add(ElementType.CommentBoxNode);
        }
    }
}
