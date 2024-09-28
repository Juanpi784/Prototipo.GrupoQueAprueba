namespace Prototipo.GrupoQueAprueba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("CUIT");
            ListViewItem listViewItem2 = new ListViewItem("Codigo Cliente");
            ListViewItem listViewItem3 = new ListViewItem("Razon Social");
            ListViewItem listViewItem4 = new ListViewItem("");
            ListViewItem listViewItem5 = new ListViewItem("Codigo");
            ListViewItem listViewItem6 = new ListViewItem("Descripcion");
            ListViewItem listViewItem7 = new ListViewItem("Posicion");
            ListViewItem listViewItem8 = new ListViewItem("Cantidad");
            textBox1 = new TextBox();
            label1 = new Label();
            atosCliente = new ListView();
            buscar = new Button();
            inventario = new ListView();
            listView8 = new ListView();
            label2 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 7);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "CUIT";
            label1.Click += label1_Click;
            // 
            // atosCliente
            // 
            atosCliente.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            atosCliente.Location = new Point(12, 108);
            atosCliente.Name = "atosCliente";
            atosCliente.Size = new Size(244, 97);
            atosCliente.TabIndex = 2;
            atosCliente.UseCompatibleStateImageBehavior = false;
            atosCliente.SelectedIndexChanged += DatosCliente_SelectedIndexChanged;
            // 
            // buscar
            // 
            buscar.Location = new Point(181, 54);
            buscar.Name = "buscar";
            buscar.Size = new Size(75, 23);
            buscar.TabIndex = 3;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // inventario
            // 
            inventario.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            inventario.Location = new Point(12, 222);
            inventario.Name = "inventario";
            inventario.Size = new Size(400, 94);
            inventario.TabIndex = 4;
            inventario.UseCompatibleStateImageBehavior = false;
            inventario.SelectedIndexChanged += inventario_SelectedIndexChanged;
            // 
            // listView8
            // 
            listView8.Location = new Point(28, 379);
            listView8.Name = "listView8";
            listView8.Size = new Size(279, 119);
            listView8.TabIndex = 11;
            listView8.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 412);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 12;
            label2.Text = "Preparacionn";
            // 
            // button1
            // 
            button1.Location = new Point(258, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 332);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 21;
            label5.Text = "Codigo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 332);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 22;
            label6.Text = "Cantidad";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 350);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 23;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pepe", "Ramon", "Luis", "David" });
            checkedListBox1.Location = new Point(28, 516);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pepe", "Ramon", "Luis", "David", "Tomas", "Juan", "Ana", "Lean", "Nahuel" });
            comboBox1.Location = new Point(273, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 641);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listView8);
            Controls.Add(inventario);
            Controls.Add(buscar);
            Controls.Add(atosCliente);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ListView atosCliente;
        private Button buscar;
        private ListView inventario;
        private ListView listView8;
        private Label label2;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
    }
}
