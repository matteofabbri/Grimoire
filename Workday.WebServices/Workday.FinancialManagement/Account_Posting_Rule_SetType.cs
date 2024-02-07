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
	public class Account_Posting_Rule_SetType : INotifyPropertyChanged
	{
		private Account_Posting_Rule_SetObjectType account_Posting_Rule_Set_ReferenceField;

		private Account_Posting_Rule_Set_DataType[] account_Posting_Rule_Set_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Account_Posting_Rule_SetObjectType Account_Posting_Rule_Set_Reference
		{
			get
			{
				return this.account_Posting_Rule_Set_ReferenceField;
			}
			set
			{
				this.account_Posting_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Set_Reference");
			}
		}

		[XmlElement("Account_Posting_Rule_Set_Data", Order = 1)]
		public Account_Posting_Rule_Set_DataType[] Account_Posting_Rule_Set_Data
		{
			get
			{
				return this.account_Posting_Rule_Set_DataField;
			}
			set
			{
				this.account_Posting_Rule_Set_DataField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Set_Data");
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
