using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;


namespace Organizador_2._0
{
    public partial class Form2 : Form
    {
        private bool isDarkMode = false;
        private string sourceFolder = "";
        private string outputFolder = "";
        private readonly SoundPlayer soundPlayer;

        public Form2()
        {
            InitializeComponent();

            // Configuração do tamanho fixo
            this.Size = new Size(338, 417);

            // Associar o evento btnModoEscuro_Click ao manipulador de eventos btnModoEscuro_Click
            Botao_Cor.Click += Botao_Cor_Click;

            // Configurar o BackgroundWorker para relatar progresso
            backgroundWorker1.WorkerReportsProgress = true;

            // Associar o evento DoWork ao manipulador de eventos backgroundWorker1_DoWork
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;

            // Associar o evento ProgressChanged ao manipulador de eventos BackgroundWorker1_ProgressChanged
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;

            // Inicialize o SoundPlayer com o arquivo de som
            string soundFilePath = Path.Combine(Application.StartupPath, "Sounds", "mouse_click.wav");

            if (File.Exists(soundFilePath))
            {
                soundPlayer = new SoundPlayer(soundFilePath);
            }
            else
            {
                MessageBox.Show("Arquivo de som não encontrado.");
                MessageBox.Show("Contate o desenvolvedor");
            }


            // Associe os eventos MouseEnter e MouseLeave apropriados a todos os botões
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += Button_MouseEnter;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string configPath = "config.txt";
            if (File.Exists(configPath))
            {
                string configContent = File.ReadAllText(configPath);
                isDarkMode = configContent.Trim() == "modo_escuro";
            }

            // Ajuste aqui usando if-else
            if (isDarkMode)
            {
                Botao_Cor.Text = "Modo Claro";
            }
            else
            {
                Botao_Cor.Text = "Modo Escuro";
            }
        }

        // Som >>>>>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Inicie a reprodução do som quando o mouse entra no botão
            soundPlayer?.Play();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            OrganizeFiles(sourceFolder, outputFolder);
        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            // Verifica se o progresso atingiu 100%
            if (e.ProgressPercentage == 100)
            {
                // Mostra a mensagem quando a organização estiver concluída
                MessageBox.Show("Organização concluída com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset a ProgressBar após a organização
                progressBar1.Value = 0;

                // Esconde o ícone de "verificado"
                PictureBox1.Visible = false;
                PictureBox2.Visible = false;

                // Reset das pastas de entrada e saída
                sourceFolder = "";
                outputFolder = "";
            }
        }


        private void OrganizeFiles(string sourceFolder, string outputFolder)
        {
            var allFiles = Directory.GetFiles(sourceFolder, "*", SearchOption.TopDirectoryOnly)
                        .Where(file => !new FileInfo(file).Attributes.HasFlag(FileAttributes.Hidden))
                        .ToArray();

            int totalFiles = allFiles.Length;
            int processedFiles = 0;

            var arquivosFolder = Path.Combine(outputFolder, "Arquivos");
            var destinationSubfolder = Path.Combine(arquivosFolder, "Arquivos.pasta");
            Directory.CreateDirectory(destinationSubfolder);

            var folders = Directory.GetDirectories(sourceFolder)
                                  .Where(folder => !new DirectoryInfo(folder).Attributes.HasFlag(FileAttributes.Hidden));

            foreach (var folder in folders)
            {
                var folderName = new DirectoryInfo(folder).Name;

                if (folderName.Equals("Arquivos"))
                    continue;

                var destinationFolder = Path.Combine(destinationSubfolder, folderName);
                Directory.Move(folder, destinationFolder);
            }

            foreach (var file in allFiles)
            {
                var extension = Path.GetExtension(file);

                if (string.IsNullOrEmpty(extension))
                {
                    continue;
                }

                var destinationFolder = Path.Combine(arquivosFolder, "Arquivos" + extension);
                Directory.CreateDirectory(destinationFolder);

                var fileName = Path.GetFileName(file);
                var destinationFile = Path.Combine(destinationFolder, fileName);

                if (File.Exists(destinationFile))
                {
                    int suffix = 1;
                    string originalFileName = Path.GetFileNameWithoutExtension(file);
                    string newFileName = $"{originalFileName}_{suffix}{extension}";

                    while (File.Exists(Path.Combine(destinationFolder, newFileName)))
                    {
                        suffix++;
                        newFileName = $"{originalFileName}_{suffix}{extension}";
                    }

                    destinationFile = Path.Combine(destinationFolder, newFileName);
                }

                File.Move(file, destinationFile);

                processedFiles++;
                int progressPercentage = processedFiles * 100 / totalFiles;

                // Relatar o progresso pra progressbar
                backgroundWorker1.ReportProgress(progressPercentage);
            }
        }

        private void Botao_Cor_Click(object sender, EventArgs e)
        {
            try
            {
                // Inverte o valor de isDarkMode
                isDarkMode = !isDarkMode;

                // Adicione mensagens de console para depuração
                Console.WriteLine($"isDarkMode: {isDarkMode}");

                // Garanta que Botao_Cor está sendo referenciado corretamente
                if (sender is Button botao)
                {
                    // Define o texto do botão com base no modo
                    botao.Text = isDarkMode ? "Modo Claro" : "Modo Escuro";

                    // Adicione mensagens de console para depuração
                    Console.WriteLine($"Botao_Cor.Text: {botao.Text}");

                    // Salva o novo modo no arquivo config.txt
                    string configPath = "config.txt";
                    File.WriteAllText(configPath, isDarkMode ? "modo_escuro" : "modo_claro");
                }
                else
                {
                    Console.WriteLine("Erro: O sender não é do tipo Button.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar Botao_Cor_Click: {ex.Message}");
            }
        }

        private void Botao_Update_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/BegunKetchup231";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
                MessageBox.Show("Contate o desenvolvedor");
            }
        }

        private void Botao_Entrada_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolder = dialog.SelectedPath;
                PictureBox1.Visible = true; // Mostra o ícone de "verificado"
            }
        }

        private void Botao_Saida_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                outputFolder = dialog.SelectedPath;
                PictureBox2.Visible = true; // Mostra o ícone de "verificado"
            }
        }

        private void Botao_Organizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFolder))
            {
                MessageBox.Show("Selecione a pasta de entrada (Botão 1) primeiro!");
                return;
            }

            if (string.IsNullOrEmpty(outputFolder))
            {
                MessageBox.Show("Selecione a pasta de saída (Botão 2) antes de organizar.");
                return;
            }

            OrganizeFiles(sourceFolder, outputFolder);

        }

        private void Botao_Dev_Click(object sender, EventArgs e)
        {
            string url = "https://keepo.io/begunketchup231/";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
                MessageBox.Show("Contate o desenvolvedor");
            }
        }

        private void Botao_Git_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/BegunKetchup231";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
                MessageBox.Show("Contate o desenvolvedor");
            }
        }

        private void Botao_Discord_Click(object sender, EventArgs e)
        {
            var url = "https://discord.com/invite/Tq8gmMpu5C";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
                MessageBox.Show("Contate o desenvolvedor");
            }
        }
    }
}