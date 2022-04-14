namespace EditorTxT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivonovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalva = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivosalvaComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataEHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormataAquebraAutomaticaDeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirResturar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarraDeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobreOEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBarNOVO = new System.Windows.Forms.ToolStripButton();
            this.toolBarAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolBarSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarZoom = new System.Windows.Forms.ToolStripButton();
            this.toolBarZoomMenos = new System.Windows.Forms.ToolStripButton();
            this.toolBarZoomMais = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarAjuda = new System.Windows.Forms.ToolStripButton();
            this.TxTConteudo = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 29);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivonovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalva,
            this.mArquivosalvaComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(80, 25);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Image = global::EditorTxT.Properties.Resources.text;
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNovo.Size = new System.Drawing.Size(270, 26);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivonovaJanela
            // 
            this.mArquivonovaJanela.Image = global::EditorTxT.Properties.Resources.notes;
            this.mArquivonovaJanela.Name = "mArquivonovaJanela";
            this.mArquivonovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivonovaJanela.Size = new System.Drawing.Size(270, 26);
            this.mArquivonovaJanela.Text = "Nova Janela";
            this.mArquivonovaJanela.Click += new System.EventHandler(this.mArquivonovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::EditorTxT.Properties.Resources.folder;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(270, 26);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalva
            // 
            this.mArquivoSalva.Image = global::EditorTxT.Properties.Resources.save;
            this.mArquivoSalva.Name = "mArquivoSalva";
            this.mArquivoSalva.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalva.Size = new System.Drawing.Size(270, 26);
            this.mArquivoSalva.Text = "Salva";
            this.mArquivoSalva.Click += new System.EventHandler(this.mArquivoSalva_Click);
            // 
            // mArquivosalvaComo
            // 
            this.mArquivosalvaComo.Image = global::EditorTxT.Properties.Resources.save;
            this.mArquivosalvaComo.Name = "mArquivosalvaComo";
            this.mArquivosalvaComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivosalvaComo.Size = new System.Drawing.Size(270, 26);
            this.mArquivosalvaComo.Text = "Salva Como";
            this.mArquivosalvaComo.Click += new System.EventHandler(this.mArquivosalvaComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::EditorTxT.Properties.Resources.exit;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(270, 26);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator3,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator4,
            this.mEditarDataEHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(64, 25);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(236, 26);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.mEditarRefazer.Size = new System.Drawing.Size(236, 26);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(236, 26);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(236, 26);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(236, 26);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            this.mEditarExcluir.Size = new System.Drawing.Size(236, 26);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // mEditarDataEHora
            // 
            this.mEditarDataEHora.Name = "mEditarDataEHora";
            this.mEditarDataEHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataEHora.Size = new System.Drawing.Size(236, 26);
            this.mEditarDataEHora.Text = "Data e Hora";
            this.mEditarDataEHora.Click += new System.EventHandler(this.mEditarDataEHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormataAquebraAutomaticaDeLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(88, 25);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormataAquebraAutomaticaDeLinha
            // 
            this.mFormataAquebraAutomaticaDeLinha.Checked = true;
            this.mFormataAquebraAutomaticaDeLinha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mFormataAquebraAutomaticaDeLinha.Name = "mFormataAquebraAutomaticaDeLinha";
            this.mFormataAquebraAutomaticaDeLinha.Size = new System.Drawing.Size(284, 26);
            this.mFormataAquebraAutomaticaDeLinha.Text = "Quebra automatica de Linha";
            this.mFormataAquebraAutomaticaDeLinha.Click += new System.EventHandler(this.mFormataAquebraAutomaticaDeLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(284, 26);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirBarraDeStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(62, 25);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirAmpliar,
            this.mExibirReduzir,
            this.mExibirResturar});
            this.mExibirZoom.Image = global::EditorTxT.Properties.Resources.zoom;
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(190, 26);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirAmpliar
            // 
            this.mExibirAmpliar.Name = "mExibirAmpliar";
            this.mExibirAmpliar.ShortcutKeyDisplayString = "Ctrl + sinal de Adicao";
            this.mExibirAmpliar.Size = new System.Drawing.Size(323, 26);
            this.mExibirAmpliar.Text = "Ampliar";
            this.mExibirAmpliar.Click += new System.EventHandler(this.mExibirAmpliar_Click);
            // 
            // mExibirReduzir
            // 
            this.mExibirReduzir.Name = "mExibirReduzir";
            this.mExibirReduzir.ShortcutKeyDisplayString = "Ctrl + sinal de Subtracao";
            this.mExibirReduzir.Size = new System.Drawing.Size(323, 26);
            this.mExibirReduzir.Text = "Reduzir";
            this.mExibirReduzir.Click += new System.EventHandler(this.mExibirReduzir_Click);
            // 
            // mExibirResturar
            // 
            this.mExibirResturar.Name = "mExibirResturar";
            this.mExibirResturar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mExibirResturar.Size = new System.Drawing.Size(323, 26);
            this.mExibirResturar.Text = "Restaurar";
            this.mExibirResturar.Click += new System.EventHandler(this.mExibirResturar_Click);
            // 
            // mExibirBarraDeStatus
            // 
            this.mExibirBarraDeStatus.Checked = true;
            this.mExibirBarraDeStatus.CheckOnClick = true;
            this.mExibirBarraDeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarraDeStatus.Name = "mExibirBarraDeStatus";
            this.mExibirBarraDeStatus.Size = new System.Drawing.Size(190, 26);
            this.mExibirBarraDeStatus.Text = "barra de Status";
            this.mExibirBarraDeStatus.Click += new System.EventHandler(this.mExibirBarraDeStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibirAjuda,
            this.mAjudaSobreOEditor});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(64, 25);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjuda
            // 
            this.mAjudaExibirAjuda.Image = global::EditorTxT.Properties.Resources.help;
            this.mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
            this.mAjudaExibirAjuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaExibirAjuda.Size = new System.Drawing.Size(190, 26);
            this.mAjudaExibirAjuda.Text = "Exibir Ajuda";
            this.mAjudaExibirAjuda.Click += new System.EventHandler(this.mAjudaExibirAjuda_Click);
            // 
            // mAjudaSobreOEditor
            // 
            this.mAjudaSobreOEditor.Name = "mAjudaSobreOEditor";
            this.mAjudaSobreOEditor.Size = new System.Drawing.Size(190, 26);
            this.mAjudaSobreOEditor.Text = "Sobre o Editor";
            this.mAjudaSobreOEditor.Click += new System.EventHandler(this.mAjudaSobreOEditor_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(35, 17);
            this.StatusBarLabel.Text = "100%";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarNOVO,
            this.toolBarAbrir,
            this.toolBarSalvar,
            this.toolStripSeparator5,
            this.toolBarFonte,
            this.toolStripSeparator6,
            this.toolBarZoom,
            this.toolBarZoomMenos,
            this.toolBarZoomMais,
            this.toolStripSeparator7,
            this.toolBarAjuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = " ";
            // 
            // toolBarNOVO
            // 
            this.toolBarNOVO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarNOVO.Image = global::EditorTxT.Properties.Resources.text;
            this.toolBarNOVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarNOVO.Name = "toolBarNOVO";
            this.toolBarNOVO.Size = new System.Drawing.Size(23, 22);
            this.toolBarNOVO.Text = "NOVO";
            this.toolBarNOVO.Click += new System.EventHandler(this.toolBarNOVO_Click);
            // 
            // toolBarAbrir
            // 
            this.toolBarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarAbrir.Image = global::EditorTxT.Properties.Resources.folder;
            this.toolBarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAbrir.Name = "toolBarAbrir";
            this.toolBarAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolBarAbrir.Text = "Abrir";
            this.toolBarAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // toolBarSalvar
            // 
            this.toolBarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSalvar.Image = global::EditorTxT.Properties.Resources.save;
            this.toolBarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSalvar.Name = "toolBarSalvar";
            this.toolBarSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolBarSalvar.Text = "Salvar";
            this.toolBarSalvar.ToolTipText = "Salvar";
            this.toolBarSalvar.Click += new System.EventHandler(this.mArquivoSalva_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBarFonte
            // 
            this.toolBarFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarFonte.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolBarFonte.Image")));
            this.toolBarFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFonte.Name = "toolBarFonte";
            this.toolBarFonte.Size = new System.Drawing.Size(23, 22);
            this.toolBarFonte.Text = "A";
            this.toolBarFonte.ToolTipText = "Formatar Fonte";
            this.toolBarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBarZoom
            // 
            this.toolBarZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarZoom.Image = global::EditorTxT.Properties.Resources.zoom;
            this.toolBarZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoom.Name = "toolBarZoom";
            this.toolBarZoom.Size = new System.Drawing.Size(23, 22);
            this.toolBarZoom.Text = "Zoom 100%";
            this.toolBarZoom.Click += new System.EventHandler(this.mExibirResturar_Click);
            // 
            // toolBarZoomMenos
            // 
            this.toolBarZoomMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarZoomMenos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolBarZoomMenos.Image = global::EditorTxT.Properties.Resources.zoom;
            this.toolBarZoomMenos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoomMenos.Name = "toolBarZoomMenos";
            this.toolBarZoomMenos.Size = new System.Drawing.Size(34, 22);
            this.toolBarZoomMenos.Text = "+";
            this.toolBarZoomMenos.ToolTipText = "Zoom+";
            this.toolBarZoomMenos.Click += new System.EventHandler(this.mExibirAmpliar_Click);
            // 
            // toolBarZoomMais
            // 
            this.toolBarZoomMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolBarZoomMais.ForeColor = System.Drawing.Color.DarkRed;
            this.toolBarZoomMais.Image = global::EditorTxT.Properties.Resources.zoom;
            this.toolBarZoomMais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarZoomMais.Name = "toolBarZoomMais";
            this.toolBarZoomMais.Size = new System.Drawing.Size(31, 22);
            this.toolBarZoomMais.Text = "-";
            this.toolBarZoomMais.ToolTipText = "Zoom -";
            this.toolBarZoomMais.Click += new System.EventHandler(this.mExibirReduzir_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBarAjuda
            // 
            this.toolBarAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarAjuda.Image = global::EditorTxT.Properties.Resources.help;
            this.toolBarAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarAjuda.Name = "toolBarAjuda";
            this.toolBarAjuda.Size = new System.Drawing.Size(23, 22);
            this.toolBarAjuda.Text = "Ajuda";
            this.toolBarAjuda.Click += new System.EventHandler(this.mAjudaExibirAjuda_Click);
            // 
            // TxTConteudo
            // 
            this.TxTConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxTConteudo.Location = new System.Drawing.Point(0, 54);
            this.TxTConteudo.Name = "TxTConteudo";
            this.TxTConteudo.Size = new System.Drawing.Size(784, 485);
            this.TxTConteudo.TabIndex = 4;
            this.TxTConteudo.Text = "";
            this.TxTConteudo.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TxTConteudo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorTxT";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivonovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalva;
        private ToolStripMenuItem mArquivosalvaComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataEHora;
        private ToolStripMenuItem mFormataAquebraAutomaticaDeLinha;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mExibirAmpliar;
        private ToolStripMenuItem mExibirReduzir;
        private ToolStripMenuItem mExibirResturar;
        private ToolStripMenuItem mExibirBarraDeStatus;
        private ToolStripMenuItem mAjudaExibirAjuda;
        private ToolStripMenuItem mAjudaSobreOEditor;
        private StatusStrip statusBar;
        private ToolStripStatusLabel StatusBarLabel;
        private ToolStrip toolStrip1;
        private RichTextBox TxTConteudo;
        private ToolStripButton toolBarNOVO;
        private ToolStripButton toolBarAbrir;
        private ToolStripButton toolBarSalvar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolBarFonte;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolBarZoom;
        private ToolStripButton toolBarZoomMenos;
        private ToolStripButton toolBarZoomMais;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolBarAjuda;
    }
}