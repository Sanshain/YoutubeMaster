using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using System.Threading;
using VideoLibrary;
using Newtonsoft.Json;
using System.Diagnostics;
using YoutubeLoader;

namespace YoutubeFine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string default_source = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            default_source = sourcePath.Text;

            sourcePath.Text = YoutubeLoader.Properties.Settings.Default.lastPath;
            sourcePath.GotFocus += Source_btn_GotFocus;
            sourcePath.LostFocus += Source_LostFocus;

            sourceText.GotFocus += SourceText_GotFocus;
        }

        private void SourceText_GotFocus(object sender, EventArgs e)
        {
            if (sourcePath.Text == default_source)
            {
                sourcePath.Text = "";
                sourcePath.ForeColor = Color.Black;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            YoutubeLoader.Properties.Settings.Default.lastPath = sourcePath.Text;
        }


        string folderPath = string.Empty;

        private async void startButton_Click(object sender, EventArgs e) //
        {
            flag = true;

            if (File.Exists(sourcePath.Text) || (sourceText.Text != "" && sourceText.Text != default_source))
            {

                using (var dialog = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog())
                {
                    dialog.Description = "Выберите директорию назначения для скачивания файлов";
                    dialog.UseDescriptionForTitle = true;
                    
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        folderPath = dialog.SelectedPath;
                    }
                    else return;
                }

                startButton.Enabled = false;

                stopButton.Visible = true;

                progressState.Show();
                progressState.Value = 0;

                openDir.Show();


                string source = sourceText.Text;

                
                //new Thread(() => { Scope_Save(source, folderPath, ref flag); }).Start();;//*/


                LogFunc = (s) => statusView.AppendText(s);
                //await Task.Run(() => Scope_Save(sourceText.Text, folderPath, Log, ref flag)); //раб, но неуд-но


                // на момент Invoke текущий поток полностью блокирует поток, 
                // которому принадлжеит объект, вызвавший этот Invoke ((

                await Task.Factory.StartNew(
                    () => Scope_Save(source, folderPath, ref flag),   TaskCreationOptions.LongRunning
                );//*/

                //await Task.Run(() => Scope_Save(sourceText.Text, folderPath, statusView, ref flag)); //?so?

                startButton.Enabled = true;
                startButton.Text = "Вперед";
                progressState.Hide();
                stopButton.Visible = false;
                openDir.Hide();

                MessageBox.Show("Complete");
            }
            else 
            {
                MessageBox.Show("Указанный файл не существует. Укажите верный путь либо список");

                //sourcePath.SelectionStart = 0;
                //sourcePath.SelectionLength = sourcePath.Text.Length;
                sourcePath.Focus();
            }
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            flag = false;

            var pos = this.statusView.Text.LastIndexOf("https");

            var len = this.statusView.Text.IndexOf(" download", pos) - pos;

            var lastVideo = this.statusView.Text.Substring(pos, len);

            statusView.AppendText(
                Environment.NewLine + $"Отправлено сообщение об остановке. Докачивается последнее ({lastVideo})");

            YoutubeLoader.Properties.Settings.Default.LastVideo = lastVideo;
            YoutubeLoader.Properties.Settings.Default.Save();
        }








        //move to independent split individual control:
        

        string defaulttext = "Введите название файла с данными (полный путь)";      //"Enter source path here...";

        private void Source_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sourcePath.Text))
            {
                sourcePath.ForeColor = Color.LightGray;
                sourcePath.Text = defaulttext;
            }
            else
            {
                if (File.Exists(sourcePath.Text))
                {
                    sourcePath.ForeColor = Color.Black;
                    var source_text = File.ReadAllText(sourcePath.Text);
                    sourceText.Text = source_text
                        .Replace("u'", Environment.NewLine + '"')
                        .Replace("'", "\"")
                        .Replace(": [", ":" + Environment.NewLine + "[")
                        .Replace("}", Environment.NewLine + "}")
                        .Replace("\"https", "    \"https");
                }
                else
                    sourcePath.ForeColor = Color.Red; 
            }
        }

        private void Source_btn_GotFocus(object sender, EventArgs e)
        {
            if (sourcePath.Text == defaulttext)
            {
                sourcePath.Text = "";
            }            
        }











        //move to independent split individual class:

        Action<string> LogFunc;

        Nullable<Boolean> flag = true;

        void Scope_Save(string source, string path, ref bool? _flag, RichTextBox logText = null)
        {

            

            Dictionary<string, List<string>> mobj = null;
            var robj = new List<string>(200);
            try
            {
                mobj = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(sourceText.Text);
                if (logText != null)  logText.Text += Environment.NewLine + "JSON десериализован";
            }
            catch
            {                

                robj.AddRange(source.Split('\n'));

                var nsg = Environment.NewLine + " Читаем построчно (поскольку требуемый формат json не соблюден):";

                statusView.Invoke((Action)(() => 
                {
                    statusView.AppendText(nsg + Environment.NewLine + Environment.NewLine);
                    SetColorText(nsg, Color.Gray);
                }));

                

                if (logText != null) logText.Invoke((Action)(() => logText.AppendText("Не распознан json вида")));

                if (logText != null) logText.Text += "Не распознан json вида {\"folder_name\":[\"link1\",\"link2\",...]}";
                if (logText != null) logText.Text += Environment.NewLine + "Читаем построчно:";
            }

            object source_obj = (object)mobj ?? robj;

            string start = "";

            if (!string.IsNullOrEmpty(YoutubeLoader.Properties.Settings.Default.LastVideo))
            {
                if (source.IndexOf(YoutubeLoader.Properties.Settings.Default.LastVideo) > 0)
                {
                    var r =  MessageBox.Show("Указанный список уже скачивался. Нажмите ДА, чтобы продолжить" +
                        " либо НЕТ, если желаете начать сначала", "", MessageBoxButtons.YesNo);

                    if (r == DialogResult.Yes) start = YoutubeLoader.Properties.Settings.Default.LastVideo;

                }
            }


            if (source_obj.GetType() == typeof(List<string>))
            {



                if (start.Length > 0)
                {
                    var pos = (source_obj as List<string>).IndexOf(start);
                    var sl = (source_obj as List<string>).GetRange(pos, (source_obj as List<string>).Count - pos);
                    multi_Save(sl, path, ref _flag);
                }

                multi_Save(source_obj as List<string>, path, ref _flag, true);
                
            }
            else
            {

                progressState.Invoke((Action)(() =>
                {
                    progressState.Maximum = (source_obj as Dictionary<string, List<string>>).Count;
                }));


                foreach (var item in (source_obj as Dictionary<string, List<string>>))
                {

                    progressState.Invoke((Action)(() =>
                    {
                        if (progressState.Value < progressState.Maximum) progressState.Value += 1;
                    }));


                    var sl = item.Value;

                    if (start.Length > 0)
                    {
                        var start_pos = item.Value.IndexOf(start);

                        if (start_pos < 0)
                            continue;
                        else
                        {
                            sl = item.Value.GetRange(start_pos, sl.Count - start_pos);
                            start = "";                        }
                    }                    

                    var dir_path = Path.Combine(path, item.Key).Replace('?', '.');

                    if (!System.IO.Directory.Exists(dir_path))
                    {
                        System.IO.Directory.CreateDirectory(dir_path);
                        if (logText != null) logText.Text += Environment.NewLine + "Создана папка "+ dir_path;
                    }

                    if (multi_Save(sl, dir_path, ref _flag)) break;                    

                }

                YoutubeLoader.Properties.Settings.Default.LastVideo = string.Empty;

            }

        }


        bool multi_Save(IEnumerable<string> list, string target, ref bool? _flag, bool pb = false)
        {

            if (pb) progressState.Invoke((Action)(() =>
            {
                progressState.Maximum = list.Count();
            }));

            foreach (var link in list)
            {
                if (!_flag.Value) return true;

                DateTime d = DateTime.Now;

                statusView.Invoke(LogFunc, String.Format("Start {0} download", link));

                Once_Save(link, target);

                var delta = DateTime.Now - d;

                statusView.Invoke((Action)(() =>
                    statusView.AppendText(
                        string.Format(
                            "{0}Finish {1} download for {2}{0}{0}", Environment.NewLine, link, delta))
                        ));

                startButton.Invoke((Action)(() => {
                    int val;
                    if (int.TryParse(startButton.Text, out val))
                    {
                        startButton.Text = (++val).ToString();
                    }
                    else startButton.Text = "0";

                }));

                if (pb) progressState.Invoke((Action)(() =>
                {
                    if (progressState.Value < progressState.Maximum) progressState.Value += 1;
                }));

                GC.Collect();
            }
            return false;
        }

        void Once_Save(string link, string target)
        {

            var youTube = YouTube.Default;              // starting point for YouTube actions

            //YouTubeVideo video = youTube.GetVideo(link);

            YouTubeVideo video = null;
            try
            {
                video = youTube.GetVideo(link);         // gets a Video object with info about the video                
            }
            catch
            {
                var mesg = string.Format(
                        "{0}Информация о видео недоступна в данной версии",
                        Environment.NewLine);

                statusView.Invoke(LogFunc, mesg );

                statusView.Invoke((Action)(() => SetColorText(mesg, Color.Red)));

                return;
            }



            //var videos = youTube.GetAllVideos(link);

            string msg = Environment.NewLine + "Получены заголовки о видео";
            statusView.Invoke(LogFunc, msg);


            statusView.Invoke((Action)(() => SetColorText(msg, Color.Blue) ));


            /*
            int resolution = 0;

            if (resolution > 0)
            {
                video = videos.FirstOrDefault(v => v.Resolution == resolution);
            }
            else if (resolution == 0)
            {
                //video = videos.Max(r => r.resolution) //not work

                
                //var max_r = videos.Max(v => v.Resolution);
                //video = videos.First(v => v.Resolution == max_r);

                video = videos.OrderBy(v => v.Resolution).Last();
            }
            else
            {
                video = videos.Where(v => v.Resolution < -resolution).OrderBy(v => v.Resolution).Last();
                //минимальнео от заданного
            }//*/


            //Получить случайное число (в диапазоне от 0 до 10)
            int wait = new Random().Next(500, 5000);

            statusView.Invoke(LogFunc, Environment.NewLine + $"Waiting for {wait} sec");

            Thread.Sleep(wait);


            try
            {

                var filename = Path.Combine(target, video.FullName);

                if (!File.Exists(filename))
                {
                  

                    File.WriteAllBytes(filename, video.GetBytes());
                }
                else
                {
                    string mess = string.Format("{0}Skip the file whereas exists", Environment.NewLine);

                    statusView.Invoke(LogFunc, mess);

                    statusView.Invoke((Action)(() => SetColorText(mess, Color.Green)));
                }

                
            }
            catch(Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine + $"Ошибка: `{ex.Message}`");

                var mesg = $"Видео с текущим заголовком не поддерживается ({ex.Message})";

                statusView.Invoke(LogFunc, Environment.NewLine + mesg);

                statusView.Invoke((Action)(() => SetColorText(mesg, Color.Red)));

            }

                        
        }

        private void SetColorText(string msg, Color color)
        {
            statusView.SelectionStart = statusView.TextLength - (msg.Length-1);
            statusView.SelectionLength = msg.Length;
            statusView.SelectionColor = color;
            statusView.SelectionStart = statusView.TextLength;
            statusView.SelectionColor = Color.Black;
        }










        //move to independent split individual control:

        private void sourceText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (sender as RichTextBox).SelectionStart = 0;
                (sender as RichTextBox).SelectionLength = (sender as RichTextBox).Text.Length;
            }            
        }

        private void openDir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(folderPath)) Process.Start("explorer", folderPath);
        }



        private void showLogFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("log.txt")) Process.Start("log.txt");
            else MessageBox.Show("Логи пока не созданы");
        }

        private void deleteLogFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("log.txt")) File.Delete("log.txt");

            MessageBox.Show("Логи удалены");
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            var settings = new Youtube.SettingsForm();            
            settings.ShowDialog();
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            new Youtube.AboutBox().ShowDialog();
        }

        private void statusView_MouseDown(object sender, MouseEventArgs e)
        {
            sourceText_MouseDown(sender, e);
        }

        private void sourceText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                (new FindForm() { Owner = this }).ShowDialog();
            }
        }
    }

    
}
