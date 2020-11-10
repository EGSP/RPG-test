using Rpegs.Items;
using Rpegs.NPCLogic;
using Rpegs.PlayerLogic;
using Rpegs.BodyParts;
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

namespace Rpegs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        Maradeur bandit;
        public MainWindow()
        {
            InitializeComponent();
            player = new Player
            {
                Name = "tester",
                Health = 100,
                Protection = 0,
                Damage = 10,
                CarriedWeight = 50,
                ExpThresold = 1000,
                Level = 1,
                Experience = 0
            };

            bandit = new Maradeur();
            player.Equip(new Colt(), true);

            for (int i = 0; i < player.inventory.chunks.Count; i++)
            {
                for(int di = 0; di < player.inventory.chunks[i].items.Count; di++)
                {
                    InventoryGrid.Items.Add(player.inventory.chunks[i].items[di]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bandit = new Maradeur();
            AttackBTN.IsEnabled = true;
            TextLog.Text += $"{bandit.Name} появился!\n";
            MessageBox.Show(player.Experience.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //In method
            try
            {
                if (!bandit.ReceiveDamage(player.Damage) && !player.ReceiveDamage(bandit.Damage))
                {                  
                    TextLog.Text += $"{player.Name} нанес: {player.Damage} \n{bandit.Fraction}:{bandit.Name} остался с {bandit.Health}HP \n" +
                        $"{player.Name} остается с: {player.Health}HP\n";
                }
                else if (player.ReceiveDamage(bandit.Damage))
                {
                    TextLog.Text += $"{player.Name} умирает\n";
                    AttackBTN.IsEnabled = false;
                }
                else if(bandit.ReceiveDamage(player.Damage))
                {
                    TextLog.Text += $"{bandit.Name} умирает\n";
                    player.ReceiveExperience(bandit, player);
                    bandit = null;
                    AttackBTN.IsEnabled = false;
                }
            }catch(Exception)
            {
                MessageBox.Show("No bandit located");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            player.Equip(null, true);
        }
    }
}
