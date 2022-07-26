﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewVersion.Report.SaleByCustomerByGaikei
{
    class SalesByGaikeiOBJ
    {


        private string strFactory;
        private int strShipmentLoc;
        private string strCustGroup;
        private string numbersequence;
        private string strNumberSequenceGroup;
        private DateTime dt1;
        private DateTime dt2;
        private bool _ShowWH;
        private string _WH;
        private string strdt;

        /*
            public  InvoiceReportOBJ(DataRow dr)
                {
                    strFactory = dr["Factory"].ToString();
                    dt1 = Convert.ToDateTime(dr["dt1"].ToString());
                    dt2 = Convert.ToDateTime(dr["dt2"].ToString());
                }
        */
        public string Factory
        {
            get
            {
                return strFactory;
            }
            set
            {
                strFactory = value;
            }
        }

        public int ShipmentLocation
        {
            get
            {
                return strShipmentLoc;
            }
            set
            {
                strShipmentLoc = value;
            }
        }

        public string dtDate
        {
            get
            {
                return strdt;
            }
            set
            {
                strdt = value;
            }
        }


        public bool ShowWH
        {
            get
            {
                return _ShowWH;
            }
            set
            {
                _ShowWH = value;
            }
        }


        public string WareHouse
        {
            get
            {
                return _WH;
            }
            set
            {
                _WH = value;
            }
        }



        public string CustomerGroup
        {
            get
            {
                return strCustGroup;
            }
            set
            {
                strCustGroup = value;
            }

        }

        public string NumberSequenceGroup
        {
            get
            {
                return strNumberSequenceGroup;
            }
            set
            {
                strNumberSequenceGroup = value;
            }

        }


        public string numbersequence2
        {
            get
            {
                return numbersequence;

            }
            set
            {

                numbersequence = value;

            }
        }



        public DateTime DateFrom
        {
            get
            {
                return dt1;
            }
            set
            {
                dt1 = value;
            }
        }


        public DateTime DateTo
        {
            get
            {
                return dt2;
            }
            set
            {
                dt2 = value;
            }

        }





    }//end class
}
