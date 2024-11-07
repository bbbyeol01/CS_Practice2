using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Coffee_Kiosk.Model;
using MySql.Data.MySqlClient;

namespace Coffee_Kiosk.Repository
{
    public class MenuRepository
    {
        DatabaseManager databaseManager = new DatabaseManager();

        public DrinkInfo getDrinkInfo(int drinkIdx)
        {
            DrinkInfo drinkInfo = new DrinkInfo();

            MySqlConnection connection = null;
            MySqlDataReader reader = null;

            drinkInfo.Idx = drinkIdx;

            try
            {
                connection = databaseManager.GetConnection();
                string query = "SELECT name, price, image, category, `description` FROM menu WHERE idx = @idx";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idx", drinkIdx);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        drinkInfo.Name = reader["name"].ToString();
                        drinkInfo.Price = int.Parse(reader["price"].ToString());
                        drinkInfo.Category = reader["category"].ToString();
                        drinkInfo.Description = reader["description"].ToString();
                        drinkInfo.DrinkInfoImage = reader["image"].ToString();
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // 에러 메시지 출력
            }
            finally
            {
                reader?.Close();
            }

            List<string> types = getTypes(drinkIdx);
            types.Sort();  // 타입 정렬
            drinkInfo.Types = types;

            return drinkInfo;
        }

        public List<DrinkInfo> getMenuByCategory(string category)
        {
            List<DrinkInfo> menu = new List<DrinkInfo>();

            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                connection = databaseManager.GetConnection();
                string query = "SELECT idx, name, price, image FROM menu WHERE category = @category";

                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@category", category);

                reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int idx = int.Parse(reader["idx"].ToString());
                        string name = reader["name"].ToString();
                        int price = int.Parse(reader["price"].ToString());
                        string image = reader["image"].ToString();
                        // 메뉴에 각 아이템 추가 (타입은 아직 넣지 않음)
                        menu.Add(new DrinkInfo(idx, name, price, image, category, new List<string>()));

                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // 에러 메시지 출력
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
            }

            // 메뉴에 각 아이템에 해당하는 타입 리스트 추가
            foreach (DrinkInfo item in menu)
            {
                List<string> types = getTypes(item.Idx);  // item.Item1은 idx를 의미함
                item.Types.AddRange(types);  // 타입 리스트 추가
            }

            return menu;
        }

        public List<string> getTypes(int menuIdx)
        {
            List<string> types = new List<string>();
            MySqlConnection connection = null;
            MySqlDataReader reader = null;

            try
            {
                connection = databaseManager.GetConnection();
                string query = "SELECT type FROM drink_type WHERE menu_idx = @menu_idx";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@menu_idx", menuIdx);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        types.Add(reader["type"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // 에러 메시지 출력
            }
            finally
            {
                reader?.Close();
            }

            types.Sort();  // 타입 정렬
            return types;
        }

      
        public string getDesc(int idx)
        {
            string desc = "";

            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                connection = databaseManager.GetConnection();
                string query = $"SELECT description FROM menu WHERE idx = @idx";

                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idx", idx);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    desc = reader["description"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd?.Dispose();
                reader?.Close();

            }

            return desc;
        }

        public List<(string, int)> getOptions()
        {
            List<(string, int)> options = new List<(string, int)>();
            MySqlConnection connection = null;


            try
            {
                connection = databaseManager.GetConnection();
                string query = "SELECT name, price FROM drink_option";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        int price = int.Parse(reader["price"].ToString());
                        options.Add((name, price));
                    }
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return options;
        }
    }
}
