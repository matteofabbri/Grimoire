using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class T4A_Contact_InformationType : INotifyPropertyChanged
	{
		private string t4A_Contact_NameField;

		private string t4A_Contact_Phone_NumberField;

		private string t4A_Contact_Email_AddressField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string T4A_Contact_Name
		{
			get
			{
				return this.t4A_Contact_NameField;
			}
			set
			{
				this.t4A_Contact_NameField = value;
				this.RaisePropertyChanged("T4A_Contact_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string T4A_Contact_Phone_Number
		{
			get
			{
				return this.t4A_Contact_Phone_NumberField;
			}
			set
			{
				this.t4A_Contact_Phone_NumberField = value;
				this.RaisePropertyChanged("T4A_Contact_Phone_Number");
			}
		}

		[XmlElement(Order = 2)]
		public string T4A_Contact_Email_Address
		{
			get
			{
				return this.t4A_Contact_Email_AddressField;
			}
			set
			{
				this.t4A_Contact_Email_AddressField = value;
				this.RaisePropertyChanged("T4A_Contact_Email_Address");
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
