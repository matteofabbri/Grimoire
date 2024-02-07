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
	public class Account_Posting_Rule_Set_Request_ReferencesType : INotifyPropertyChanged
	{
		private Account_Posting_Rule_SetObjectType[] account_Posting_Rule_Set_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Account_Posting_Rule_Set_Reference", Order = 0)]
		public Account_Posting_Rule_SetObjectType[] Account_Posting_Rule_Set_Reference
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
