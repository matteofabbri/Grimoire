using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Inventory_Balance_Detail_Site_ResponseType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Balance_Detail__Inventory_Site_ReferenceField;

		private decimal average_Cost_In_Base_CurrencyField;

		private bool average_Cost_In_Base_CurrencyFieldSpecified;

		private CurrencyObjectType inventory_Balance_Detail_Site_Currency_ReferenceField;

		private Get_Inventory_Balance_Detail_Sub_ResponseType[] get_Inventory_Balance_Detail_Site_Response_ElementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Balance_Detail__Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Balance_Detail__Inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Balance_Detail__Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Balance_Detail__Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Average_Cost_In_Base_Currency
		{
			get
			{
				return this.average_Cost_In_Base_CurrencyField;
			}
			set
			{
				this.average_Cost_In_Base_CurrencyField = value;
				this.RaisePropertyChanged("Average_Cost_In_Base_Currency");
			}
		}

		[XmlIgnore]
		public bool Average_Cost_In_Base_CurrencySpecified
		{
			get
			{
				return this.average_Cost_In_Base_CurrencyFieldSpecified;
			}
			set
			{
				this.average_Cost_In_Base_CurrencyFieldSpecified = value;
				this.RaisePropertyChanged("Average_Cost_In_Base_CurrencySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Inventory_Balance_Detail_Site_Currency_Reference
		{
			get
			{
				return this.inventory_Balance_Detail_Site_Currency_ReferenceField;
			}
			set
			{
				this.inventory_Balance_Detail_Site_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Balance_Detail_Site_Currency_Reference");
			}
		}

		[XmlElement("Get_Inventory_Balance_Detail_Site_Response_Element", Order = 3)]
		public Get_Inventory_Balance_Detail_Sub_ResponseType[] Get_Inventory_Balance_Detail_Site_Response_Element
		{
			get
			{
				return this.get_Inventory_Balance_Detail_Site_Response_ElementField;
			}
			set
			{
				this.get_Inventory_Balance_Detail_Site_Response_ElementField = value;
				this.RaisePropertyChanged("Get_Inventory_Balance_Detail_Site_Response_Element");
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
