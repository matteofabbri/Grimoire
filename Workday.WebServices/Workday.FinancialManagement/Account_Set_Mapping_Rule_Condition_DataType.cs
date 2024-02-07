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
	public class Account_Set_Mapping_Rule_Condition_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private string reversal_OrderField;

		private Ledger_AccountObjectType resulting_Ledger_Account_ReferenceField;

		private Condition_Value_Group_DataType[] condition_Value_Group_DataField;

		private Resulting_Value_Group_DataType[] resulting_Value_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public string Reversal_Order
		{
			get
			{
				return this.reversal_OrderField;
			}
			set
			{
				this.reversal_OrderField = value;
				this.RaisePropertyChanged("Reversal_Order");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_AccountObjectType Resulting_Ledger_Account_Reference
		{
			get
			{
				return this.resulting_Ledger_Account_ReferenceField;
			}
			set
			{
				this.resulting_Ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Resulting_Ledger_Account_Reference");
			}
		}

		[XmlElement("Condition_Value_Group_Data", Order = 3)]
		public Condition_Value_Group_DataType[] Condition_Value_Group_Data
		{
			get
			{
				return this.condition_Value_Group_DataField;
			}
			set
			{
				this.condition_Value_Group_DataField = value;
				this.RaisePropertyChanged("Condition_Value_Group_Data");
			}
		}

		[XmlElement("Resulting_Value_Group_Data", Order = 4)]
		public Resulting_Value_Group_DataType[] Resulting_Value_Group_Data
		{
			get
			{
				return this.resulting_Value_Group_DataField;
			}
			set
			{
				this.resulting_Value_Group_DataField = value;
				this.RaisePropertyChanged("Resulting_Value_Group_Data");
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
