using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Type_models_uses
  {
    private string table = "Type_models_uses";
    private string title = "type_models_uses_type";
    private string id = "type_models_uses_id";
    private string description = "type_models_uses_description";
    private int innerValue;
    private List<System.Windows.Forms.CheckBox> listCheckBox;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string Description { get { return description; } }
    public string Id { get { return id; } }
    public List<System.Windows.Forms.CheckBox> ListCheckBox { get { return listCheckBox; } set { listCheckBox = value; } }
    public string GetStringFormat(string someString)
    {
      int counter = 0;
      //string someString = string.Empty;
      //if (someString != String.Empty && ListCheckBox.Count != 0) someString += " and ";
      foreach (var item in listCheckBox)
      {
        if (item.Checked)
        {
          someString += " and ";
          break;
        }
      }
      foreach (var item in listCheckBox)
      {
        if (item.Checked)
        {
          if (someString == string.Empty) someString += "where ";
          if (someString != string.Empty && counter != 0) someString += " or ";
          if(counter == 0) someString +=  "( " +title + " = '" + item.Text + "' ";
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
