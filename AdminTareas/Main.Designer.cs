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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            txtNotas = new TextBox();
            lblNotas = new DevExpress.XtraEditors.LabelControl();
            lblFechaCompromiso = new DevExpress.XtraEditors.LabelControl();
            fechaCompromiso = new DevExpress.XtraEditors.DateEdit();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            lookUpEditPrioridad = new DevExpress.XtraEditors.LookUpEdit();
            tareasBindingSource = new BindingSource(components);
            tareaViewModelBindingSource = new BindingSource(components);
            lbPrioridad = new DevExpress.XtraEditors.LabelControl();
            btnLimpiar = new Button();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            lblAgregarTareas = new DevExpress.XtraEditors.LabelControl();
            lblDescricion = new DevExpress.XtraEditors.LabelControl();
            btn_guardar = new Button();
            lblEstado = new DevExpress.XtraEditors.LabelControl();
            txtDescricion = new DevExpress.XtraEditors.TextEdit();
            dgvTareas = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaCompromiso = new DevExpress.XtraGrid.Columns.GridColumn();
            buttonDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            buttonEditarRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            tareasBindingSource1 = new BindingSource(components);
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fechaCompromiso.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fechaCompromiso.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemFontEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditPrioridad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tareasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tareaViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonDeleteRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonEditarRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tareasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(panelControl1);
            fluentDesignFormContainer1.Controls.Add(dgvTareas);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(303, 0);
            fluentDesignFormContainer1.Margin = new Padding(4, 3, 4, 3);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(684, 546);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(txtNotas);
            panelControl1.Controls.Add(lblNotas);
            panelControl1.Controls.Add(lblFechaCompromiso);
            panelControl1.Controls.Add(fechaCompromiso);
            panelControl1.Controls.Add(lookUpEditPrioridad);
            panelControl1.Controls.Add(lbPrioridad);
            panelControl1.Controls.Add(btnLimpiar);
            panelControl1.Controls.Add(lookUpEdit1);
            panelControl1.Controls.Add(lblAgregarTareas);
            panelControl1.Controls.Add(lblDescricion);
            panelControl1.Controls.Add(btn_guardar);
            panelControl1.Controls.Add(lblEstado);
            panelControl1.Controls.Add(txtDescricion);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(667, 329);
            panelControl1.TabIndex = 8;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(47, 238);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(403, 40);
            txtNotas.TabIndex = 16;
            // 
            // lblNotas
            // 
            lblNotas.Location = new Point(47, 219);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(28, 13);
            lblNotas.TabIndex = 15;
            lblNotas.Text = "Notas";
            // 
            // lblFechaCompromiso
            // 
            lblFechaCompromiso.Location = new Point(47, 174);
            lblFechaCompromiso.Name = "lblFechaCompromiso";
            lblFechaCompromiso.Size = new Size(90, 13);
            lblFechaCompromiso.TabIndex = 14;
            lblFechaCompromiso.Text = "Fecha Compromiso";
            // 
            // fechaCompromiso
            // 
            fechaCompromiso.EditValue = null;
            fechaCompromiso.Location = new Point(47, 193);
            fechaCompromiso.MenuManager = fluentFormDefaultManager1;
            fechaCompromiso.Name = "fechaCompromiso";
            fechaCompromiso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fechaCompromiso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fechaCompromiso.Size = new Size(403, 20);
            fechaCompromiso.TabIndex = 13;
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
            // lookUpEditPrioridad
            // 
            lookUpEditPrioridad.Location = new Point(47, 147);
            lookUpEditPrioridad.MenuManager = fluentFormDefaultManager1;
            lookUpEditPrioridad.Name = "lookUpEditPrioridad";
            lookUpEditPrioridad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditPrioridad.Properties.DataSource = tareasBindingSource;
            lookUpEditPrioridad.Properties.DisplayMember = "Descripcion";
            lookUpEditPrioridad.Properties.ValueMember = "Id";
            lookUpEditPrioridad.Size = new Size(403, 20);
            lookUpEditPrioridad.TabIndex = 12;
            // 
            // tareasBindingSource
            // 
            tareasBindingSource.DataMember = "Tareas";
            tareasBindingSource.DataSource = tareaViewModelBindingSource;
            // 
            // tareaViewModelBindingSource
            // 
            tareaViewModelBindingSource.DataSource = typeof(ViewModels.TareaViewModel);
            // 
            // lbPrioridad
            // 
            lbPrioridad.Location = new Point(47, 128);
            lbPrioridad.Name = "lbPrioridad";
            lbPrioridad.Size = new Size(42, 13);
            lbPrioridad.TabIndex = 11;
            lbPrioridad.Text = "Prioridad";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(184, 284);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 35);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(47, 102);
            lookUpEdit1.MenuManager = fluentFormDefaultManager1;
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Size = new Size(403, 20);
            lookUpEdit1.TabIndex = 9;
            // 
            // lblAgregarTareas
            // 
            lblAgregarTareas.Location = new Point(25, 12);
            lblAgregarTareas.Name = "lblAgregarTareas";
            lblAgregarTareas.Size = new Size(70, 13);
            lblAgregarTareas.TabIndex = 7;
            lblAgregarTareas.Text = "Agregar Tarea";
            // 
            // lblDescricion
            // 
            lblDescricion.Location = new Point(47, 41);
            lblDescricion.Name = "lblDescricion";
            lblDescricion.Size = new Size(54, 13);
            lblDescricion.TabIndex = 2;
            lblDescricion.Text = "Descripción";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(323, 284);
            btn_guardar.Margin = new Padding(4, 3, 4, 3);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 35);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(47, 83);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(33, 13);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
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
            // dgvTareas
            // 
            dgvTareas.DataSource = tareasBindingSource;
            dgvTareas.Location = new Point(25, 349);
            dgvTareas.MainView = gridView1;
            dgvTareas.MenuManager = fluentFormDefaultManager1;
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { buttonDeleteRow, buttonEditarRow });
            dgvTareas.Size = new Size(639, 294);
            dgvTareas.TabIndex = 6;
            dgvTareas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
        
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colDescripcion, colEstado, colPrioridad, colFechaCompromiso });
            gridView1.GridControl = dgvTareas;
            gridView1.Name = "gridView1";
            gridView1.OptionsFind.AlwaysVisible = true;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.RowAutoHeight = true;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            // 
            // colDescripcion
            // 
            colDescripcion.AppearanceCell.Options.UseTextOptions = true;
            colDescripcion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colDescripcion.FieldName = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.OptionsColumn.AllowEdit = false;
            colDescripcion.Visible = true;
            colDescripcion.VisibleIndex = 0;
            // 
            // colEstado
            // 
            colEstado.FieldName = "Estado";
            colEstado.Name = "colEstado";
            colEstado.OptionsColumn.AllowEdit = false;
            colEstado.Visible = true;
            colEstado.VisibleIndex = 1;
            // 
            // colPrioridad
            // 
            colPrioridad.FieldName = "Prioridad";
            colPrioridad.Name = "colPrioridad";
            colPrioridad.OptionsColumn.AllowEdit = false;
            colPrioridad.Visible = true;
            colPrioridad.VisibleIndex = 2;
            // 
            // colFechaCompromiso
            // 
            colFechaCompromiso.FieldName = "FechaCompromiso";
            colFechaCompromiso.Name = "colFechaCompromiso";
            colFechaCompromiso.OptionsColumn.AllowEdit = false;
            colFechaCompromiso.Visible = true;
            colFechaCompromiso.VisibleIndex = 3;
            // 
            // buttonDeleteRow
            // 
            buttonDeleteRow.AutoHeight = false;
            buttonDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            buttonDeleteRow.Name = "buttonDeleteRow";
            buttonDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // buttonEditarRow
            // 
            buttonEditarRow.AutoHeight = false;
            buttonEditarRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right) });
            buttonEditarRow.Name = "buttonEditarRow";
            buttonEditarRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tareasBindingSource1
            // 
            tareasBindingSource1.DataMember = "Tareas";
            tareasBindingSource1.DataSource = tareaViewModelBindingSource;
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
            fluentDesignFormControl1.Size = new Size(987, 0);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(barEditItem1);
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 546);
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "Administrador Tareas";
            fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fechaCompromiso.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fechaCompromiso.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemFontEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditPrioridad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tareasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tareaViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonDeleteRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonEditarRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)tareasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblDescricion;
        private BindingSource tareaViewModelBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private DevExpress.XtraGrid.GridControl dgvTareas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblAgregarTareas;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl lbPrioridad;
        private Button btnLimpiar;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPrioridad;
        private BindingSource tareasBindingSource;
        private DevExpress.XtraEditors.LabelControl lblFechaCompromiso;
        private DevExpress.XtraEditors.DateEdit fechaCompromiso;
        private DevExpress.XtraEditors.LabelControl lblNotas;
        private TextBox txtNotas;
        private BindingSource tareasBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colPrioridad;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCompromiso;
        private DevExpress.XtraGrid.Columns.GridColumn colNotas;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonDeleteRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonEditarRow;
    }
}