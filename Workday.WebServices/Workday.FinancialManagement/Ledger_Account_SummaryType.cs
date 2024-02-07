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
	public class Ledger_Account_SummaryType : INotifyPropertyChanged
	{
		private Ledger_Account_SummaryObjectType ledger_Account_Summary_ReferenceField;

		private Ledger_Account_Summary_DataType[] ledger_Account_Summary_DataField;

		private Ledger_AccountObjectType[] all_Ledger_Account_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Ledger_Account_SummaryObjectType Ledger_Account_Summary_Reference
		{
			get
			{
				return this.ledger_Account_Summary_ReferenceField;
			}
			set
			{
				this.ledger_Account_Summary_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Summary_Reference");
			}
		}

		[XmlElement("Ledger_Account_Summary_Data", Order = 1)]
		public Ledger_Account_Summary_DataType[] Ledger_Account_Summary_Data
		{
			get
			{
				return this.ledger_Account_Summary_DataField;
			}
			set
			{
				this.ledger_Account_Summary_DataField = value;
				this.RaisePropertyChanged("Ledger_Account_Summary_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Ledger_Account_Included_Reference", typeof(Ledger_AccountObjectType), IsNullable = false)]
		public Ledger_AccountObjectType[] All_Ledger_Account_Data
		{
			get
			{
				return this.all_Ledger_Account_DataField;
			}
			set
			{
				this.all_Ledger_Account_DataField = value;
				this.RaisePropertyChanged("All_Ledger_Account_Data");
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
