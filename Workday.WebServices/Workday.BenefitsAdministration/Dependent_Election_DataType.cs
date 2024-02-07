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
	public class Dependent_Election_DataType : INotifyPropertyChanged
	{
		private DependentObjectType dependent_ReferenceField;

		private string provider_IDField;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DependentObjectType Dependent_Reference
		{
			get
			{
				return this.dependent_ReferenceField;
			}
			set
			{
				this.dependent_ReferenceField = value;
				this.RaisePropertyChanged("Dependent_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Provider_ID
		{
			get
			{
				return this.provider_IDField;
			}
			set
			{
				this.provider_IDField = value;
				this.RaisePropertyChanged("Provider_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.original_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_DateSpecified");
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
