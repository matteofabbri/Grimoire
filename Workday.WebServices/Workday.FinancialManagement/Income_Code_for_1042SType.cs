using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Income_Code_for_1042-SType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Income_Code_for_1042SType : INotifyPropertyChanged
	{
		private Income_Code_for_1042SObjectType income_Code_for_1042S_ReferenceField;

		private Income_Code_for_1042S_DataType[] income_Code_for_1042S_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Income_Code_for_1042-S_Reference", Order = 0)]
		public Income_Code_for_1042SObjectType Income_Code_for_1042S_Reference
		{
			get
			{
				return this.income_Code_for_1042S_ReferenceField;
			}
			set
			{
				this.income_Code_for_1042S_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_for_1042S_Reference");
			}
		}

		[XmlElement("Income_Code_for_1042-S_Data", Order = 1)]
		public Income_Code_for_1042S_DataType[] Income_Code_for_1042S_Data
		{
			get
			{
				return this.income_Code_for_1042S_DataField;
			}
			set
			{
				this.income_Code_for_1042S_DataField = value;
				this.RaisePropertyChanged("Income_Code_for_1042S_Data");
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
