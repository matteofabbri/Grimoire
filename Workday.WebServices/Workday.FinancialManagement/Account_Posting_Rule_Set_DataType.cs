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
	public class Account_Posting_Rule_Set_DataType : INotifyPropertyChanged
	{
		private string account_Posting_Rule_Set_IDField;

		private string account_Posting_Rule_Set_NameField;

		private Account_SetObjectType account_Set_ReferenceField;

		private Account_Posting_Rule_DataType[] account_Posting_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Account_Posting_Rule_Set_ID
		{
			get
			{
				return this.account_Posting_Rule_Set_IDField;
			}
			set
			{
				this.account_Posting_Rule_Set_IDField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Set_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Account_Posting_Rule_Set_Name
		{
			get
			{
				return this.account_Posting_Rule_Set_NameField;
			}
			set
			{
				this.account_Posting_Rule_Set_NameField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Set_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Account_Posting_Rule_Data", Order = 3)]
		public Account_Posting_Rule_DataType[] Account_Posting_Rule_Data
		{
			get
			{
				return this.account_Posting_Rule_DataField;
			}
			set
			{
				this.account_Posting_Rule_DataField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Data");
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
