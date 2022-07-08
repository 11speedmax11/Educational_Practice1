using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class Models
  {
    private string table = "Models";
    private string title = "models_title";
    private string id = "models_id";
    private string producerTitle = "models_producer_title";
    private string price = "proc_mat_price";
    private int innerValue;
    private List<System.Windows.Forms.NumericUpDown> listCheckBox;

    public string Table { get { return table; } }
    public string Title { get { return title; } }
    public int Value { get { return innerValue; } set { innerValue = value; } }
    public string ProducerTitle { get { return producerTitle; } }
    public string Id { get { return id; } }
    public string Price { get { return price; } }
    public List<System.Windows.Forms.NumericUpDown> ListCheckBox { get { return listCheckBox; } set { listCheckBox = value; } }
    public string GetStringFormat(string someString)
    {
      //string someString = string.Empty;
      //if (someString != String.Empty) someString += " and ";
      if (someString == string.Empty) someString += "where ";
      someString += " ( proc_mat_price > " + listCheckBox[0].Value + " and proc_mat_price < " + listCheckBox[1].Value + " ) ";

      return someString;
    }
  }
}
