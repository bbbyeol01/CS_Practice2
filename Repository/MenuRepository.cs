using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Coffee_Kiosk.Repository
{
    public class MenuRepository
    {
        DatabaseManager databaseManager = new DatabaseManager();


        public List<(int, string, string, string, List<string>)> getMenuByCategory(string category)
        {
            List<(int, string, string, string, List<string>)> menu = new List<(int, string, string, string, List<string>)>();

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
                    string price = $"{reader["price"].ToString()}원";
                    string image = reader["image"].ToString();

                    // 메뉴에 각 아이템 추가 (타입은 아직 넣지 않음)
                    menu.Add((idx, name, price, image, new List<string>()));
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
            foreach (var item in menu)
            {
                List<string> types = getTypes(item.Item1);  // item.Item1은 idx를 의미함
                item.Item5.AddRange(types);  // 타입 리스트 추가
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

      
        public string getDesc(string name)
        {
            string desc = "";

            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                connection = databaseManager.GetConnection();
                string query = $"SELECT description FROM menu WHERE name = @name"; // AND branch = @branch

                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    desc = reader["description"].ToString();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
               

            }

            return desc;
        }

        public List<(string, string)> getOptions()
        {
            List<(string, string)> options = new List<(string, string)>();
            MySqlConnection connection = null;


            try
            {
                string query = "SELECT name, price FROM drink_option";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string price = reader["price"].ToString();
                        options.Add((name, price));
                    }
                }

            }catch(Exception ex)
            {

            }

            return options;
        }
    }
}
