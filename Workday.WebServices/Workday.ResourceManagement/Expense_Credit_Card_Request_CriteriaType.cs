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
	public class Expense_Credit_Card_Request_CriteriaType : INotifyPropertyChanged
	{
		private Corporate_Credit_Card_AccountObjectType corporate_Credit_Card_Account_ReferenceField;

		private string employee_IDField;

		private string last_4_Digits_of_Credit_Card_NumberField;

		private Document_StatusObjectType document_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Corporate_Credit_Card_AccountObjectType Corporate_Credit_Card_Account_Reference
		{
			get
			{
				return this.corporate_Credit_Card_Account_ReferenceField;
			}
			set
			{
				this.corporate_Credit_Card_Account_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Last_4_Digits_of_Credit_Card_Number
		{
			get
			{
				return this.last_4_Digits_of_Credit_Card_NumberField;
			}
			set
			{
				this.last_4_Digits_of_Credit_Card_NumberField = value;
				this.RaisePropertyChanged("Last_4_Digits_of_Credit_Card_Number");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
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
