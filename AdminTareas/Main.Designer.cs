namespace AdminTareas
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            lblAgregarTareas = new DevExpress.XtraEditors.LabelControl();
            dgvTareas = new DevExpress.XtraGrid.GridControl();
            tareaViewModelBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            colGuardarCommand = new DevExpress.XtraGrid.Columns.GridColumn();
            colCargarTareasCommand = new DevExpress.XtraGrid.Columns.GridColumn();
            delete = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            editar = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            btnRecuperar = new Button();
            lblEstado = new DevExpress.XtraEditors.LabelControl();
            txtEstado = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lblDescricion = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            txtDescricion = new DevExpress.XtraEditors.TextEdit();
            btn_guardar = new Button();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            cmbEstado = new DevExpress.XtraScheduler.UI.ResourcesComboBoxControl();
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tareaViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemFontEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEstado.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbEstado.Properties).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(panelControl1);
            fluentDesignFormContainer1.Controls.Add(dgvTareas);
            fluentDesignFormContainer1.Controls.Add(btnRecuperar);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(303, 0);
            fluentDesignFormContainer1.Margin = new Padding(4, 3, 4, 3);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(503, 546);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // lblAgregarTareas
            // 
            lblAgregarTareas.Location = new Point(25, 12);
            lblAgregarTareas.Name = "lblAgregarTareas";
            lblAgregarTareas.Size = new Size(70, 13);
            lblAgregarTareas.TabIndex = 7;
            lblAgregarTareas.Text = "Agregar Tarea";
            // 
            // dgvTareas
            // 
            dgvTareas.DataSource = tareaViewModelBindingSource;
            dgvTareas.Location = new Point(3, 395);
            dgvTareas.MainView = gridView1;
            dgvTareas.MenuManager = fluentFormDefaultManager1;
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, repositoryItemButtonEdit2 });
            dgvTareas.Size = new Size(400, 200);
            dgvTareas.TabIndex = 6;
            dgvTareas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            dgvTareas.Click += dgvTareas_Click;
            // 
            // tareaViewModelBindingSource
            // 
            tareaViewModelBindingSource.DataSource = typeof(ViewModels.TareaViewModel);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colDescripcion, colEstado, colGuardarCommand, colCargarTareasCommand, delete, editar });
            gridView1.GridControl = dgvTareas;
            gridView1.Name = "gridView1";
            gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colDescripcion
            // 
            colDescripcion.FieldName = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Visible = true;
            colDescripcion.VisibleIndex = 0;
            // 
            // colEstado
            // 
            colEstado.FieldName = "Estado";
            colEstado.Name = "colEstado";
            colEstado.Visible = true;
            colEstado.VisibleIndex = 1;
            // 
            // colGuardarCommand
            // 
            colGuardarCommand.FieldName = "GuardarCommand";
            colGuardarCommand.Name = "colGuardarCommand";
            // 
            // colCargarTareasCommand
            // 
            colCargarTareasCommand.FieldName = "CargarTareasCommand";
            colCargarTareasCommand.Name = "colCargarTareasCommand";
            colCargarTareasCommand.OptionsColumn.ReadOnly = true;
            // 
            // delete
            // 
            delete.Caption = "Eliminar";
            delete.ColumnEdit = repositoryItemButtonEdit1;
            delete.Name = "delete";
            delete.Visible = true;
            delete.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit1.Click += repositoryItemButtonEdit1_Click;
            // 
            // editar
            // 
            editar.Caption = "Editar";
            editar.ColumnEdit = repositoryItemButtonEdit2;
            editar.Name = "editar";
            editar.Visible = true;
            editar.VisibleIndex = 3;
            // 
            // repositoryItemButtonEdit2
            // 
            repositoryItemButtonEdit2.AutoHeight = false;
            repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit2.Click += EditarTarea;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barEditItem1 });
            fluentFormDefaultManager1.MaxItemId = 1;
            fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemFontEdit1 });
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = repositoryItemFontEdit1;
            barEditItem1.Id = 0;
            barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemFontEdit1
            // 
            repositoryItemFontEdit1.AutoHeight = false;
            repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(323, 434);
            btnRecuperar.Margin = new Padding(4, 3, 4, 3);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(127, 35);
            btnRecuperar.TabIndex = 5;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(47, 83);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(33, 13);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(195, 161);
            txtEstado.Margin = new Padding(4, 3, 4, 3);
            txtEstado.MenuManager = fluentFormDefaultManager1;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(117, 20);
            txtEstado.TabIndex = 3;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(53, 124);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(48, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Descricion";
            // 
            // lblDescricion
            // 
            lblDescricion.Location = new Point(47, 41);
            lblDescricion.Name = "lblDescricion";
            lblDescricion.Size = new Size(54, 13);
            lblDescricion.TabIndex = 2;
            lblDescricion.Text = "Descripción";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(47, 143);
            textEdit1.Margin = new Padding(4, 3, 4, 3);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(117, 20);
            textEdit1.TabIndex = 1;
            // 
            // txtDescricion
            // 
            txtDescricion.Location = new Point(47, 57);
            txtDescricion.Margin = new Padding(4, 3, 4, 3);
            txtDescricion.MenuManager = fluentFormDefaultManager1;
            txtDescricion.Name = "txtDescricion";
            txtDescricion.Size = new Size(403, 20);
            txtDescricion.TabIndex = 1;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(341, 146);
            btn_guardar.Margin = new Padding(4, 3, 4, 3);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 35);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            accordionControl1.Location = new Point(0, 0);
            accordionControl1.Margin = new Padding(4, 3, 4, 3);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new Size(303, 546);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Lista Tareas";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barEditItem1 });
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Margin = new Padding(4, 3, 4, 3);
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemFontEdit1 });
            fluentDesignFormControl1.Size = new Size(806, 0);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(barEditItem1);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(cmbEstado);
            panelControl1.Controls.Add(lblAgregarTareas);
            panelControl1.Controls.Add(lblDescricion);
            panelControl1.Controls.Add(btn_guardar);
            panelControl1.Controls.Add(lblEstado);
            panelControl1.Controls.Add(txtDescricion);
            panelControl1.Controls.Add(txtEstado);
            panelControl1.Controls.Add(textEdit1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(486, 199);
            panelControl1.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.Location = new Point(47, 98);
            cmbEstado.MenuManager = fluentFormDefaultManager1;
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbEstado.Size = new Size(403, 20);
            cmbEstado.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 546);
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "Administrador Tareas";
            fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)tareaViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemFontEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEstado.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbEstado.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private Button btn_guardar;
        private DevExpress.XtraEditors.TextEdit txtDescricion;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private DevExpress.XtraEditors.LabelControl lblDescricion;
        private Button btnRecuperar;
        private BindingSource tareaViewModelBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private DevExpress.XtraGrid.GridControl dgvTareas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colGuardarCommand;
        private DevExpress.XtraGrid.Columns.GridColumn colCargarTareasCommand;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.LabelControl lblAgregarTareas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraScheduler.UI.ResourcesComboBoxControl cmbEstado;
    }
}