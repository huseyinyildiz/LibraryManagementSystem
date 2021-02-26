using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int checkoutId);
        void Add(Checkout newCheckout);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        IEnumerable<CheckoutHistory> GetCheckOutHistory(int id);
        string GetCurrentCheckoutPatron(int assetId);

        void PlaceHold(int assetId, int libraryCardId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        bool IsCheckedOut(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);
        Checkout GetLatestCheckout(int assetId);


        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
