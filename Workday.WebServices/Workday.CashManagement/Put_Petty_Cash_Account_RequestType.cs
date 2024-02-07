using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Petty_Cash_Account_RequestType : INotifyPropertyChanged
	{
		private Petty_Cash_AccountObjectType petty_Cash_Account_ReferenceField;

		private Petty_Cash_Account_DataType petty_Cash_Account_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Petty_Cash_AccountObjectType Petty_Cash_Account_Reference
		{
			get
			{
				return this.petty_Cash_Account_ReferenceField;
			}
			set
			{
				this.petty_Cash_Account_ReferenceField = value;
				this.RaisePropertyChanged("Petty_Cash_Account_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Petty_Cash_Account_DataType Petty_Cash_Account_Data
		{
			get
			{
				return this.petty_Cash_Account_DataField;
			}
			set
			{
				this.petty_Cash_Account_DataField = value;
				this.RaisePropertyChanged("Petty_Cash_Account_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
