using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Course_Section_Academic_Unit_DataType : INotifyPropertyChanged
	{
		private Academic_Curricular_DivisionObjectType academic_Unit_ReferenceField;

		private decimal aU_Offering_PercentField;

		private bool aU_Offering_PercentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Curricular_DivisionObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal AU_Offering_Percent
		{
			get
			{
				return this.aU_Offering_PercentField;
			}
			set
			{
				this.aU_Offering_PercentField = value;
				this.RaisePropertyChanged("AU_Offering_Percent");
			}
		}

		[XmlIgnore]
		public bool AU_Offering_PercentSpecified
		{
			get
			{
				return this.aU_Offering_PercentFieldSpecified;
			}
			set
			{
				this.aU_Offering_PercentFieldSpecified = value;
				this.RaisePropertyChanged("AU_Offering_PercentSpecified");
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
