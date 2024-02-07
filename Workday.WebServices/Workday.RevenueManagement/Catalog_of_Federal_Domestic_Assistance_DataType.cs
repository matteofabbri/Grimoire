using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Catalog_of_Federal_Domestic_Assistance_DataType : INotifyPropertyChanged
	{
		private string cFDA_NumberField;

		private string cFDA_DescriptionField;

		private bool cFDA_InactiveField;

		private bool cFDA_InactiveFieldSpecified;

		private string cFDA_Reference_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string CFDA_Number
		{
			get
			{
				return this.cFDA_NumberField;
			}
			set
			{
				this.cFDA_NumberField = value;
				this.RaisePropertyChanged("CFDA_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string CFDA_Description
		{
			get
			{
				return this.cFDA_DescriptionField;
			}
			set
			{
				this.cFDA_DescriptionField = value;
				this.RaisePropertyChanged("CFDA_Description");
			}
		}

		[XmlElement(Order = 2)]
		public bool CFDA_Inactive
		{
			get
			{
				return this.cFDA_InactiveField;
			}
			set
			{
				this.cFDA_InactiveField = value;
				this.RaisePropertyChanged("CFDA_Inactive");
			}
		}

		[XmlIgnore]
		public bool CFDA_InactiveSpecified
		{
			get
			{
				return this.cFDA_InactiveFieldSpecified;
			}
			set
			{
				this.cFDA_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("CFDA_InactiveSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string CFDA_Reference_ID
		{
			get
			{
				return this.cFDA_Reference_IDField;
			}
			set
			{
				this.cFDA_Reference_IDField = value;
				this.RaisePropertyChanged("CFDA_Reference_ID");
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
