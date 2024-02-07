using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Rate_Table_Line_DataType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private Graduated_Expense_Rate_DataType[] graduated_Expense_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Criteria_Reference", typeof(Behavior_Spend_DataObjectType), Order = 0), XmlElement("Expense_Rate_Table_Rule_Reference", typeof(Condition_RuleObjectType), Order = 0)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement("Graduated_Expense_Rate_Data", Order = 1)]
		public Graduated_Expense_Rate_DataType[] Graduated_Expense_Rate_Data
		{
			get
			{
				return this.graduated_Expense_Rate_DataField;
			}
			set
			{
				this.graduated_Expense_Rate_DataField = value;
				this.RaisePropertyChanged("Graduated_Expense_Rate_Data");
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
