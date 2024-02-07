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
	public class Ledger_Account_Summary_DataType : INotifyPropertyChanged
	{
		private string ledger_Account_Summary_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string ledger_Account_Summary_NameField;

		private Account_SetObjectType account_Set_ReferenceField;

		private Hierarchy_LevelObjectType hierarchy_Level_ReferenceField;

		private Ledger_Account_SummaryObjectType[] ledger_Account_Summary_ReferenceField;

		private Ledger_AccountObjectType[] included_Ledger_Account_ReferenceField;

		private Ledger_Account_Range_DataType[] included_Ledger_Account_Range_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ledger_Account_Summary_ID
		{
			get
			{
				return this.ledger_Account_Summary_IDField;
			}
			set
			{
				this.ledger_Account_Summary_IDField = value;
				this.RaisePropertyChanged("Ledger_Account_Summary_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Ledger_Account_Summary_Name
		{
			get
			{
				return this.ledger_Account_Summary_NameField;
			}
			set
			{
				this.ledger_Account_Summary_NameField = value;
				this.RaisePropertyChanged("Ledger_Account_Summary_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Account_SetObjectType Account_Set_Reference
		{
			get
			{
				return this.account_Set_ReferenceField;
			}
			set
			{
				this.account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Set_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Hierarchy_LevelObjectType Hierarchy_Level_Reference
		{
			get
			{
				return this.hierarchy_Level_ReferenceField;
			}
			set
			{
				this.hierarchy_Level_ReferenceField = value;
				this.RaisePropertyChanged("Hierarchy_Level_Reference");
			}
		}

		[XmlElement("Ledger_Account_Summary_Reference", Order = 5)]
		public Ledger_Account_SummaryObjectType[] Ledger_Account_Summary_Reference
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

		[XmlElement("Included_Ledger_Account_Reference", Order = 6)]
		public Ledger_AccountObjectType[] Included_Ledger_Account_Reference
		{
			get
			{
				return this.included_Ledger_Account_ReferenceField;
			}
			set
			{
				this.included_Ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Included_Ledger_Account_Reference");
			}
		}

		[XmlElement("Included_Ledger_Account_Range_Data", Order = 7)]
		public Ledger_Account_Range_DataType[] Included_Ledger_Account_Range_Data
		{
			get
			{
				return this.included_Ledger_Account_Range_DataField;
			}
			set
			{
				this.included_Ledger_Account_Range_DataField = value;
				this.RaisePropertyChanged("Included_Ledger_Account_Range_Data");
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
