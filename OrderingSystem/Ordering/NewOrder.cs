using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)//Ordering system.
        {
            int itemsAmount = 16;       //Query the database of how many items are inside.
            int itemsPerRow = 4;        //How many items are on each row
            int itemsPerColumn = 4;        //How many items are on each row
            int curItem = 0;            //Current Item
            int xoffset = 25, yoffset=70; //To move the item grid

            Button[] orderButtons = new Button[itemsAmount];
            for(int i=0;i<itemsPerColumn;i++){//Item handler
            for (int j = 0; j < itemsPerRow; j++)//Row handler
            {
            //Programmatically add the buttons to the form
                orderButtons[curItem] = new Button();
                orderButtons[curItem].Text = ""+curItem;
                this.Controls.Add(orderButtons[curItem]);
                
                //Set Item Properties
                orderButtons[curItem].Size = new Size(100, 100);
                orderButtons[curItem].Location = new Point(xoffset +j * 100,yoffset +  i * 100 );
                //orderButtons[curItem].Image                            //Aaron Assign this to the image in the database
                //orderButtons[curItem].Text = "" + ""                   //Left is STOCK amount RIGHT is PRICE       
                orderButtons[curItem].ForeColor = Color.White;
                orderButtons[curItem].TextAlign = ContentAlignment.BottomRight;
                orderButtons[curItem].FlatStyle = FlatStyle.Flat;
                orderButtons[curItem].FlatAppearance.BorderSize = 1;
                orderButtons[curItem].FlatAppearance.BorderColor = Color.SandyBrown;

                curItem++;
            }}
        }
    }
}
/*
User Account Roles
    Ordering of Items
    Viewing of Ordered items. (Order History)
    Changing Account details
Admin Account roles
    Adding/Editing/Viewing/Deleting of Products
    Viewing of Products
    According to category
All Products
All customer
Order history
Report Generation
Customer Details
Order history by: Day, Month, Year
Summary of Sales.

*/