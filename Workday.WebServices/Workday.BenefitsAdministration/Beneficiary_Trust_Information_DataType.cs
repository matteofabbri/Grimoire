using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Beneficiary_Trust_Information_DataType : INotifyPropertyChanged
	{
		private string trust_NameField;

		private string tax_IDField;

		private DateTime trust_DateField;

		private bool trust_DateFieldSpecified;

		private Trustee_Personal_Information_DataType trustee_Personal_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Trust_Name
		{
			get
			{
				return this.trust_NameField;
			}
			set
			{
				this.trust_NameField = value;
				this.RaisePropertyChanged("Trust_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_ID
		{
			get
			{
				return this.tax_IDField;
			}
			set
			{
				this.tax_IDField = value;
				this.RaisePropertyChanged("Tax_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Trust_Date
		{
			get
			{
				return this.trust_DateField;
			}
			set
			{
				this.trust_DateField = value;
				this.RaisePropertyChanged("Trust_Date");
			}
		}

		[XmlIgnore]
		public bool Trust_DateSpecified
		{
			get
			{
				return this.trust_DateFieldSpecified;
			}
			set
			{
				this.trust_DateFieldSpecified = value;
				this.RaisePropertyChanged("Trust_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Trustee_Personal_Information_DataType Trustee_Personal_Information_Data
		{
			get
			{
				return this.trustee_Personal_Information_DataField;
			}
			set
			{
				this.trustee_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Trustee_Personal_Information_Data");
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
