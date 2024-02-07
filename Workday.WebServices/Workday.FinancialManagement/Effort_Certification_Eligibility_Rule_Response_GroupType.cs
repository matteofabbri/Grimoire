using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Effort_Certification_Eligibility_Rule_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool exclude_Rule_Conditions_DependenciesField;

		private bool exclude_Rule_Conditions_DependenciesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Exclude_Rule_Conditions_Dependencies
		{
			get
			{
				return this.exclude_Rule_Conditions_DependenciesField;
			}
			set
			{
				this.exclude_Rule_Conditions_DependenciesField = value;
				this.RaisePropertyChanged("Exclude_Rule_Conditions_Dependencies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Rule_Conditions_DependenciesSpecified
		{
			get
			{
				return this.exclude_Rule_Conditions_DependenciesFieldSpecified;
			}
			set
			{
				this.exclude_Rule_Conditions_DependenciesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Rule_Conditions_DependenciesSpecified");
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
