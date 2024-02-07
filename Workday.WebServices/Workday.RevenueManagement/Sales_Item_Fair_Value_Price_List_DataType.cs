using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Sales_Item_Fair_Value_Price_List_DataType : INotifyPropertyChanged
	{
		private string sales_Item_Fair_Value_Price_List_Data_IDField;

		private string price_List_NameField;

		private CurrencyObjectType currency_ReferenceField;

		private Sales_Item_Fair_Value_Price_List_Snapshot_DataType[] sales_Item_Fair_Value_Price_List_Snapshot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Sales_Item_Fair_Value_Price_List_Data_ID
		{
			get
			{
				return this.sales_Item_Fair_Value_Price_List_Data_IDField;
			}
			set
			{
				this.sales_Item_Fair_Value_Price_List_Data_IDField = value;
				this.RaisePropertyChanged("Sales_Item_Fair_Value_Price_List_Data_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Price_List_Name
		{
			get
			{
				return this.price_List_NameField;
			}
			set
			{
				this.price_List_NameField = value;
				this.RaisePropertyChanged("Price_List_Name");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement("Sales_Item_Fair_Value_Price_List_Snapshot_Data", Order = 3)]
		public Sales_Item_Fair_Value_Price_List_Snapshot_DataType[] Sales_Item_Fair_Value_Price_List_Snapshot_Data
		{
			get
			{
				return this.sales_Item_Fair_Value_Price_List_Snapshot_DataField;
			}
			set
			{
				this.sales_Item_Fair_Value_Price_List_Snapshot_DataField = value;
				this.RaisePropertyChanged("Sales_Item_Fair_Value_Price_List_Snapshot_Data");
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
