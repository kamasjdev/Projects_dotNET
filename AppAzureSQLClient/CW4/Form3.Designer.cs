namespace CW4
{
    partial class Pojedynczo
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label imięLabel;
            System.Windows.Forms.Label dataUrodzeniaLabel;
            System.Windows.Forms.Label miejscowoscLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label nrdomuLabel;
            System.Windows.Forms.Label nrmieszkaniaLabel;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label pocztaLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label peselLabel;
            System.Windows.Forms.Label nipLabel;
            System.Windows.Forms.Label dataUtwLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pojedynczo));
            this.labdbDataSet = new CW4.labdbDataSet();
            this.osobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobyTableAdapter = new CW4.labdbDataSetTableAdapters.OsobyTableAdapter();
            this.tableAdapterManager = new CW4.labdbDataSetTableAdapters.TableAdapterManager();
            this.osobyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.osobyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.imięTextBox = new System.Windows.Forms.TextBox();
            this.dataUrodzeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.miejscowoscTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.nrdomuTextBox = new System.Windows.Forms.TextBox();
            this.nrmieszkaniaTextBox = new System.Windows.Forms.TextBox();
            this.kodTextBox = new System.Windows.Forms.TextBox();
            this.pocztaTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.nipTextBox = new System.Windows.Forms.TextBox();
            this.dataUtwDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            imięLabel = new System.Windows.Forms.Label();
            dataUrodzeniaLabel = new System.Windows.Forms.Label();
            miejscowoscLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            nrdomuLabel = new System.Windows.Forms.Label();
            nrmieszkaniaLabel = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            pocztaLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            peselLabel = new System.Windows.Forms.Label();
            nipLabel = new System.Windows.Forms.Label();
            dataUtwLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingNavigator)).BeginInit();
            this.osobyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(37, 68);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(37, 104);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(54, 13);
            nazwiskoLabel.TabIndex = 3;
            nazwiskoLabel.Text = "nazwisko:";
            // 
            // imięLabel
            // 
            imięLabel.AutoSize = true;
            imięLabel.Location = new System.Drawing.Point(37, 130);
            imięLabel.Name = "imięLabel";
            imięLabel.Size = new System.Drawing.Size(28, 13);
            imięLabel.TabIndex = 5;
            imięLabel.Text = "imię:";
            // 
            // dataUrodzeniaLabel
            // 
            dataUrodzeniaLabel.AutoSize = true;
            dataUrodzeniaLabel.Location = new System.Drawing.Point(37, 165);
            dataUrodzeniaLabel.Name = "dataUrodzeniaLabel";
            dataUrodzeniaLabel.Size = new System.Drawing.Size(82, 13);
            dataUrodzeniaLabel.TabIndex = 7;
            dataUrodzeniaLabel.Text = "data Urodzenia:";
            // 
            // miejscowoscLabel
            // 
            miejscowoscLabel.AutoSize = true;
            miejscowoscLabel.Location = new System.Drawing.Point(37, 191);
            miejscowoscLabel.Name = "miejscowoscLabel";
            miejscowoscLabel.Size = new System.Drawing.Size(70, 13);
            miejscowoscLabel.TabIndex = 9;
            miejscowoscLabel.Text = "miejscowosc:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(37, 217);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(32, 13);
            ulicaLabel.TabIndex = 11;
            ulicaLabel.Text = "ulica:";
            // 
            // nrdomuLabel
            // 
            nrdomuLabel.AutoSize = true;
            nrdomuLabel.Location = new System.Drawing.Point(37, 243);
            nrdomuLabel.Name = "nrdomuLabel";
            nrdomuLabel.Size = new System.Drawing.Size(45, 13);
            nrdomuLabel.TabIndex = 13;
            nrdomuLabel.Text = "nrdomu:";
            // 
            // nrmieszkaniaLabel
            // 
            nrmieszkaniaLabel.AutoSize = true;
            nrmieszkaniaLabel.Location = new System.Drawing.Point(37, 272);
            nrmieszkaniaLabel.Name = "nrmieszkaniaLabel";
            nrmieszkaniaLabel.Size = new System.Drawing.Size(71, 13);
            nrmieszkaniaLabel.TabIndex = 15;
            nrmieszkaniaLabel.Text = "nrmieszkania:";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Location = new System.Drawing.Point(41, 298);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(28, 13);
            kodLabel.TabIndex = 17;
            kodLabel.Text = "kod:";
            // 
            // pocztaLabel
            // 
            pocztaLabel.AutoSize = true;
            pocztaLabel.Location = new System.Drawing.Point(40, 324);
            pocztaLabel.Name = "pocztaLabel";
            pocztaLabel.Size = new System.Drawing.Size(42, 13);
            pocztaLabel.TabIndex = 19;
            pocztaLabel.Text = "poczta:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(37, 353);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(21, 13);
            telLabel.TabIndex = 21;
            telLabel.Text = "tel:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(37, 379);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "email:";
            // 
            // peselLabel
            // 
            peselLabel.AutoSize = true;
            peselLabel.Location = new System.Drawing.Point(37, 405);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new System.Drawing.Size(35, 13);
            peselLabel.TabIndex = 25;
            peselLabel.Text = "pesel:";
            // 
            // nipLabel
            // 
            nipLabel.AutoSize = true;
            nipLabel.Location = new System.Drawing.Point(37, 431);
            nipLabel.Name = "nipLabel";
            nipLabel.Size = new System.Drawing.Size(24, 13);
            nipLabel.TabIndex = 27;
            nipLabel.Text = "nip:";
            // 
            // dataUtwLabel
            // 
            dataUtwLabel.AutoSize = true;
            dataUtwLabel.Location = new System.Drawing.Point(102, 505);
            dataUtwLabel.Name = "dataUtwLabel";
            dataUtwLabel.Size = new System.Drawing.Size(53, 13);
            dataUtwLabel.TabIndex = 29;
            dataUtwLabel.Text = "data Utw:";
            // 
            // labdbDataSet
            // 
            this.labdbDataSet.DataSetName = "labdbDataSet";
            this.labdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osobyBindingSource
            // 
            this.osobyBindingSource.DataMember = "Osoby";
            this.osobyBindingSource.DataSource = this.labdbDataSet;
            // 
            // osobyTableAdapter
            // 
            this.osobyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.kontaTableAdapter = null;
            this.tableAdapterManager.OsobyTableAdapter = this.osobyTableAdapter;
            this.tableAdapterManager.UpdateOrder = CW4.labdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // osobyBindingNavigator
            // 
            this.osobyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.osobyBindingNavigator.BindingSource = this.osobyBindingSource;
            this.osobyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.osobyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.osobyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.osobyBindingNavigatorSaveItem});
            this.osobyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.osobyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.osobyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.osobyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.osobyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.osobyBindingNavigator.Name = "osobyBindingNavigator";
            this.osobyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.osobyBindingNavigator.Size = new System.Drawing.Size(529, 25);
            this.osobyBindingNavigator.TabIndex = 0;
            this.osobyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // osobyBindingNavigatorSaveItem
            // 
            this.osobyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyBindingNavigatorSaveItem.Image")));
            this.osobyBindingNavigatorSaveItem.Name = "osobyBindingNavigatorSaveItem";
            this.osobyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.osobyBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.osobyBindingNavigatorSaveItem.Click += new System.EventHandler(this.osobyBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(125, 68);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(363, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(125, 104);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(363, 20);
            this.nazwiskoTextBox.TabIndex = 4;
            // 
            // imięTextBox
            // 
            this.imięTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "imię", true));
            this.imięTextBox.Location = new System.Drawing.Point(125, 130);
            this.imięTextBox.Name = "imięTextBox";
            this.imięTextBox.Size = new System.Drawing.Size(363, 20);
            this.imięTextBox.TabIndex = 6;
            // 
            // dataUrodzeniaDateTimePicker
            // 
            this.dataUrodzeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.osobyBindingSource, "dataUrodzenia", true));
            this.dataUrodzeniaDateTimePicker.Location = new System.Drawing.Point(125, 165);
            this.dataUrodzeniaDateTimePicker.Name = "dataUrodzeniaDateTimePicker";
            this.dataUrodzeniaDateTimePicker.Size = new System.Drawing.Size(363, 20);
            this.dataUrodzeniaDateTimePicker.TabIndex = 8;
            // 
            // miejscowoscTextBox
            // 
            this.miejscowoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "miejscowosc", true));
            this.miejscowoscTextBox.Location = new System.Drawing.Point(125, 191);
            this.miejscowoscTextBox.Name = "miejscowoscTextBox";
            this.miejscowoscTextBox.Size = new System.Drawing.Size(363, 20);
            this.miejscowoscTextBox.TabIndex = 10;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(125, 217);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(363, 20);
            this.ulicaTextBox.TabIndex = 12;
            // 
            // nrdomuTextBox
            // 
            this.nrdomuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "nrdomu", true));
            this.nrdomuTextBox.Location = new System.Drawing.Point(125, 243);
            this.nrdomuTextBox.Name = "nrdomuTextBox";
            this.nrdomuTextBox.Size = new System.Drawing.Size(363, 20);
            this.nrdomuTextBox.TabIndex = 14;
            // 
            // nrmieszkaniaTextBox
            // 
            this.nrmieszkaniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "nrmieszkania", true));
            this.nrmieszkaniaTextBox.Location = new System.Drawing.Point(125, 269);
            this.nrmieszkaniaTextBox.Name = "nrmieszkaniaTextBox";
            this.nrmieszkaniaTextBox.Size = new System.Drawing.Size(363, 20);
            this.nrmieszkaniaTextBox.TabIndex = 16;
            // 
            // kodTextBox
            // 
            this.kodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "kod", true));
            this.kodTextBox.Location = new System.Drawing.Point(125, 295);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(363, 20);
            this.kodTextBox.TabIndex = 18;
            // 
            // pocztaTextBox
            // 
            this.pocztaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "poczta", true));
            this.pocztaTextBox.Location = new System.Drawing.Point(125, 324);
            this.pocztaTextBox.Name = "pocztaTextBox";
            this.pocztaTextBox.Size = new System.Drawing.Size(363, 20);
            this.pocztaTextBox.TabIndex = 20;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "tel", true));
            this.telTextBox.Location = new System.Drawing.Point(125, 350);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(363, 20);
            this.telTextBox.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(125, 376);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(363, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // peselTextBox
            // 
            this.peselTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "pesel", true));
            this.peselTextBox.Location = new System.Drawing.Point(125, 402);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(363, 20);
            this.peselTextBox.TabIndex = 26;
            // 
            // nipTextBox
            // 
            this.nipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "nip", true));
            this.nipTextBox.Location = new System.Drawing.Point(125, 428);
            this.nipTextBox.Name = "nipTextBox";
            this.nipTextBox.Size = new System.Drawing.Size(363, 20);
            this.nipTextBox.TabIndex = 28;
            // 
            // dataUtwDateTimePicker
            // 
            this.dataUtwDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.osobyBindingSource, "dataUtw", true));
            this.dataUtwDateTimePicker.Location = new System.Drawing.Point(161, 501);
            this.dataUtwDateTimePicker.Name = "dataUtwDateTimePicker";
            this.dataUtwDateTimePicker.Size = new System.Drawing.Size(307, 20);
            this.dataUtwDateTimePicker.TabIndex = 30;
            // 
            // Pojedynczo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 574);
            this.Controls.Add(dataUtwLabel);
            this.Controls.Add(this.dataUtwDateTimePicker);
            this.Controls.Add(nipLabel);
            this.Controls.Add(this.nipTextBox);
            this.Controls.Add(peselLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(pocztaLabel);
            this.Controls.Add(this.pocztaTextBox);
            this.Controls.Add(kodLabel);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(nrmieszkaniaLabel);
            this.Controls.Add(this.nrmieszkaniaTextBox);
            this.Controls.Add(nrdomuLabel);
            this.Controls.Add(this.nrdomuTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(miejscowoscLabel);
            this.Controls.Add(this.miejscowoscTextBox);
            this.Controls.Add(dataUrodzeniaLabel);
            this.Controls.Add(this.dataUrodzeniaDateTimePicker);
            this.Controls.Add(imięLabel);
            this.Controls.Add(this.imięTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.osobyBindingNavigator);
            this.Name = "Pojedynczo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pojedynczo";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingNavigator)).EndInit();
            this.osobyBindingNavigator.ResumeLayout(false);
            this.osobyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private labdbDataSet labdbDataSet;
        private System.Windows.Forms.BindingSource osobyBindingSource;
        private labdbDataSetTableAdapters.OsobyTableAdapter osobyTableAdapter;
        private labdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator osobyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton osobyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox imięTextBox;
        private System.Windows.Forms.DateTimePicker dataUrodzeniaDateTimePicker;
        private System.Windows.Forms.TextBox miejscowoscTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox nrdomuTextBox;
        private System.Windows.Forms.TextBox nrmieszkaniaTextBox;
        private System.Windows.Forms.TextBox kodTextBox;
        private System.Windows.Forms.TextBox pocztaTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox nipTextBox;
        private System.Windows.Forms.DateTimePicker dataUtwDateTimePicker;
    }
}