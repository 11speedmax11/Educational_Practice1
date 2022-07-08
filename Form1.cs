using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Practice
{
    public partial class Format : Form
    {
      public Format()
      {
      InitializeComponent();
        
      }

      private void Reset_Click(object sender, EventArgs e)
      {
          Canon.Checked = false;
          Epson.Checked = false;
          Roland.Checked = false;
          Mimaki.Checked = false;
          HP.Checked = false;
          AZiroPlus.Checked = false;
          AZiro.Checked = false;
          AOne.Checked = false;
          ATwo.Checked = false;
          Inkjet.Checked = false;
          Latex.Checked = false;
          Textile.Checked = false;
          Solvent.Checked = false;
          Sublimation.Checked = false;
          Color.Checked = false;
          Monochrome.Checked = false;
          WiFiModule.Checked = false;
          WiFiDirect.Checked = false;
          AirPrint.Checked = false;
          USBPC.Checked = false;
          LAN.Checked = false;
          USBFlashDrive.Checked = false;
          Small.Checked = false;
          Medium.Checked = false;
          Large.Checked = false;
          Paper.Checked = false;
          Cloth.Checked = false;
          Raster.Checked = false;
          Graphics.Checked = false;
          Glow.Checked = false;
          OK.Checked = false;
          RPK.Checked = false;
          Nevsky.Checked = false;
          Less.Checked = false;
          More.Checked = false;
          Tshirts.Checked = false;
          Flags.Checked = false;
          Drawings.Checked = false;
          Placard.Checked = false;
          Posters.Checked = false;
          Banners.Checked = false;
      }

    public class MainTable
    {
      public string Model { get; set; }
      public string Producer { get; set; }
      public string Type { get; set; }
      public string Chroma { get; set; }
      public string Quantity { get; set; }
      public string Material { get; set; }
      public string Size { get; set; }
      public string Format { get; set; }
      public string PCConnection { get; set; }
      public string LANConnection { get; set; }
      public string FlashDriveConnection { get; set; }
      public string ModuleWIFI { get; set; }
      public string WIFIDirect { get; set; }
      public string AirPrint { get; set; }
      public int Price { get; set; }
      public string Factory { get; set; }
      public string Products { get; set; }
    }
    private void Selects_Click(object sender, EventArgs e)
    {
      Sizes_resources_used sizes_Resources_Used = new Sizes_resources_used();
      Chroma_models_uses chroma_Models_Uses = new Chroma_models_uses();
      Factories factories = new Factories();
      Max_roll_diameter_resources_used max_Roll_Diameter_Resources_Used = new Max_roll_diameter_resources_used();
      Models models = new Models();
      Producer_Models producers = new Producer_Models();
      Number_of_cartridges_used number_Of_Cartridges_Used = new Number_of_cartridges_used();
      Produced_products produced_Products = new Produced_products();
      Raw_materials raw_Materials = new Raw_materials();
      Type_models_uses type_Models_Uses = new Type_models_uses();
      Connections connections = new Connections();

      connections.CheckBoxes = new List<CheckBox>() { USBPC, LAN, USBFlashDrive, WiFiModule, WiFiDirect, AirPrint };
      producers.ListCheckBox = new List<CheckBox>() { Canon, Epson, Roland, Mimaki, HP };
      models.ListCheckBox = new List<NumericUpDown>() { numericUpDown1, numericUpDown2 };
      sizes_Resources_Used.ListCheckBox = new List<CheckBox>() { AZiroPlus, AOne, AZiro, ATwo };
      chroma_Models_Uses.ListCheckBox = new List<CheckBox>() { Monochrome, Color };
      factories.ListCheckBox = new List<CheckBox>() { Nevsky, RPK, OK, Glow, Graphics, Raster };
      max_Roll_Diameter_Resources_Used.ListCheckBox = new List<CheckBox>() { Less, More };
      number_Of_Cartridges_Used.ListCheckBox = new List<CheckBox>() { Small, Medium, Large };
      produced_Products.ListCheckBox = new List<CheckBox>() {Banners, Posters, Placard, Drawings, Flags, Tshirts };
      raw_Materials.ListCheckBox = new List<CheckBox>() {Paper, Cloth };
      type_Models_Uses.ListCheckBox = new List<CheckBox>() { Inkjet, Solvent, Sublimation, Textile, Latex };

      string condition = string.Empty;
      condition = models.GetStringFormat(condition);
      condition = sizes_Resources_Used.GetStringFormat(condition);
      condition = chroma_Models_Uses.GetStringFormat(condition);
      condition = factories.GetStringFormat(condition);
      condition = max_Roll_Diameter_Resources_Used.GetStringFormat(condition);
      condition = number_Of_Cartridges_Used.GetStringFormat(condition);
      condition = produced_Products.GetStringFormat(condition);
      condition = raw_Materials.GetStringFormat(condition);
      condition = type_Models_Uses.GetStringFormat(condition);
      condition = producers.GetStringFormat(condition);
      condition = connections.GetStringFormat(condition);

      List<MainTable> list = new List<MainTable>();
      var connection = method.connection();
      string @base = "CREATE TEMPORARY TABLE `tmp_table` select models_title, models_producer_title, type_models_uses_type, chroma_models_uses_chroma, number_of_cartridges_models_used_number_of_cartridges, " +
                "max_roll_diameter_resources_size, raw_mat_title, sizes_resources_used_size, USB_connection_for_PC, LAN_connection, USB_connection_to_flash_drive, module_WIFI, WIFI_direct, Air_print, proc_mat_price, factory_title, models_used.factory_id, models_used.model_id from models_used " +
                "inner join models on models_id = model_id " +
                "inner join sizes_resources_used on sizes_resources_used.sizes_resources_used_id = models_used.sizes_resources_used_id " +
                "inner join raw_materials on raw_materials.raw_mat_id = models_used.raw_mat_id " +
                "inner join factories on factories.factory_id = models_used.factory_id " +
                "inner join max_roll_diameter_resources_used on max_roll_diameter_resources_used.max_roll_diameter_resources_used_id = models_used.max_roll_diameter_resources_used_id " +
                "inner join number_of_cartridges_models_used on number_of_cartridges_models_used.number_of_cartridges_models_used_id = models_used.number_of_cartridges_models_used_id " +
                "inner join chroma_models_uses on chroma_models_uses.chroma_models_uses_id = models_used.chroma_models_uses_id " +
                "inner join type_models_uses on type_models_uses.type_models_uses_id = models_used.type_models_uses_id; " +
                "select models_title, models_producer_title, type_models_uses_type, chroma_models_uses_chroma, number_of_cartridges_models_used_number_of_cartridges, " +
                "max_roll_diameter_resources_size, raw_mat_title, sizes_resources_used_size, USB_connection_for_PC, LAN_connection, USB_connection_to_flash_drive, module_WIFI, WIFI_direct, Air_print, proc_mat_price, factory_title, prod_title from manufactured_products " +
                "inner join `tmp_table` on `tmp_table`.model_id = manufactured_products.model_id and `tmp_table`.factory_id = manufactured_products.factory_id " +
                "inner join produced_products on produced_products.prod_id = manufactured_products.prod_id " + condition + "; " +
                "drop table `tmp_table` ";
      var command = new MySqlCommand(@base, connection);
      connection.Open();
      MySqlDataReader reader = command.ExecuteReader();
      while (reader.Read())
      {
        list.Add(new MainTable()
        {
          Model = reader.GetString(0),
          Producer = reader.GetString(1),
          Type = reader.GetString(2),
          Chroma = reader.GetString(3),
          Quantity = reader.GetString(4),
          Material = reader.GetString(5),
          Size = reader.GetString(6),
          Format = reader.GetString(7),
          PCConnection = ConverBoolToYN(reader.GetString(8)),
          LANConnection = ConverBoolToYN(reader.GetString(9)),
          FlashDriveConnection = ConverBoolToYN(reader.GetString(10)),
          ModuleWIFI = ConverBoolToYN(reader.GetString(11)),
          WIFIDirect = ConverBoolToYN(reader.GetString(12)),
          AirPrint = ConverBoolToYN(reader.GetString(13)),
          Price = reader.GetInt32(14),
          Factory = reader.GetString(15),
          Products = reader.GetString(16),
        });
      }

      //Check

      BindingSource binding = new BindingSource();
      binding.DataSource = list;

      //bind datagridview to binding source
      dataGridView1.DataSource = binding;
      connection.Close();
    }
    private string ConverBoolToYN(string value) => value == "True" ? "да" : "нет";

    /*private void ProductionChanged(object sender, EventArgs e)
    {
      int i = 0;
      //string text = (System.Windows.Forms.CheckBox)sender.
    }*/
  }
}
