using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensatable_Guidelines_DataType : INotifyPropertyChanged
	{
		private Compensation_PackageObjectType compensation_Package_ReferenceField;

		private Compensation_GradeObjectType compensation_Grade_ReferenceField;

		private Compensation_Grade_ProfileObjectType compensation_Grade_Profile_ReferenceField;

		private Compensation_StepObjectType compensation_Step_ReferenceField;

		private DateTime progression_Start_DateField;

		private bool progression_Start_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_PackageObjectType Compensation_Package_Reference
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

		[XmlElement(Order = 1)]
		public Compensation_GradeObjectType Compensation_Grade_Reference
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

		[XmlElement(Order = 2)]
		public Compensation_Grade_ProfileObjectType Compensation_Grade_Profile_Reference
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

		[XmlElement(Order = 3)]
		public Compensation_StepObjectType Compensation_Step_Reference
		{
			get
			{
				return this.compensation_Step_ReferenceField;
			}
			set
			{
				this.compensation_Step_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Step_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Progression_Start_Date
		{
			get
			{
				return this.progression_Start_DateField;
			}
			set
			{
				this.progression_Start_DateField = value;
				this.RaisePropertyChanged("Progression_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Progression_Start_DateSpecified
		{
			get
			{
				return this.progression_Start_DateFieldSpecified;
			}
			set
			{
				this.progression_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Progression_Start_DateSpecified");
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
