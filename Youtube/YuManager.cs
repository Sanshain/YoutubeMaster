using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace Youtube
{
    class YuManager
    {

        public struct ExternStruct
        {
            public Button startButton;
            public ProgressBar progressState;
            public RichTextBox stateView;
            public Action LogFunc;
        }

        public static YuManager MultiSave(string _source, string _path, ref bool? _fl, ExternStruct option)
        {
            return new YuManager(_source, _path, ref _fl, option);
        }


        YuManager(string _src, string _pth, ref bool? _fl, ExternStruct option)
        {
            _flag = _fl;
            source = _src;
            path = _pth;

            progressState = option.progressState;
            statusView = option.stateView;
            LogFunc = option.LogFunc;
            startButton = option.startButton;
        }

        bool? _flag;
        string source;
        string path;

        Button startButton;
        RichTextBox statusView;
        ProgressBar progressState;
        Action LogFunc;

        public void Scope_Save()
        {

            Dictionary<string, List<string>> mobj = null;
            var robj = new List<string>(200);
            try
            {
                mobj = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(source);
                
            }
            catch
            {
                robj.AddRange(source.Split('\n'));


            }

            object source_obj = (object)mobj ?? robj;

            string start = "";

            if (!string.IsNullOrEmpty(YoutubeLoader.Properties.Settings.Default.LastVideo))
            {
                if (source.IndexOf(YoutubeLoader.Properties.Settings.Default.LastVideo) > 0)
                {
                    var r = MessageBox.Show("Указанный список уже скачивался. Нажмите ДА, чтобы продолжить" +
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
                    multi_Save(sl, path);
                }

                multi_Save(source_obj as List<string>, path);

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
                            sl = item.Value.GetRange(start_pos, sl.Count - start_pos);
                    }

                    var dir_path = Path.Combine(path, item.Key);

                    if (!System.IO.Directory.Exists(dir_path))
                    {
                        System.IO.Directory.CreateDirectory(dir_path);
                                                
                        statusView.Invoke(LogFunc, Environment.NewLine + "Создана папка " + dir_path);
                    }

                    if (multi_Save(sl, dir_path)) break;
                    else YoutubeLoader.Properties.Settings.Default.LastVideo = string.Empty;

                }

            }

        }


        bool multi_Save(IEnumerable<string> list, string target)
        {
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

                statusView.Invoke(LogFunc, mesg);

                statusView.Invoke((Action)(() => SetColorText(mesg, Color.Red)));

                return;
            }



            //var videos = youTube.GetAllVideos(link);

            string msg = Environment.NewLine + "Получены заголовки о видео";
            statusView.Invoke(LogFunc, msg);


            statusView.Invoke((Action)(() => SetColorText(msg, Color.Blue)));


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

            System.Threading.Thread.Sleep(wait);


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
            catch (Exception ex)
            {
                File.AppendAllText("log.txt", Environment.NewLine + $"Ошибка: `{ex.Message}`");

                var mesg = $"Видео с текущим заголовком не поддерживается ({ex.Message})";

                statusView.Invoke(LogFunc, Environment.NewLine + mesg);

                statusView.Invoke((Action)(() => SetColorText(mesg, Color.Red)));

            }


        }

        private void SetColorText(string msg, Color color)
        {
            statusView.SelectionStart = statusView.TextLength - (msg.Length - 1);
            statusView.SelectionLength = msg.Length;
            statusView.SelectionColor = color;
            statusView.SelectionStart = statusView.TextLength;
            statusView.SelectionColor = Color.Black;
        }
    }
}
