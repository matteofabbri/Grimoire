using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Non-Qualified_Pension_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class NonQualified_Pension_DataType : INotifyPropertyChanged
	{
		private decimal section_457_Dist_YTDField;

		private bool section_457_Dist_YTDFieldSpecified;

		private decimal nonsection_457_Dist_YTDField;

		private bool nonsection_457_Dist_YTDFieldSpecified;

		private decimal section_457_Contrib_YTDField;

		private bool section_457_Contrib_YTDFieldSpecified;

		private decimal nonsection_457_Contrib_YTDField;

		private bool nonsection_457_Contrib_YTDFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Section_457_Dist_YTD
		{
			get
			{
				return this.section_457_Dist_YTDField;
			}
			set
			{
				this.section_457_Dist_YTDField = value;
				this.RaisePropertyChanged("Section_457_Dist_YTD");
			}
		}

		[XmlIgnore]
		public bool Section_457_Dist_YTDSpecified
		{
			get
			{
				return this.section_457_Dist_YTDFieldSpecified;
			}
			set
			{
				this.section_457_Dist_YTDFieldSpecified = value;
				this.RaisePropertyChanged("Section_457_Dist_YTDSpecified");
			}
		}

		[XmlElement("Non-section_457_Dist_YTD", Order = 1)]
		public decimal Nonsection_457_Dist_YTD
		{
			get
			{
				return this.nonsection_457_Dist_YTDField;
			}
			set
			{
				this.nonsection_457_Dist_YTDField = value;
				this.RaisePropertyChanged("Nonsection_457_Dist_YTD");
			}
		}

		[XmlIgnore]
		public bool Nonsection_457_Dist_YTDSpecified
		{
			get
			{
				return this.nonsection_457_Dist_YTDFieldSpecified;
			}
			set
			{
				this.nonsection_457_Dist_YTDFieldSpecified = value;
				this.RaisePropertyChanged("Nonsection_457_Dist_YTDSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Section_457_Contrib_YTD
		{
			get
			{
				return this.section_457_Contrib_YTDField;
			}
			set
			{
				this.section_457_Contrib_YTDField = value;
				this.RaisePropertyChanged("Section_457_Contrib_YTD");
			}
		}

		[XmlIgnore]
		public bool Section_457_Contrib_YTDSpecified
		{
			get
			{
				return this.section_457_Contrib_YTDFieldSpecified;
			}
			set
			{
				this.section_457_Contrib_YTDFieldSpecified = value;
				this.RaisePropertyChanged("Section_457_Contrib_YTDSpecified");
			}
		}

		[XmlElement("Non-section_457_Contrib_YTD", Order = 3)]
		public decimal Nonsection_457_Contrib_YTD
		{
			get
			{
				return this.nonsection_457_Contrib_YTDField;
			}
			set
			{
				this.nonsection_457_Contrib_YTDField = value;
				this.RaisePropertyChanged("Nonsection_457_Contrib_YTD");
			}
		}

		[XmlIgnore]
		public bool Nonsection_457_Contrib_YTDSpecified
		{
			get
			{
				return this.nonsection_457_Contrib_YTDFieldSpecified;
			}
			set
			{
				this.nonsection_457_Contrib_YTDFieldSpecified = value;
				this.RaisePropertyChanged("Nonsection_457_Contrib_YTDSpecified");
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
