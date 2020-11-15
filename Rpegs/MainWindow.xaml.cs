using Rpegs.Items;
using Rpegs.Entities;
using System;
using System.Windows;
using Rpegs.Entities.Player;
using Rpegs.Entities.Npcs;

namespace Rpegs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        Robber bandit;
        public MainWindow()
        {
            InitializeComponent();
            player = new Player
            {
                Name = "tester",
                Health = 100,
                Protection = 0,
                CarriedWeight = 50,
                ExpThresold = 1000,
                Level = 1,
                Experience = 0
            };

            bandit = new Robber();
            player.Equip(new Colt(), true);
            player.Equip(new Marauder(), false);

            for (int i = 0; i < player.Inventory.Chunks.Count; i++)
            {
                for(int di = 0; di < player.Inventory.Chunks[i].Items.Count; di++)
                {
                    InventoryGrid.Items.Add(player.Inventory.Chunks[i].Items[di]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bandit = new Robber();
            AttackBTN.IsEnabled = true;
            TextLog.Text += $"{bandit.Name} появился!\n";
            MessageBox.Show(player.Experience.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //In method
            if (!bandit.Dead && !player.Dead)
            {                 
                bandit.ReceiveDamage(player.Damage);
                player.ReceiveDamage(bandit.Damage);
                TextLog.Text += $"{player.Name} нанес: {player.Damage} \n{bandit.Fraction}:{bandit.Name} остался с {bandit.Health}HP \n" +
                                $"{player.Name} остается с: {player.Health}HP\n";
            }

            if (player.Dead)
            {
                TextLog.Text += $"{player.Name} умирает\n";
                AttackBTN.IsEnabled = false;
            }

            if(bandit.Dead)
            {
                TextLog.Text += $"{bandit.Name} умирает\n";
                player.ReceiveExperience(bandit, player);
                bandit = null;
                AttackBTN.IsEnabled = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            player.Equip(null, true);
        }
    }
}
