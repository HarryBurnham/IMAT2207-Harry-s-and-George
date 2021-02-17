using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        
        private Int32 mOrderId;
        public Int32 OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        private Double mCost;
        public Double Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }
        private String mOrderType;
        public String OrderType
        {
            get
            {
                return mOrderType;
            }
            set
            {
                mOrderType = value;
            }
        }
        private Boolean mDispatched;
        public Boolean Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }
        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        
        

        public Boolean Find(Int32 OrderId)
        {
            mOrderId = 2;
            mOrderDate = Convert.ToDateTime("29/10/2000");
            mQuantity = 5;
            mCost = 3.2;
            mOrderType = "fast";
            mDispatched = true;
            mCustomerId = 3;
            return true;
        }

    }
}