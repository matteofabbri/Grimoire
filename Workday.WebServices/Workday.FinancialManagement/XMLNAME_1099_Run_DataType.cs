using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class XMLNAME_1099_Run_DataType : INotifyPropertyChanged
	{
		private DateTime calendar_YearField;

		private bool calendar_YearFieldSpecified;

		private XMLNAME_1099_Company_DataType payor_Company_DataField;

		private string amount_CodesField;

		private decimal count_of_PayeesField;

		private bool count_of_PayeesFieldSpecified;

		private XMLNAME_1099_MiscType[] iRS_1099_MiscField;

		private XMLNAME_1099_Run_Summary_Box_DataType[] iRS_1099_Run_Summary_Box_DataField;

		private XMLNAME_1099_Run_Summary_State_Box_DataType[] iRS_1099_Run_Summary_State_Box_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Calendar_Year
		{
			get
			{
				return this.calendar_YearField;
			}
			set
			{
				this.calendar_YearField = value;
				this.RaisePropertyChanged("Calendar_Year");
			}
		}

		[XmlIgnore]
		public bool Calendar_YearSpecified
		{
			get
			{
				return this.calendar_YearFieldSpecified;
			}
			set
			{
				this.calendar_YearFieldSpecified = value;
				this.RaisePropertyChanged("Calendar_YearSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public XMLNAME_1099_Company_DataType Payor_Company_Data
		{
			get
			{
				return this.payor_Company_DataField;
			}
			set
			{
				this.payor_Company_DataField = value;
				this.RaisePropertyChanged("Payor_Company_Data");
			}
		}

		[XmlElement(Order = 2)]
		public string Amount_Codes
		{
			get
			{
				return this.amount_CodesField;
			}
			set
			{
				this.amount_CodesField = value;
				this.RaisePropertyChanged("Amount_Codes");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Count_of_Payees
		{
			get
			{
				return this.count_of_PayeesField;
			}
			set
			{
				this.count_of_PayeesField = value;
				this.RaisePropertyChanged("Count_of_Payees");
			}
		}

		[XmlIgnore]
		public bool Count_of_PayeesSpecified
		{
			get
			{
				return this.count_of_PayeesFieldSpecified;
			}
			set
			{
				this.count_of_PayeesFieldSpecified = value;
				this.RaisePropertyChanged("Count_of_PayeesSpecified");
			}
		}

		[XmlElement("IRS_1099_Misc", Order = 4)]
		public XMLNAME_1099_MiscType[] IRS_1099_Misc
		{
			get
			{
				return this.iRS_1099_MiscField;
			}
			set
			{
				this.iRS_1099_MiscField = value;
				this.RaisePropertyChanged("IRS_1099_Misc");
			}
		}

		[XmlElement("IRS_1099_Run_Summary_Box_Data", Order = 5)]
		public XMLNAME_1099_Run_Summary_Box_DataType[] IRS_1099_Run_Summary_Box_Data
		{
			get
			{
				return this.iRS_1099_Run_Summary_Box_DataField;
			}
			set
			{
				this.iRS_1099_Run_Summary_Box_DataField = value;
				this.RaisePropertyChanged("IRS_1099_Run_Summary_Box_Data");
			}
		}

		[XmlElement("IRS_1099_Run_Summary_State_Box_Data", Order = 6)]
		public XMLNAME_1099_Run_Summary_State_Box_DataType[] IRS_1099_Run_Summary_State_Box_Data
		{
			get
			{
				return this.iRS_1099_Run_Summary_State_Box_DataField;
			}
			set
			{
				this.iRS_1099_Run_Summary_State_Box_DataField = value;
				this.RaisePropertyChanged("IRS_1099_Run_Summary_State_Box_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
