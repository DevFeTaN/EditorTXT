namespace EditorTxT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            TxTConteudo.Clear();
            mArquivoSalva.Enabled = true;
            Text = Application.ProductName;

        }



        private void mArquivonovaJanela_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();

            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }


        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir...";
            dialog.Filter = "rich text file |*.rtf|texto|*.txt|todos|*.*";

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + "-" + file.Name;

                    Gerenciador.FolderPath = file.DirectoryName + "\\";

                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    StreamReader stream = null;
                    try
                    {
                        stream = new StreamReader(file.FullName, true);

                        TxTConteudo.Text = stream.ReadToEnd();

                        mArquivoSalva.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de arquivo nao suportado.\n " + ex.Message);



                    }
                    finally
                    {
                        stream.Close();
                    }

                }

            }
        }

        private void mArquivoSalva_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvaArquivo(Gerenciador.FilePath);

            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salva....";
                dialog.Filter = "rich text file |*.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvaArquivo(dialog.FileName);

                }
            }

        }



        private void mArquivosalvaComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salva Como...";
            dialog.Filter = "rich text file |*.rtf|texto|*.txt|todos|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;


            var result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvaArquivo(dialog.FileName);

            }
        }
        private void SalvaArquivo(string path)
        {
            //objeto responsavel por escrever o arquivo

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(TxTConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";

                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;

                Text = Application.ProductName + "-" + file.Name;

                mArquivoSalva.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro Salvae arquivo: \n" + ex.Message);


            }
            finally
            {
                writer.Close();
            }

        }



        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            var resul = MessageBox.Show("Deseja reamente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                Application.Exit();


            }



        }
        private void TxTConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalva.Enabled = true;
        }





        #endregion


        #region Menu Editar

        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            TxTConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            TxTConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            TxTConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            TxTConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            TxTConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            TxTConteudo.Text.Remove(TxTConteudo.SelectionStart, TxTConteudo.SelectedText.Length);


        }

        private void mEditarDataEHora_Click(object sender, EventArgs e)
        {
            int index = TxTConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (TxTConteudo.SelectionStart == TxTConteudo.Text.ToLower().Length)
            {
                TxTConteudo.Text = TxTConteudo.Text + dataHora;
                TxTConteudo.SelectionStart = index + dataHora.Length;
                return;

            }

            string temp = "";
            for (int i = 0; i < TxTConteudo.Text.Length; i++)
            {
                if (i == TxTConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += TxTConteudo.Text[i];

                }
                else
                {
                    temp += TxTConteudo.Text[i];
                }

            }

            TxTConteudo.Text = temp;
            TxTConteudo.SelectionStart = index + dataHora.Length;

        }



        #endregion


        #region Menu Formatar
        private void mFormataAquebraAutomaticaDeLinha_Click(object sender, EventArgs e)
        {
            TxTConteudo.WordWrap = mFormataAquebraAutomaticaDeLinha.Checked;


        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;

            fonte.Font = TxTConteudo.Font;
            fonte.Color = TxTConteudo.ForeColor;

            DialogResult result = fonte.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxTConteudo.Font = fonte.Font;
                TxTConteudo.ForeColor = fonte.Color;


            }


        }


        #endregion


        #region MenuExibir
        private void mExibirAmpliar_Click(object sender, EventArgs e)
        {
            TxTConteudo.ZoomFactor += 0.1f;
            AtualizaZoomStatusBar(TxTConteudo.ZoomFactor);
        }

        private void mExibirReduzir_Click(object sender, EventArgs e)
        {
            TxTConteudo.ZoomFactor -= 0.1f;
            AtualizaZoomStatusBar(TxTConteudo.ZoomFactor);
        }

        private void mExibirResturar_Click(object sender, EventArgs e)
        {
            TxTConteudo.ZoomFactor = 1f;
            AtualizaZoomStatusBar(TxTConteudo.ZoomFactor);
        }

        private void mExibirBarraDeStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirBarraDeStatus.Checked;

        }

        private void AtualizaZoomStatusBar(float zoom)
        {
            StatusBarLabel.Text = $"{ Math.Round(zoom * 100)}%";

        }
        #endregion


        #region MenuAjuda
        private void mAjudaExibirAjuda_Click(object sender, EventArgs e)
        {

          //WebBrowser webBrowser = new WebBrowser();

           FormAjuda f = new FormAjuda();
            f.Show();

        }

        private void mAjudaSobreOEditor_Click(object sender, EventArgs e)
        {
            FormSobre f = new FormSobre();
            f.Show();
        }

        #endregion

        #region 


        //Barra Ferramentas - novo
        private void toolBarNOVO_Click(object sender, EventArgs e)
        {
          mArquivoNovo_Click(sender,e);


        }
        #endregion
    }
}
