using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Disability_Status_DataType : INotifyPropertyChanged
	{
		private Disability_Status_ReferenceObjectType disability_Status_ReferenceField;

		private DisabilityObjectType disability_ReferenceField;

		private DateTime disability_Status_DateField;

		private bool disability_Status_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Disability_Status_ReferenceObjectType Disability_Status_Reference
		{
			get
			{
				return this.disability_Status_ReferenceField;
			}
			set
			{
				this.disability_Status_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public DisabilityObjectType Disability_Reference
		{
			get
			{
				return this.disability_ReferenceField;
			}
			set
			{
				this.disability_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Disability_Status_Date
		{
			get
			{
				return this.disability_Status_DateField;
			}
			set
			{
				this.disability_Status_DateField = value;
				this.RaisePropertyChanged("Disability_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Disability_Status_DateSpecified
		{
			get
			{
				return this.disability_Status_DateFieldSpecified;
			}
			set
			{
				this.disability_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disability_Status_DateSpecified");
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
