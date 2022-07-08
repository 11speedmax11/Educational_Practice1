using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Connections
  {
    /*private string _USB_connection_for_PC = "USB_connection_for_PC";
    private string _LAN_connection = "LAN_connection";
    private string _USB_connection_to_flash_drive = "USB_connection_to_flash_drive";
    private string _module_WIFI = "module_WIFI";
    private string _WIFI_direct = "WIFI_direct";
    private string _Air_print = "Air_print";*/
    private List<string> _listString = new List<string>() { "USB_connection_for_PC", "LAN_connection", "USB_connection_to_flash_drive",
      "module_WIFI", "WIFI_direct", "Air_print"};
    private List<System.Windows.Forms.CheckBox> listCheckBox;

    public List<System.Windows.Forms.CheckBox> CheckBoxes { get => listCheckBox; set => listCheckBox = value; }

    public string GetStringFormat(string someString)
    {
      int counter = 0;
      foreach (var item in listCheckBox)
      {
        if (item.Checked)
        {
          someString += " and ";
          break;
        }
      }

      for(int i = 0; i < listCheckBox.Count; i++)
      {
        if (listCheckBox[i].Checked)
        {
          if (someString == string.Empty) someString += "where ";
          if (someString != string.Empty && counter != 0) someString += " and ";
          if (counter == 0) someString += "( " + _listString[i] + " = " + "True" + " ";
          else someString += _listString[i] + " = " + "True" + " ";
          counter++;
        }
      }

      foreach (var item in listCheckBox)
      {
        if (item.Checked)
        {
          someString += " ) ";
          break;
        }
      }

      return someString;
    }

  }
}
