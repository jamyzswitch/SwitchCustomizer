using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace switch_logo_patcher
{
    public partial class Form1 : Form
    {
        private bool firstSelection = true;
        private string cheminDossier;
        public Form1()
        {
            InitializeComponent();
            Background_hbmenu_Button.Enabled = false;
            Background_hekate_Button.Enabled = false;
            BootLogo_Button.Enabled = false;
            Hekate_button.Enabled = false;
            Create_button.Enabled = false;
            Disk.DropDownStyle = ComboBoxStyle.DropDownList;
            RemplirComboBoxAvecLecteurs();
            Delete_button1.Visible = false;
            Delete_button2.Visible = false;
            Delete_button3.Visible = false;
            Delete_button4.Visible = false;
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        private void RemplirComboBoxAvecLecteurs()
        {
            Disk.Items.Clear();
            Disk.Items.Add("Select your disk");
            DriveInfo[] lecteurs = DriveInfo.GetDrives();
            foreach (DriveInfo lecteur in lecteurs)
            {
                if (lecteur.IsReady && (lecteur.DriveType == DriveType.Fixed || lecteur.DriveType == DriveType.Removable))
                {
                    string nomLecteur = string.IsNullOrEmpty(lecteur.VolumeLabel) ? lecteur.Name : $"{lecteur.Name} ({lecteur.VolumeLabel})";
                    Disk.Items.Add(nomLecteur);
                }
            }
            Disk.SelectedIndex = 0;
        }
        private void Disk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstSelection && Disk.SelectedItem.ToString() == "Select your disk")
            {
                firstSelection = false;
                return;
            }

            string lecteurSelectionne = Disk.SelectedItem as string;
            if (!string.IsNullOrEmpty(lecteurSelectionne))
            {
                // Extract the drive letter from the selected drive string
                string driveLetter = Path.GetPathRoot(lecteurSelectionne);
                cheminDossier = Path.Combine(driveLetter, "atmosphere", "");
                Console.WriteLine("Chemin du dossier atmosphere/exefs_patches : " + cheminDossier);

                if (Directory.Exists(cheminDossier))
                {
                    MessageBox.Show("Atmosphere folder detected", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image = Properties.Resources.switch_check;
                    BootLogo_Button.Enabled = true;
                    Background_hbmenu_Button.Enabled = true;
                    Background_hekate_Button.Enabled = true;
                    Hekate_button.Enabled = true;
                    Create_button.Enabled = true;
                }
                else
                {
                    if (lecteurSelectionne != "Select your disk")
                    {
                        MessageBox.Show("Atmosphere folder not detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pictureBox1.Image = Properties.Resources.switch_nocheck;
                    BootLogo_Button.Enabled = false;
                    Background_hbmenu_Button.Enabled = false;
                    Background_hekate_Button.Enabled = false;
                    Hekate_button.Enabled = false;
                    Create_button.Enabled = false;
                }
            }
        }


        private void BootLogo_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tous les fichiers|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image originalImage = Image.FromFile(imagePath);
                if (Path.GetExtension(imagePath).Equals(".png", StringComparison.OrdinalIgnoreCase))
                {
                    Bitmap blackBackgroundImage = new Bitmap(308, 350);
                    using (Graphics g = Graphics.FromImage(blackBackgroundImage))
                    {
                        g.Clear(Color.Black);
                        g.DrawImage(originalImage, 0, 0, 308, 350);
                    }
                    bootlogo_final_pictureBox.Image = blackBackgroundImage;
                }
                else
                {
                    bootlogo_final_pictureBox.Image = ResizeImage(originalImage, 308, 350);
                }
                bootlogo_original_pictureBox.Image = originalImage;
            }
            Delete_button4.Visible = true;
        }
        private void Background_hbmenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_Background_hbmenu_pictureBox = new OpenFileDialog();
            openFileDialog_Background_hbmenu_pictureBox.Filter = "Fichiers image|*.jpg;*.jpeg;*.bmp|Tous les fichiers|*.*";
            if (openFileDialog_Background_hbmenu_pictureBox.ShowDialog() == DialogResult.OK)
            {
                string imagePath_Background_hbmenu_pictureBox = openFileDialog_Background_hbmenu_pictureBox.FileName;
                Image image_Background_hbmenu_pictureBox = Image.FromFile(imagePath_Background_hbmenu_pictureBox);
                Background_hbmenu_pictureBox.Image = image_Background_hbmenu_pictureBox;
                Delete_button1.Visible = true;
            }
        }
        private void Background_hekate_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_Background_hekate_pictureBox = new OpenFileDialog();
            openFileDialog_Background_hekate_pictureBox.Filter = "Fichiers image|*.jpg;*.jpeg;*.bmp|Tous les fichiers|*.*";
            if (openFileDialog_Background_hekate_pictureBox.ShowDialog() == DialogResult.OK)
            {
                string imagePath_Background_hekate_pictureBox = openFileDialog_Background_hekate_pictureBox.FileName;
                Image image_Background_hekate_pictureBox = Image.FromFile(imagePath_Background_hekate_pictureBox);
                Background_hekate_pictureBox.Image = image_Background_hekate_pictureBox;
                Delete_button2.Visible = true;
            }
        }
        private void Fusee_ams_launch_hekate_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_Fusee_ams_launch_hekate_pictureBox = new OpenFileDialog();
            openFileDialog_Fusee_ams_launch_hekate_pictureBox.Filter = "Fichiers image|*.jpg;*.jpeg;*.bmp|Tous les fichiers|*.*";
            if (openFileDialog_Fusee_ams_launch_hekate_pictureBox.ShowDialog() == DialogResult.OK)
            {
                string imagePath_Fusee_ams_launch_hekate_pictureBox = openFileDialog_Fusee_ams_launch_hekate_pictureBox.FileName;
                Image image_Fusee_ams_launch_hekate_pictureBox = Image.FromFile(imagePath_Fusee_ams_launch_hekate_pictureBox);
                SplashScreen_pictureBox.Image = image_Fusee_ams_launch_hekate_pictureBox;
            }
            Delete_button3.Visible = true;
        }
        private void SaveImageAsBMP(Image image, string filePath, int width, int height)
        {
            Image resizedImage = ResizeImage(image, width, height);
            resizedImage.Save(filePath, ImageFormat.Bmp);
        }
        private Image ResizeImageWithBlackBackground(Image image, Size newSize)
        {
            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                if (image.PixelFormat == PixelFormat.Format32bppArgb)
                {
                    gr.Clear(Color.Black);
                }
                gr.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }
        private void SaveImage(Image image, string filePath)
        {
            image.Save(filePath, ImageFormat.Bmp);
        }
        private Image ResizeAndRotateImage(Image image, int width, int height, float angle)
        {
            Image resizedImage = ResizeImage(image, width, height);
            Image rotatedImage = RotateImage(resizedImage, angle);
            return rotatedImage;
        }
        private Image RotateImage(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.TranslateTransform((float)rotatedImage.Width / 2, (float)rotatedImage.Height / 2);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-(float)rotatedImage.Width / 2, -(float)rotatedImage.Height / 2);
                graphics.DrawImage(image, new Point(0, 0));
            }
            return rotatedImage;
        }
        private void Create_button_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Background_hbmenu_pictureBox.Image == null &&
                Background_hekate_pictureBox.Image == null &&
                bootlogo_original_pictureBox.Image == null &&
                SplashScreen_pictureBox.Image == null)
            {
                MessageBox.Show("Please insert one or more images.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Disk.SelectedItem != null)
            {
                string selectedDrive = Disk.SelectedItem.ToString();
                string driveLetter = Path.GetPathRoot(selectedDrive);
                string resDirectoryPath = Path.Combine(driveLetter, "bootloader", "res");

                if (!Directory.Exists(resDirectoryPath))
                {
                    Directory.CreateDirectory(resDirectoryPath);
                }

                if (Background_hekate_pictureBox.Image != null)
                {
                    Image image = Background_hekate_pictureBox.Image;
                    Image newImage = new Bitmap(1280, 720);
                    using (Graphics g = Graphics.FromImage(newImage))
                    {
                        g.DrawImage(image, 0, 0, 1280, 720);
                    }
                    string backgroundImagePath = Path.Combine(resDirectoryPath, "background.bmp");
                    newImage.Save(backgroundImagePath, ImageFormat.Bmp);
                    newImage.Dispose();
                    MessageBox.Show("L'image a été convertie et enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (SplashScreen_pictureBox.Image != null)
                {
                    string bootLogoPath = Path.Combine(resDirectoryPath, "bootlogo.bmp");
                    using (Bitmap bmp = new Bitmap(SplashScreen_pictureBox.Image, new Size(1280, 720)))
                    {
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        bmp.Save(bootLogoPath, ImageFormat.Bmp);
                    }
                    MessageBox.Show("Image convertie et sauvegardée avec succès !");
                }

                if (bootlogo_final_pictureBox.Image != null)
                {
                    string atmosphereExefsPatchesPath = Path.Combine(driveLetter, "atmosphere", "exefs_patches");
                    string logoFolderPath = Path.Combine(atmosphereExefsPatchesPath, "logo");
                    string backupFolderPath = Path.Combine(atmosphereExefsPatchesPath, "backup_logo");

                    // Backup existing files in the logo folder
                    if (Directory.Exists(logoFolderPath))
                    {
                        if (Directory.Exists(backupFolderPath))
                        {
                            Directory.Delete(backupFolderPath, true);
                        }
                        Directory.CreateDirectory(backupFolderPath);

                        foreach (string filePath in Directory.GetFiles(logoFolderPath))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string backupFilePath = Path.Combine(backupFolderPath, fileName);
                            File.Move(filePath, backupFilePath);
                        }
                    }

                    Directory.CreateDirectory(logoFolderPath);

                    Image imageRedimensionnee = ResizeImageWithBlackBackground(bootlogo_final_pictureBox.Image, new Size(308, 350));
                    string cheminImage = Path.Combine(Application.StartupPath, "logo.png");
                    imageRedimensionnee.Save(cheminImage, System.Drawing.Imaging.ImageFormat.Png);

                    string arguments = $"\"{logoFolderPath}\" \"{cheminImage}\"";
                    string projectDirectory = System.IO.Directory.GetCurrentDirectory();
                    string fullPath = System.IO.Path.Combine(projectDirectory, "gen_patches.exe");
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = fullPath;
                    startInfo.Arguments = arguments;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    using (Process process = Process.Start(startInfo))
                    {
                        if (process.Start())
                        {
                            if (startInfo.RedirectStandardOutput)
                            {
                                using (System.IO.StreamReader reader = process.StandardOutput)
                                {
                                    string result = reader.ReadToEnd();
                                    Console.WriteLine(result);
                                }
                            }
                            process.WaitForExit();
                        }
                    }
                    File.Delete(cheminImage);
                    MessageBox.Show("Conversion terminée. Le dossier 'logo' a été créé dans le chemin spécifié.");
                }

                if (Background_hbmenu_pictureBox.Image != null)
                {
                    Image image = Background_hbmenu_pictureBox.Image;
                    Image newImage = new Bitmap(image, new Size(1280, 720));
                    string themeFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "theme");
                    string assetsFolder = Path.Combine(themeFolder, "assets");
                    Directory.CreateDirectory(assetsFolder);
                    string backgroundImagePath = Path.Combine(assetsFolder, "background.jpg");
                    newImage.Save(backgroundImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    string hactoolnetFolder = AppDomain.CurrentDomain.BaseDirectory;
                    string hactoolnetPath = Path.Combine(hactoolnetFolder, "hactoolnet.exe");
                    string themeFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "theme");
                    string selectedDriveLetter = driveLetter;
                    string themesFolderPath = Path.Combine(selectedDriveLetter, "config", "nx-hbmenu", "themes");
                    string themeRomfsPath = Path.Combine(themesFolderPath, "custom.romfs");
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = hactoolnetPath;
                    startInfo.Arguments = $"-t romfsbuild \"{themeFolderPath}\" --outfile \"{themeRomfsPath}\"";
                    File.Delete(backgroundImagePath);
                    try
                    {
                        using (Process process = Process.Start(startInfo))
                        {
                            process.WaitForExit();
                            if (process.ExitCode == 0)
                            {
                                MessageBox.Show("Le fichier custom.romfs a été créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Une erreur est survenue lors de la création du fichier custom.romfs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }


        private void Hekate_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_Hekate_pictureBox = new OpenFileDialog();
            openFileDialog_Hekate_pictureBox.Filter = "Fichiers image|*.jpg;*.jpeg;*.bmp|Tous les fichiers|*.*";
            if (openFileDialog_Hekate_pictureBox.ShowDialog() == DialogResult.OK)
            {
                string imagePath_Hekate_pictureBox = openFileDialog_Hekate_pictureBox.FileName;
                Image image_Hekate_pictureBox = Image.FromFile(imagePath_Hekate_pictureBox);
                SplashScreen_pictureBox.Image = image_Hekate_pictureBox;
                Delete_button3.Visible = true;
            }
        }
        private void Delete_button1_Click(object sender, EventArgs e)
        {
            Background_hbmenu_pictureBox.Image = null;
            Delete_button1.Visible = false;
        }
        private void Delete_button2_Click(object sender, EventArgs e)
        {
            Background_hekate_pictureBox.Image = null;
            Delete_button2.Visible = false;
        }
        private void Delete_button3_Click(object sender, EventArgs e)
        {
            SplashScreen_pictureBox.Image = null;
            Delete_button3.Visible = false;
        }
        private void Delete_button4_Click(object sender, EventArgs e)
        {
            bootlogo_original_pictureBox.Image = null;
            bootlogo_final_pictureBox.Image = null;
            Delete_button4.Visible = false;
        }

    }
}