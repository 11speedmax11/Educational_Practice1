using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Produced_products
  {
    private string table = "Produced_products";
    private string title = "prod_title";
    private string id = "prod_id";
    private int innerValue;
    private List<System.Windows.Forms.CheckBox> listCheckBox;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string Id { get { return id; } }
    public List<System.Windows.Forms.CheckBox> ListCheckBox { get { return listCheckBox; } set { listCheckBox = value; } }
    public string GetStringFormat(string someString)
    {
      int counter = 0;
      //if (someString != String.Empty && ListCheckBox.Count != 0) someString += " and ";
      foreach (var item in listCheckBox)
      {
        if (item.Checked)
        {
          someString += " and ";
          break;
        }
      }
      //string someString = string.Empty;
      foreach (var item in listCheckBox)
      {
        if (item.Checked)
        {
          if (someString == string.Empty) someString += "where ";
          if (someString != string.Empty && counter != 0) someString += " or ";
          if (counter == 0) someString += "( " + title + " = '" + item.Text + "' ";
          else someString += title + " = '" + item.Text + "' ";
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
