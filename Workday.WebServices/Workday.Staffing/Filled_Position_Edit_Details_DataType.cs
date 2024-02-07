using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Filled_Position_Edit_Details_DataType : INotifyPropertyChanged
	{
		private string position_IDField;

		private object itemField;

		private Position_Details_Sub_DataType position_Details_Sub_DataField;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private Contract_Details_Sub_DataType contract_Details_DataField;

		private bool exclude_from_HeadcountField;

		private bool exclude_from_HeadcountFieldSpecified;

		private DateTime expected_Assignment_End_DateField;

		private bool expected_Assignment_End_DateFieldSpecified;

		private International_Assignment_TypeObjectType international_Assignment_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Position_ID
		{
			get
			{
				return this.position_IDField;
			}
			set
			{
				this.position_IDField = value;
				this.RaisePropertyChanged("Position_ID");
			}
		}

		[XmlElement("Contingent_Worker_Type_Reference", typeof(Contingent_Worker_TypeObjectType), Order = 1), XmlElement("Employee_Type_Reference", typeof(Employee_TypeObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Details_Sub_DataType Position_Details_Sub_Data
		{
			get
			{
				return this.position_Details_Sub_DataField;
			}
			set
			{
				this.position_Details_Sub_DataField = value;
				this.RaisePropertyChanged("Position_Details_Sub_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Employment_Date
		{
			get
			{
				return this.end_Employment_DateField;
			}
			set
			{
				this.end_Employment_DateField = value;
				this.RaisePropertyChanged("End_Employment_Date");
			}
		}

		[XmlIgnore]
		public bool End_Employment_DateSpecified
		{
			get
			{
				return this.end_Employment_DateFieldSpecified;
			}
			set
			{
				this.end_Employment_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_Employment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Contract_Details_Sub_DataType Contract_Details_Data
		{
			get
			{
				return this.contract_Details_DataField;
			}
			set
			{
				this.contract_Details_DataField = value;
				this.RaisePropertyChanged("Contract_Details_Data");
			}
		}

		[XmlElement(Order = 6)]
		public bool Exclude_from_Headcount
		{
			get
			{
				return this.exclude_from_HeadcountField;
			}
			set
			{
				this.exclude_from_HeadcountField = value;
				this.RaisePropertyChanged("Exclude_from_Headcount");
			}
		}

		[XmlIgnore]
		public bool Exclude_from_HeadcountSpecified
		{
			get
			{
				return this.exclude_from_HeadcountFieldSpecified;
			}
			set
			{
				this.exclude_from_HeadcountFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_from_HeadcountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Expected_Assignment_End_Date
		{
			get
			{
				return this.expected_Assignment_End_DateField;
			}
			set
			{
				this.expected_Assignment_End_DateField = value;
				this.RaisePropertyChanged("Expected_Assignment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Assignment_End_DateSpecified
		{
			get
			{
				return this.expected_Assignment_End_DateFieldSpecified;
			}
			set
			{
				this.expected_Assignment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Assignment_End_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public International_Assignment_TypeObjectType International_Assignment_Type_Reference
		{
			get
			{
				return this.international_Assignment_Type_ReferenceField;
			}
			set
			{
				this.international_Assignment_Type_ReferenceField = value;
				this.RaisePropertyChanged("International_Assignment_Type_Reference");
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
