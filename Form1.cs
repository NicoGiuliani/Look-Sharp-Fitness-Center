using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Look_Sharp_Fitness_Center
{
  public partial class frmLSFC : Form
  {
    double dblItemPrice;
    double dblAdditivePrice;
    double dblRunningTotal;
    int intNumberOfDrinks;
    int intOrders;
    int intItemQuantity;
    string strDrinkSize;
    string strDrinkType;
    string strOrderConfirmation;
    List<string> strOrders = new List<string>();
    List<string> strAdditives = new List<string>();


    public frmLSFC()
    {
      InitializeComponent();
    }


    /***** FUNCTIONS *****/

    // Returns the cost of the items plus the cost of extras times the quantity
    private double calculateCost()
    {
      return ((dblItemPrice + dblAdditivePrice) * intItemQuantity);
    }

    // Makes sure the quantity is greater than zero and that a drink type has been selected
    private bool isOrderValid()
    {
      if (intItemQuantity < 1 || strDrinkType == null)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    // Creates an order using the item quantity, drink size and drink type
    private string createOrder()
    {
      string strCurrentOrder;

      // Determines singular or plural based on number of drinks
      if (intItemQuantity == 1)
      {
        strCurrentOrder = String.Format("- {0} {1} {2}", intItemQuantity, strDrinkSize, strDrinkType);
      }
      else
      {
        strCurrentOrder = String.Format("- {0} {1} {2}", intItemQuantity, strDrinkSize, strDrinkType + "s");
      }

      // If the customer adds extras
      if (strAdditives.Count > 0)
      {
        strCurrentOrder += " with";

        // Logic to determine wording based on number of extras
        if (strAdditives.Count == 1)
        {
          strCurrentOrder += " " + strAdditives[0];
        }
        else if (strAdditives.Count == 2)
        {
          strCurrentOrder += " " + strAdditives[0] + " and " + strAdditives[1];
        }
        else
        {
          strCurrentOrder += " " + strAdditives[0] + ", " + strAdditives[1] + " and " + strAdditives[2];
        }
      }

      return strCurrentOrder;
    }

    // Enables the checkboxes and quantity field
    private void enableCheckBoxesAndQuantity()
    {
      if (strDrinkSize != null)
      {
        chkVitaminPack.Enabled = true;
        chkEnergyBooster.Enabled = true;
        chkForTheLadies.Enabled = true;
        txtQuantity.Enabled = true;
      }
    }

    // Returns the number of orders and the number of drinks
    private string generateSummary()
    {
      string strSummary;

      // Logic to decide whether singulars or plurals should be used
      if (intOrders == 1)
      {
        if (intNumberOfDrinks == 1)
        {
          strSummary = intOrders + " order, " + intNumberOfDrinks + " drink";
        }
        else
        {
          strSummary = intOrders + " order, " + intNumberOfDrinks + " drinks";
        }
      }
      else
      {
        strSummary = intOrders + " orders, " + intNumberOfDrinks + " drinks";
      }

      return strSummary;
    }

    // Clears the form and resets the drink size and drink type variables
    private void clearSelections()
    {
      radTwelveOunce.Checked = false;
      radSixteenOunce.Checked = false;
      radTwentyOunce.Checked = false;
      chkVitaminPack.Checked = false;
      chkEnergyBooster.Checked = false;
      chkForTheLadies.Checked = false;
      txtQuantity.Text = null;
      txtItemPrice.Text = null;
      radFruit.Checked = false;
      radVeggie.Checked = false;
      radPomegranate.Checked = false;
      radStrawberryBanana.Checked = false;
      radWheatBerry.Checked = false;
      strDrinkSize = null;
      strDrinkType = null;
    }

    // Resets variable values
    private void resetValues()
    {
      dblItemPrice = 0;
      dblAdditivePrice = 0;
      dblRunningTotal = 0;
      intNumberOfDrinks = 0;
      intOrders = 0;
      intItemQuantity = 0;
      strOrders = new List<string>();
      strAdditives = new List<string>();
      strOrderConfirmation = null;
    }


    /***** DRINK SIZE RADIO BUTTONS *****/

    private void radTwelveOunce_CheckedChanged(object sender, EventArgs e)
    {
      dblItemPrice = 3.00;
      strDrinkSize = "12oz.";
      enableCheckBoxesAndQuantity();

      if (intItemQuantity == 0)
      {
        intItemQuantity = 1;
      }

      txtQuantity.Text = intItemQuantity.ToString();
      txtItemPrice.Text = calculateCost().ToString("c2");
    }

    private void radSixteenOunce_CheckedChanged(object sender, EventArgs e)
    {
      dblItemPrice = 3.50;
      strDrinkSize = "16oz.";
      enableCheckBoxesAndQuantity();

      if (intItemQuantity == 0)
      {
        intItemQuantity = 1;
      }

      txtQuantity.Text = intItemQuantity.ToString();
      txtItemPrice.Text = calculateCost().ToString("c2");
    }

    private void radTwentyOunce_CheckedChanged(object sender, EventArgs e)
    {
      dblItemPrice = 4.00;
      strDrinkSize = "20oz.";
      enableCheckBoxesAndQuantity();

      if (intItemQuantity == 0)
      {
        intItemQuantity = 1;
      }

      txtQuantity.Text = intItemQuantity.ToString();
      txtItemPrice.Text = calculateCost().ToString("c2");
    }


    /***** CHECKBOXES *****/

    private void chkVitaminPack_CheckedChanged(object sender, EventArgs e)
    {
      if (chkVitaminPack.Checked)
      {
        dblAdditivePrice += 0.50;
        strAdditives.Add("Vitamin Pack");
      }
      else
      {
        dblAdditivePrice -= 0.50;
        strAdditives.Remove("Vitamin Pack");
      }

      txtItemPrice.Text = calculateCost().ToString("c2");
    }

    private void chkEnergyBooster_CheckedChanged(object sender, EventArgs e)
    {
      if (chkEnergyBooster.Checked)
      {
        dblAdditivePrice += 0.50;
        strAdditives.Add("Energy Booster");
      }
      else
      {
        dblAdditivePrice -= 0.50;
        strAdditives.Remove("Energy Booster");
      }

      txtItemPrice.Text = calculateCost().ToString("c2");
    }

    private void chkForTheLadies_CheckedChanged(object sender, EventArgs e)
    {
      if (chkForTheLadies.Checked)
      {
        dblAdditivePrice += 0.50;
        strAdditives.Add("For the Ladies");
      }
      else
      {
        dblAdditivePrice -= 0.50;
        strAdditives.Remove("For the Ladies");
      }

      txtItemPrice.Text = calculateCost().ToString("c2");
    }


    /***** TEXTBOX *****/

    private void txtQuantity_TextChanged(object sender, EventArgs e)
    {
      int x;
      if (int.TryParse(txtQuantity.Text, out x))
      {
        if (txtQuantity.Text == "" || int.Parse(txtQuantity.Text) < 0)
        {
          intItemQuantity = 0;
          txtItemPrice.Text = "";
        }
        else
        {
          intItemQuantity = int.Parse(txtQuantity.Text);
          txtItemPrice.Text = calculateCost().ToString("c2");
        }
      }
      else
      {
        intItemQuantity = 0;
        txtItemPrice.Text = "";
      }
    }


    /***** DRINK TYPE RADIO BUTTONS *****/

    private void radFruit_CheckedChanged(object sender, EventArgs e)
    {
      strDrinkType = "Fruit Juice";
    }

    private void radVeggie_CheckedChanged(object sender, EventArgs e)
    {
      strDrinkType = "Veggie Juice";
    }

    private void radPomegranate_CheckedChanged(object sender, EventArgs e)
    {
      strDrinkType = "Pomegranate Smoothie";
    }

    private void radStrawberryBanana_CheckedChanged(object sender, EventArgs e)
    {
      strDrinkType = "Strawberry Banana Smoothie";
    }

    private void radWheatBerry_CheckedChanged(object sender, EventArgs e)
    {
      strDrinkType = "WheatBerry Smoothie";
    }


    /***** BUTTONS *****/

    private void btnAddToOrder_Click(object sender, EventArgs e)
    {
      if (isOrderValid())
      {
        strOrders.Add(createOrder());
        dblRunningTotal += calculateCost();
        intOrders++;
        intNumberOfDrinks += int.Parse(txtQuantity.Text);
        clearSelections();
      }
      else
      {
        MessageBox.Show("Please select a size, type and quantity.");
      }
    }

    // Displays a summary of the order, then resets all fields
    private void btnOrderComplete_Click(object sender, EventArgs e)
    {
      strOrderConfirmation = null;
      if (strOrders.Count == 0)
      {
        MessageBox.Show("Your order is currently empty. Press 'Add to Order' before continuing.");
      }
      else
      {
        for (var i = 0; i < strOrders.Count; i++)
        {
          strOrderConfirmation += strOrders[i] + "\n";
        }

        MessageBox.Show(generateSummary() + "\n\n" + strOrderConfirmation + "\nYour order comes to " +
                        dblRunningTotal.ToString("c2") + "\n\n---------------------------------------------" +
                        "\n\nThank you for your purchase!", "Summary of your order");
        clearSelections();
        resetValues();
      }
    }

    // Displays a summary of the order but does not finalize it or clear fields
    private void btnSummaryReport_Click(object sender, EventArgs e)
    {
      strOrderConfirmation = null;
      if (strOrders.Count == 0)
      {
        MessageBox.Show("Your order is currently empty. Press 'Add to Order' before continuing.");
      }
      else
      {
        for (var i = 0; i < strOrders.Count; i++)
        {
          strOrderConfirmation += strOrders[i] + "\n";
        }

        MessageBox.Show(generateSummary() + "\n\n" + strOrderConfirmation + "\nYour order comes to " +
                        dblRunningTotal.ToString("c2"), "Summary of your order");
      }
    }

    // Exits application
    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }



    // Not used
    private void frmLSFC_Load(object sender, EventArgs e){}


  }
}