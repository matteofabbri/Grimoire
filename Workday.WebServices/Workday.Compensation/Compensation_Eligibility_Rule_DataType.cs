using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Eligibility_Rule_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Condition_Rule_Data_WWSType condition_Rule_DataField;

		private Compensation_PackageObjectType[] compensation_Package_ReferenceField;

		private Compensation_GradeObjectType[] compensation_Grade_ReferenceField;

		private Compensation_Grade_ProfileObjectType[] compensation_Grade_Profile_ReferenceField;

		private Compensation_PlanObjectType[] compensation_Plan_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Condition_Rule_Data_WWSType Condition_Rule_Data
		{
			get
			{
				return this.condition_Rule_DataField;
			}
			set
			{
				this.condition_Rule_DataField = value;
				this.RaisePropertyChanged("Condition_Rule_Data");
			}
		}

		[XmlElement("Compensation_Package_Reference", Order = 2)]
		public Compensation_PackageObjectType[] Compensation_Package_Reference
		{
			get
			{
				return this.compensation_Package_ReferenceField;
			}
			set
			{
				this.compensation_Package_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Package_Reference");
			}
		}

		[XmlElement("Compensation_Grade_Reference", Order = 3)]
		public Compensation_GradeObjectType[] Compensation_Grade_Reference
		{
			get
			{
				return this.compensation_Grade_ReferenceField;
			}
			set
			{
				this.compensation_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_Reference");
			}
		}

		[XmlElement("Compensation_Grade_Profile_Reference", Order = 4)]
		public Compensation_Grade_ProfileObjectType[] Compensation_Grade_Profile_Reference
		{
			get
			{
				return this.compensation_Grade_Profile_ReferenceField;
			}
			set
			{
				this.compensation_Grade_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_Profile_Reference");
			}
		}

		[XmlElement("Compensation_Plan_Reference", Order = 5)]
		public Compensation_PlanObjectType[] Compensation_Plan_Reference
		{
			get
			{
				return this.compensation_Plan_ReferenceField;
			}
			set
			{
				this.compensation_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Plan_Reference");
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
