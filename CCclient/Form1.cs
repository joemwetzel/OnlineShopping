using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSurf_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 38);
            switch (randomNumber)
            {
                case 1:
                    wbSurf.Navigate("http://taint.org/xfer/2006/This%20copy%20of%20Windows%20is%20not%20genuine.jpg");
                    break;
                case 2:
                    wbSurf.Navigate("http://nadeemweb.ucoz.com/_bl/0/02755.jpg");
                    break;
                case 3:
                    wbSurf.Navigate("http://wallpapersus.com/wallpapers/2012/01/children-hacker-children-hacker-funny-computer-768x1024.jpg");
                    break;
                case 4:
                    wbSurf.Navigate("http://3.bp.blogspot.com/-JVgaC4RiHKY/TgQvhBeRJHI/AAAAAAAAAGQ/QsVIdu_NzKk/s1600/untitled.JPG");
                    break;
                case 5:
                    wbSurf.Navigate("http://blyon.com/blyon-cdn/blogimg/digital_assassination.jpg");
                    break;
                case 6:
                    wbSurf.Navigate("http://frontview.files.wordpress.com/2012/04/hacker_wallpaper_by_vanilla23.jpg");
                    break;
                case 7:
                    wbSurf.Navigate("http://lygsbtd.files.wordpress.com/2012/05/squirrel_hacker_wallpaper__yvt2.jpg");
                    break;
                case 8:
                    wbSurf.Navigate("http://nmap.org/movies/matrix/access_granted.jpg");
                    break;
                case 9:
                    wbSurf.Navigate("http://www.konbini.com/en/files/2012/09/Linux-Hacker-1024x768-Wallpaper-Desktop-Crack-The-Code.jpeg");
                    break;
                case 10:
                    wbSurf.Navigate("http://files.broadsheet.ie/wp-content/uploads/2012/02/hacked11copy.jpg");
                    break;
                case 11:
                    wbSurf.Navigate("http://1.bp.blogspot.com/-EpBISb8tQL0/T-R02GWBSEI/AAAAAAAAAmg/x14nQb9WwHU/s1600/System-Fehler-Matrix-Hacker-Neo-Morpheus-Trinity-Fussball-Sport-2012-Maya-Bla-xxx-Morphogenetik-Der-hunderte-Affe-Anti-Illuminati-Ahoi.jpg");
                    break;
                case 12:
                    wbSurf.Navigate("http://free.desktopwallpaper.org/3_code-matrix-944969.jpeg");
                    break;
                case 13:
                    wbSurf.Navigate("http://www.wallpapersas.com/wallpapers/2013/01/Hacker-Geeks-768x1024.jpg");
                    break;
                case 14:
                    wbSurf.Navigate("http://4.bp.blogspot.com/-oA6EazJBcB8/UJwHU_sMbXI/AAAAAAAAAfo/XN3A3iRlD-w/s1600/87767-1024x768-hack.jpg");
                    break;
                case 15:
                    wbSurf.Navigate("http://images.alphacoders.com/107/1024-768-10711.jpg");
                    break;
                case 16:
                    wbSurf.Navigate("http://free-hdwallpapers.com/wallpapers/technology/3339.jpg");
                    break;
                case 17:
                    wbSurf.Navigate("http://www.pawsru.org/m/src/m56778_fc102680_Spongebob_u_mad.jpg");
                    break;
                case 18:
                    wbSurf.Navigate("http://hangma.oneminutesite.it/files/29-Hacker_3D_arte.jpg");
                    break;
                case 19:
                    wbSurf.Navigate("http://2.bp.blogspot.com/-XyupOe-yVT0/TsCIOag65TI/AAAAAAAABkE/gnDiTXgqVJ8/s1600/grim-reaper.jpg");
                    break;
                case 20:
                    wbSurf.Navigate("http://www.tofuhaus.com/images/t/1024x768/27453-central-hacker-indexes-hd-1024x768.jpg");
                    break;
                case 21:
                    wbSurf.Navigate("http://woondu.com/images/funny/funny_road_signs/funny_road_signs_9.jpg");
                    break;
                case 22:
                    wbSurf.Navigate("http://4.bp.blogspot.com/-VJ9jwmHgZCI/TyoLWxb6w4I/AAAAAAAAAts/EH9i7_BAJjo/s1600/Sign_Board_Confusion_1024x768_42.jpeg");
                    break;
                case 23:
                    wbSurf.Navigate("http://cdn2.holytaco.com/wp-content/uploads/images/2009/burgerking_sign_0.jpg");
                    break;
                case 24:
                    wbSurf.Navigate("http://www.hdwallpapersdesktop.com/Humor/Funny-Wallpapers/images/Funny%20wallpapers%20Radioactive%20Clown%2014166%20.jpg");
                    break;
                case 25:
                    wbSurf.Navigate("http://www.wallpapers63.com/desktop-wallpapers/funny/wallpapers/funny-wallpaper-003.jpg");
                    break;
                case 26:
                    wbSurf.Navigate("http://www.scenicreflections.com/files/Funny_Skull_Wallpaper_8yg8i.jpg");
                    break;
                case 27:
                    wbSurf.Navigate("http://i.imgur.com/5m5qQ.jpg");
                    break;
                case 28:
                    wbSurf.Navigate("http://www.upphotos.net/wallpapers/2013/04/How-Kill-Zombie-768x1024.jpg");
                    break;
                case 29:
                    wbSurf.Navigate("http://www.wallpapers-online.net/wallpapers/2013/01/Zombie-headphones-glasses-smile-teeth-768x1024.jpg");
                    break;
                case 30:
                    wbSurf.Navigate("http://www.glitters20.com/quotes/wp-content/uploads/2012/11/Funny-Scary-66.png");
                    break;
                case 31:
                    wbSurf.Navigate("http://www.zombieapocalypsesurvivalworkout.org/wp-content/uploads/2012/12/Zombies.jpg");
                    break;
                case 32:
                    wbSurf.Navigate("http://openwalls.com/image/14066/have_a_nice_day_1024x768.jpg");
                    break;
                case 33:
                    wbSurf.Navigate("http://cdn.ebaumsworld.com/mediaFiles/picture/538442/828748.jpg");
                    break;
                case 34:
                    wbSurf.Navigate("http://krypt3ia.files.wordpress.com/2011/07/matrix-shinobi.jpg");
                    break;
                case 35:
                    wbSurf.Navigate("http://cdn2.planetminecraft.com/files/resource_media/screenshot/1231/free_wallpaper_hackerbasis_3149503.jpg");
                    break;
                case 36:
                    wbSurf.Navigate("http://i407.photobucket.com/albums/pp156/Tr1stan1a/Yin-Yarr.jpg");
                    break;
                case 37:
                    wbSurf.Navigate("http://archive09.linux.com/var/uploads/Image/articles/138325-1(1).png");
                    break;
            }
           
        }

        private void tmrCC_Tick(object sender, EventArgs e)
        {
            lblProcessing.Text = "Credit Card Processing";
            Application.DoEvents();
            System.Threading.Thread.Sleep(5000);
            Application.DoEvents();
            //call webservice
            Random random = new Random();
            int NumberA = random.Next(1, 99);
            int NumberB = random.Next(1, 99);
            string strCash = NumberA.ToString() + "." + NumberB.ToString();
            decimal Cash = Convert.ToDecimal(strCash);
            PayPal.MerchantService Payment = new PayPal.MerchantService();
            var xxx = Payment.Deposit("8520", "Mastercard", "8547-8569-6325-4521", DateTime.Today, Cash);
            Application.DoEvents();
            System.Threading.Thread.Sleep(5000);
            Application.DoEvents();
            lblProcessing.Text = "";
        }
    }
}
