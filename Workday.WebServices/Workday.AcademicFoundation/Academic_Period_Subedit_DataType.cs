using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Period_Subedit_DataType : INotifyPropertyChanged
	{
		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private DateTime academic_Period_Start_DateField;

		private bool academic_Period_Start_DateFieldSpecified;

		private DateTime academic_Period_End_DateField;

		private bool academic_Period_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Academic_Period_Start_Date
		{
			get
			{
				return this.academic_Period_Start_DateField;
			}
			set
			{
				this.academic_Period_Start_DateField = value;
				this.RaisePropertyChanged("Academic_Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Period_Start_DateSpecified
		{
			get
			{
				return this.academic_Period_Start_DateFieldSpecified;
			}
			set
			{
				this.academic_Period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Academic_Period_End_Date
		{
			get
			{
				return this.academic_Period_End_DateField;
			}
			set
			{
				this.academic_Period_End_DateField = value;
				this.RaisePropertyChanged("Academic_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Period_End_DateSpecified
		{
			get
			{
				return this.academic_Period_End_DateFieldSpecified;
			}
			set
			{
				this.academic_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Period_End_DateSpecified");
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
