using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Deduction_Recipient_RequestType : INotifyPropertyChanged
	{
		private Deduction_RecipientObjectType payroll_Deduction_Recipient_ReferenceField;

		private Payroll_Deduction_Recipient_DataType payroll_Deduction_Recipient_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Deduction_RecipientObjectType Payroll_Deduction_Recipient_Reference
		{
			get
			{
				return this.payroll_Deduction_Recipient_ReferenceField;
			}
			set
			{
				this.payroll_Deduction_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Deduction_Recipient_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Deduction_Recipient_DataType Payroll_Deduction_Recipient_Data
		{
			get
			{
				return this.payroll_Deduction_Recipient_DataField;
			}
			set
			{
				this.payroll_Deduction_Recipient_DataField = value;
				this.RaisePropertyChanged("Payroll_Deduction_Recipient_Data");
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
