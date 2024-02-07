using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Lockbox_DataType : INotifyPropertyChanged
	{
		private string lockbox_IDField;

		private string lockbox_NameField;

		private Address_Information_DataType lockbox_AddressField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Lockbox_ID
		{
			get
			{
				return this.lockbox_IDField;
			}
			set
			{
				this.lockbox_IDField = value;
				this.RaisePropertyChanged("Lockbox_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Lockbox_Name
		{
			get
			{
				return this.lockbox_NameField;
			}
			set
			{
				this.lockbox_NameField = value;
				this.RaisePropertyChanged("Lockbox_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Address_Information_DataType Lockbox_Address
		{
			get
			{
				return this.lockbox_AddressField;
			}
			set
			{
				this.lockbox_AddressField = value;
				this.RaisePropertyChanged("Lockbox_Address");
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
