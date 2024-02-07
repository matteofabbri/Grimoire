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
	public class Academic_Period_Weight_DataType : INotifyPropertyChanged
	{
		private Academic_Period_WeightObjectType academic_Period_Weight_ReferenceField;

		private Academic_Period_Weight_TypeObjectType academic_Period_Weight_Type_ReferenceField;

		private decimal academic_Period_Weight_ValueField;

		private bool academic_Period_Weight_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Period_WeightObjectType Academic_Period_Weight_Reference
		{
			get
			{
				return this.academic_Period_Weight_ReferenceField;
			}
			set
			{
				this.academic_Period_Weight_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Weight_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_Period_Weight_TypeObjectType Academic_Period_Weight_Type_Reference
		{
			get
			{
				return this.academic_Period_Weight_Type_ReferenceField;
			}
			set
			{
				this.academic_Period_Weight_Type_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Weight_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Academic_Period_Weight_Value
		{
			get
			{
				return this.academic_Period_Weight_ValueField;
			}
			set
			{
				this.academic_Period_Weight_ValueField = value;
				this.RaisePropertyChanged("Academic_Period_Weight_Value");
			}
		}

		[XmlIgnore]
		public bool Academic_Period_Weight_ValueSpecified
		{
			get
			{
				return this.academic_Period_Weight_ValueFieldSpecified;
			}
			set
			{
				this.academic_Period_Weight_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Period_Weight_ValueSpecified");
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
