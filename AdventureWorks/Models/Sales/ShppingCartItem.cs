using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class ShppingCartItem
    {
        private int shoppingCartItemId;

        public int ShoppingCartItemId
        {
            get { return shoppingCartItemId; }
            set { shoppingCartItemId = value; }
        }

        private int shoppingCartId;

        public int ShoppingCartId
        {
            get { return shoppingCartId; }
            set { shoppingCartId = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string dateCreated;

        public string DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}