using BassPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ui.Pages {
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl {
        private Properties.Configs BassConfigs = Properties.Configs.Default;

        public Home() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //BassAudioEngine player = new BassAudioEngine(BassConfigs.bass_email, BassConfigs.bass_regkey);
            //player.Play("file:///C:/Users/Public/Music/Sample Music/Kalimba.mp3");

            me.Play();
        }
    }
}
