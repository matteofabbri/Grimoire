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
	public class Guest__HV__DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType guest_ReferenceField;

		private Expense_PayeeObjectType[] expense_Payee_ReferenceField;

		private string guest_NameField;

		private string guest_CompanyField;

		private string guest_TitleField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Guest_Reference
		{
			get
			{
				return this.guest_ReferenceField;
			}
			set
			{
				this.guest_ReferenceField = value;
				this.RaisePropertyChanged("Guest_Reference");
			}
		}

		[XmlElement("Expense_Payee_Reference", Order = 1)]
		public Expense_PayeeObjectType[] Expense_Payee_Reference
		{
			get
			{
				return this.expense_Payee_ReferenceField;
			}
			set
			{
				this.expense_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Payee_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Guest_Name
		{
			get
			{
				return this.guest_NameField;
			}
			set
			{
				this.guest_NameField = value;
				this.RaisePropertyChanged("Guest_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Guest_Company
		{
			get
			{
				return this.guest_CompanyField;
			}
			set
			{
				this.guest_CompanyField = value;
				this.RaisePropertyChanged("Guest_Company");
			}
		}

		[XmlElement(Order = 4)]
		public string Guest_Title
		{
			get
			{
				return this.guest_TitleField;
			}
			set
			{
				this.guest_TitleField = value;
				this.RaisePropertyChanged("Guest_Title");
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
