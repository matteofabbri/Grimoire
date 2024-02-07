using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Passports_and_Visas_Identification_DataType : INotifyPropertyChanged
	{
		private Passport_IDType[] passport_IDField;

		private Visa_IDType[] visa_IDField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Passport_ID", Order = 0)]
		public Passport_IDType[] Passport_ID
		{
			get
			{
				return this.passport_IDField;
			}
			set
			{
				this.passport_IDField = value;
				this.RaisePropertyChanged("Passport_ID");
			}
		}

		[XmlElement("Visa_ID", Order = 1)]
		public Visa_IDType[] Visa_ID
		{
			get
			{
				return this.visa_IDField;
			}
			set
			{
				this.visa_IDField = value;
				this.RaisePropertyChanged("Visa_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace_All
		{
			get
			{
				return this.replace_AllField;
			}
			set
			{
				this.replace_AllField = value;
				this.RaisePropertyChanged("Replace_All");
			}
		}

		[XmlIgnore]
		public bool Replace_AllSpecified
		{
			get
			{
				return this.replace_AllFieldSpecified;
			}
			set
			{
				this.replace_AllFieldSpecified = value;
				this.RaisePropertyChanged("Replace_AllSpecified");
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
