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
	public class Sales_Item_Fair_Value_Price_List_Snapshot_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Accounting_Worktag_TypeObjectType[] accounting_Worktag_Type_ReferenceField;

		private Sales_Item_Fair_Value_Price_List_Rule_Line_DataType[] sales_Item_Fair_Value_Price_List_Rule_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement("Accounting_Worktag_Type_Reference", Order = 1)]
		public Accounting_Worktag_TypeObjectType[] Accounting_Worktag_Type_Reference
		{
			get
			{
				return this.accounting_Worktag_Type_ReferenceField;
			}
			set
			{
				this.accounting_Worktag_Type_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Worktag_Type_Reference");
			}
		}

		[XmlElement("Sales_Item_Fair_Value_Price_List_Rule_Line_Data", Order = 2)]
		public Sales_Item_Fair_Value_Price_List_Rule_Line_DataType[] Sales_Item_Fair_Value_Price_List_Rule_Line_Data
		{
			get
			{
				return this.sales_Item_Fair_Value_Price_List_Rule_Line_DataField;
			}
			set
			{
				this.sales_Item_Fair_Value_Price_List_Rule_Line_DataField = value;
				this.RaisePropertyChanged("Sales_Item_Fair_Value_Price_List_Rule_Line_Data");
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
